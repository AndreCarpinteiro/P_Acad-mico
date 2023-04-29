using FireSharp;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using Newtonsoft.Json;
using P_Académico.Cliente;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P_Académico.Produtos
{
    public partial class ApagarProdutos : Form
    {
        public ApagarProdutos()
        {
            InitializeComponent();
        }
        ClasseProduto produto = new ClasseProduto();
        string idEscolhido;

        IFirebaseConfig fcon = new FirebaseConfig()
        {
            AuthSecret = "OTkUsFiqUxKAbUAqVZS2E5d8WL5G6DHYWSROKFbF",
            BasePath = "https://restaurante-b1d36-default-rtdb.firebaseio.com/"
        };
        IFirebaseClient client;

        private void ApagarProdutos_Load(object sender, EventArgs e)
        {
            try
            {
                client = new FirebaseClient(fcon);
            }
            catch
            {
                MessageBox.Show("Problema na conecção");
            }

            AtualizaDataGrid();
        }

        public async void AtualizaDataGrid()
        {
            FirebaseResponse res = await client.GetAsync(@"Produtos");
            string json = res.Body.ToString();


            if (!String.IsNullOrEmpty(json))
            {
                Dictionary<string, ClasseProduto> data = JsonConvert.DeserializeObject<Dictionary<string, ClasseProduto>>(res.Body.ToString());
                if (data != null && data.Count > 0)
                {
                    PreencherDataGrid(data);
                }
            }
        }

        void PreencherDataGrid(Dictionary<string, ClasseProduto> record)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

            dataGridView1.Columns.Add("ID", "ID");
            dataGridView1.Columns["ID"].Visible = false;
            dataGridView1.Columns.Add("Nome", "Nome");
            dataGridView1.Columns.Add("Categoria", "Categoria");
            dataGridView1.Columns.Add("Preco", "Preco");

            int count = 0;
            foreach (var item in record)
            {
                dataGridView1.Rows.Add(item.Key, item.Value.Nome, item.Value.Categoria, item.Value.Preco);
                produto.ListaDeProdutos.Add(record[item.Key]);
                produto.ListaDeProdutos[count].ProdutoID = item.Key;
                count++;
            }
        }


        private async void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                // Obter a linha selecionada
                DataGridViewRow linhaSelecionada = dataGridView1.CurrentRow;

                // Obter o valor da célula na primeira coluna da linha selecionada
                // Obter o valor da célula na primeira coluna da linha selecionada
                string valorCelula = linhaSelecionada.Cells[0].Value.ToString();
                idEscolhido = valorCelula;

                int count = 0;
                foreach (ClasseProduto item in produto.ListaDeProdutos)
                {
                    if (valorCelula == produto.ListaDeProdutos[count].ProdutoID)
                    {
                        txt_Nome.Text = produto.ListaDeProdutos[count].Nome;
                        cmb_Categoria.Text = produto.ListaDeProdutos[count].Categoria;
                        txt_Preco.Text = produto.ListaDeProdutos[count].Preco;
                        txt_Descricao.Text = produto.ListaDeProdutos[count].Descricao;
                        // Verificar se a imagem em formato base64 existe
                        if (!string.IsNullOrEmpty(produto.ListaDeProdutos[count].Img))
                        {
                            // Converter a imagem em formato base64 para uma imagem Bitmap
                            byte[] imagemBytes = Convert.FromBase64String(produto.ListaDeProdutos[count].Img);
                            using (var stream = new MemoryStream(imagemBytes))
                            {
                                pictureBox1.Image = new Bitmap(stream);
                            }
                        }
                        else
                        {
                            // Definir o controle PictureBox como null ou uma imagem padrão
                            pictureBox1.Image = null; // ou: pictureBox1.Image = Properties.Resources.DefaultImage;
                        }
                    }
                    count++;
                }

            }
        }

        private void btn_Apagar_Click(object sender, EventArgs e)
        {
            FirebaseResponse response = client.Delete("Produtos/" + idEscolhido);
            MessageBox.Show("Apagado com sucesso");
            txt_Nome.Text = string.Empty;
            txt_Preco.Text = string.Empty;
            cmb_Categoria.Text = string.Empty;
            txt_Descricao.Text = string.Empty;
            pictureBox1.Image = null;
            AtualizaDataGrid();
        }
    }
}
