using FireSharp;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using Newtonsoft.Json;
using P_Académico.Produtos;
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

namespace P_Académico.Pedido
{
    public partial class Carta : Form
    {
        public Carta()
        {
            InitializeComponent();
        }

        ucProduto produto = new ucProduto();

        IFirebaseConfig fcon = new FirebaseConfig()
        {
            AuthSecret = "OTkUsFiqUxKAbUAqVZS2E5d8WL5G6DHYWSROKFbF",
            BasePath = "https://restaurante-b1d36-default-rtdb.firebaseio.com/"
        };
        IFirebaseClient client;

        private void Carta_Load(object sender, EventArgs e)
        {
            try
            {
                client = new FirebaseClient(fcon);
            }
            catch
            {
                MessageBox.Show("Problema na conecção");
            }
            AddCategory();
            panelProdutos.Controls.Clear();
            CarregarProdutos();
            dataGridView1.BorderStyle = BorderStyle.FixedSingle;
        }

        private async void AddCategory()
        {
            Dictionary<string, ucProduto> data = await ChamadaBD();
            if (data != null && data.Count > 0)
            {
                foreach (KeyValuePair<string, ucProduto> item in data)
                {
                    Button b = new Button();
                    b.Text = item.Value.categoria.ToString();
                    b.Size = new Size(134, 45);
                    b.BackColor = Color.FromArgb(34, 36, 49);
                    b.ForeColor = Color.White;

                    panelCategoria.Controls.Add(b);

                }
            }

        }

        private async Task<Dictionary<string, ucProduto>> ChamadaBD()
        {
            FirebaseResponse res = await client.GetAsync(@"Produtos");
            string json = res.Body.ToString();
            panelCategoria.Controls.Clear();
            Dictionary<string, ucProduto> data = new Dictionary<string, ucProduto>(); // Inicializa a variável data

            if (!String.IsNullOrEmpty(json))
            {
                data = JsonConvert.DeserializeObject<Dictionary<string, ucProduto>>(json);
            }

            return data;
        }


        private void AddItems(string id, string nome, string cat, string preco, Image image)
        {
            var w = new ucProduto()
            {
                Nome = nome,
                Preco = preco,
                categoria = cat,
                Imagem = image,
                id = Convert.ToInt32(id)
            };

            panelProdutos.Controls.Add(w);

            w.onSelect += (ss, ee) =>  //Entra aqui quando o uc é selecionado (metodo da classe) 
            {
                var wdg = (ucProduto)ss;
                foreach (DataGridViewRow item in dataGridView1.Rows)
                {
                    if (Convert.ToInt32(item.Cells["Id"].Value) == wdg.id)
                    {
                        item.Cells["Quantidade"].Value = int.Parse(item.Cells["Quantidade"].Value.ToString()) + 1;
                        item.Cells["Amount"].Value = int.Parse(item.Cells["Quantidade"].Value.ToString()) *
                        double.Parse(item.Cells["Preço"].Value.ToString());
                        return;
                    }
                }
                dataGridView1.Rows.Add(new object[] { 0, wdg.id, wdg.Nome, 1, wdg.Preco });
            };
        }

        private async void CarregarProdutos()
        {
            Dictionary<string, ucProduto> data = await ChamadaBD();
            if (data != null && data.Count > 0)
            {
                foreach (KeyValuePair<string, ucProduto> item in data)
                {
                    string id = item.Value.id.ToString();
                    string nome = item.Value.Nome;
                    string categoria = item.Value.categoria;
                    string preco = item.Value.Preco.ToString();

                    // Obtém a imagem do Firebase
                    byte[] imagemBytes = null;
                    if (item.Value.Imagem != null)
                    {
                        FirebaseResponse response = await client.GetAsync("Produtos/" + item.Key + "/Img");
                        if (response != null && response.Body != null)
                        {
                            string base64 = response.Body.ToString();
                            // imagemBytes = Convert.FromBase64String(base64);
                        }
                    }

                    // Cria um objeto Bitmap a partir dos bytes da imagem
                    Image imagem = null;
                    if (imagemBytes != null)
                    {
                        using (MemoryStream ms = new MemoryStream(imagemBytes))
                        {
                            imagem = new Bitmap(ms);
                        }
                    }

                    // Passa o objeto Bitmap para o método AddItems
                    AddItems(id, nome, categoria, preco, imagem);
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            foreach (var item in panelProdutos.Controls)
            {//Pesquisa da text box
                var pro = (ucProduto)item;
                pro.Visible = pro.Nome.ToLower().Contains(textBox1.Text.Trim().ToLower());
            }
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            int count = 0;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                count++;
                row.Cells[0].Value = count;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}