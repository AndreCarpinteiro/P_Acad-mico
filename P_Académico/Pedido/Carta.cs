using FireSharp;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using Newtonsoft.Json;
using P_Académico.Produtos;
using P_Académico.Pedido;
using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using P_Académico.Cliente;
using System.Globalization;

namespace P_Académico.Pedido
{
    public partial class Carta : Form
    {
        public Carta()
        {
            InitializeComponent();
        }

        List<Pedido> pedidos = new List<Pedido>();
        DateTime dataAtual = DateTime.Now;

        IFirebaseConfig fcon = new FirebaseConfig()
        {
            AuthSecret = "OTkUsFiqUxKAbUAqVZS2E5d8WL5G6DHYWSROKFbF",
            BasePath = "https://restaurante-b1d36-default-rtdb.firebaseio.com/"
        };
        IFirebaseClient client;

        private async void Carta_Load(object sender, EventArgs e)
        {

            client = new FireSharp.FirebaseClient(fcon);

            if (client != null)
            {
                FirebaseResponse response = await client.GetAsync("ListaClientes");
                Dictionary<string, ClasseCliente> clientes = response.ResultAs<Dictionary<string, ClasseCliente>>();

                if (clientes != null)
                {
                    datagridClient.Rows.Clear();

                    foreach (var cliente in clientes.Values)
                    {
                        int rowIndex = datagridClient.Rows.Add(cliente.NIF, cliente.Nome, cliente.Apelido);
                        datagridClient.Rows[rowIndex].Cells["ID"].Value = cliente.Id;
                        datagridClient.Columns["ID"].Visible = false;
                    }
                }
            }

            // Configurar o modo de seleção do datagridClient para FullRowSelect
            datagridClient.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Atribuir o manipulador de eventos ao evento CellClick
            datagridClient.CellClick += datagridClient_CellClick;

            // Carregar produtos
            FirebaseResponse responseProdutos = await client.GetAsync("Produtos");
            Dictionary<string, ClasseProduto> produtos = responseProdutos.ResultAs<Dictionary<string, ClasseProduto>>();

            if (produtos != null)
            {
                listView1.Items.Clear();

                foreach (var produto in produtos.Values)
                {
                    ListViewItem item = new ListViewItem();
                    item.Text = produto.Nome;
                    item.SubItems.Add($"{produto.Preco:F2}");
                    item.SubItems.Add(produto.Categoria);
                    listView1.Items.Add(item);
                }
            }
        }

        private async void poe_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView1.SelectedItems[0];

                string nome = selectedItem.Text;
                decimal preco = decimal.Parse(selectedItem.SubItems[1].Text);
                string categoria = selectedItem.SubItems[2].Text; // Obter o valor da categoria

                bool produtoExistente = false;
                int rowIndex = -1;

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (!row.IsNewRow && row.Cells[0].Value.ToString() == nome)
                    {
                        int quantidade;
                        if (int.TryParse(row.Cells[1].Value.ToString(), out quantidade))
                        {
                            quantidade++;
                            row.Cells[1].Value = quantidade.ToString();
                            row.Cells[2].Value = (preco * quantidade).ToString("F2"); // Atualizar o preço total
                            produtoExistente = true;
                            rowIndex = row.Index;
                            break;
                        }
                        else
                        {
                            MessageBox.Show("Quantidade inválida.");
                            return;
                        }
                    }
                }

                if (!produtoExistente)
                {
                    dataGridView1.Rows.Add(nome, "1", (preco * 1).ToString("F2"), categoria); // Adicionar a linha com categoria
                }
                else if (rowIndex != -1)
                {
                    dataGridView1.Rows[rowIndex].Cells[3].Value = categoria; // Atualizar a categoria do produto repetido
                }
            }
        }

        private void tira_Click(object sender, EventArgs e)
        {
            // Verificar se há células selecionadas na dataGridView1
            if (dataGridView1.SelectedCells.Count > 0)
            {
                // Obter a célula selecionada
                DataGridViewCell selectedCell = dataGridView1.SelectedCells[0];

                // Obter a linha da célula selecionada
                DataGridViewRow selectedRow = selectedCell.OwningRow;

                // Obter os valores da linha selecionada
                string nome = selectedRow.Cells[0].Value.ToString();
                string categoria = selectedRow.Cells[2].Value.ToString();
                string preco = selectedRow.Cells[1].Value.ToString();

                // Remover a linha selecionada da dataGridView1
                dataGridView1.Rows.Remove(selectedRow);
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                // Abrir o popup para introduzir a mesa de destino
                using (var form = new MesaPopup())
                {
                    var result = form.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        string mesaDestino = form.MesaDestino;
                        // Continuar com o processamento usando a mesa de destino
                        AdicionarPedido(mesaDestino);
                    }
                }
            }
            else if (datagridClient.SelectedRows.Count > 0)
            {
                // Cliente selecionado
                DataGridViewRow selectedClientRow = datagridClient.SelectedRows[0];
                string clienteID = selectedClientRow.Cells["ID"].Value.ToString();
                AdicionarPedido(clienteID);
            }
            else
            {
                MessageBox.Show("Selecione um cliente ou marque a opção 'Mesa'.");
            }
        }

        private async void AdicionarPedido(string destino)
        {
            if (client != null && dataGridView1.Rows.Count > 0)
            {
                // Verificar se foram adicionados produtos
                if (dataGridView1.Rows.Count > 1) // Considerando que a primeira linha é uma linha vazia
                {
                    string dataFormatada = dataAtual.ToString("dd/MM/yyyy HH:mm:ss");
                    // Adicionar os pedidos
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        if (!row.IsNewRow)
                        {
                            string nome = row.Cells[0].Value.ToString();
                            string categoria = row.Cells[3].Value.ToString();
                            decimal precoAtual = decimal.Parse(row.Cells[2].Value.ToString());
                            int quantidade = int.Parse(row.Cells[1].Value.ToString());
                            decimal precoUnitario = precoAtual / quantidade; // Cálculo do preço unitário

                            Pedido pedido = new Pedido
                            {
                                Nome = nome,
                                Categoria = categoria,
                                Preco = precoUnitario.ToString("F2", CultureInfo.GetCultureInfo("pt-PT")),
                                Quantidade = quantidade,
                                User = destino, // Usar o clienteID ou a mesa de destino
                                Data = new DataPedido
                                {
                                    date = dataAtual.Day,
                                    day = (int)dataAtual.DayOfWeek,
                                    hours = dataAtual.Hour,
                                    minutes = dataAtual.Minute,
                                    month = dataAtual.Month - 1, // Firebase utiliza índice 0 para janeiro
                                    seconds = dataAtual.Second,
                                    time = dataAtual.Ticks / TimeSpan.TicksPerMillisecond,
                                    timezoneOffset = 0, // Supondo que a hora está no fuso horário UTC
                                    year = dataAtual.Year
                                }
                            };

                            FirebaseResponse response = await client.PushAsync("Pedidos/", pedido);
                            if (response.StatusCode != System.Net.HttpStatusCode.OK)
                            {
                                MessageBox.Show("Ocorreu um erro ao adicionar o pedido.");
                                return;
                            }
                        }
                    }

                    MessageBox.Show("Pedidos adicionados com sucesso!");
                    dataGridView1.Rows.Clear();
                }
                else
                {
                    MessageBox.Show("Adicione pelo menos um produto antes de fazer o pedido.");
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void datagridClient_SelectionChanged(object sender, EventArgs e)
        {
            // Verificar se há mais de uma linha selecionada
            if (datagridClient.SelectedRows.Count > 1)
            {
                // Desmarcar todas as outras linhas, mantendo apenas a última selecionada
                foreach (DataGridViewRow row in datagridClient.SelectedRows)
                {
                    if (row != datagridClient.CurrentRow)
                    {
                        row.Selected = false;
                    }
                }
            }
        }

        private void datagridClient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void datagridClient_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar se a célula clicada é uma célula de cabeçalho
            if (e.RowIndex == -1)
            {
                return;
            }

            // Verificar se a célula clicada já está selecionada
            if (datagridClient.Rows[e.RowIndex].Selected)
            {
                // Desmarcar a linha clicada
                datagridClient.Rows[e.RowIndex].Selected = false;
            }
            else
            {
                // Marcar apenas a linha clicada e desmarcar todas as outras
                foreach (DataGridViewRow row in datagridClient.Rows)
                {
                    row.Selected = false;
                }

                datagridClient.Rows[e.RowIndex].Selected = true;
            }

        }

        private void datagridClient_SelectionChanged_1(object sender, EventArgs e)
        {
            // Verificar se há mais de uma linha selecionada
            if (datagridClient.SelectedRows.Count > 1)
            {
                // Desmarcar todas as outras linhas, mantendo apenas a última selecionada
                foreach (DataGridViewRow row in datagridClient.SelectedRows)
                {
                    if (row != datagridClient.CurrentRow)
                    {
                        row.Selected = false;
                    }
                }
            }
        }
    }
}