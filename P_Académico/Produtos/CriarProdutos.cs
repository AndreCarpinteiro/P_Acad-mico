using FireSharp;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using Newtonsoft.Json;
using P_Académico.Cliente;
using P_Académico.Produtos;
using P_Académico.Reserva;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P_Académico.Produto
{
    public partial class CriarProduto : Form
    {
        IFirebaseConfig fcon = new FirebaseConfig()
        {
            AuthSecret = "OTkUsFiqUxKAbUAqVZS2E5d8WL5G6DHYWSROKFbF",
            BasePath = "https://restaurante-b1d36-default-rtdb.firebaseio.com/"
        };

        IFirebaseClient client;

        public CriarProduto()
        {
            InitializeComponent();

            client = new FirebaseClient(fcon);
        }

        private void btn_Pesquisar_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Seleciona a imagem";
            ofd.Filter = "Formato da imagem(*.jpg) | *.jpg";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Image img = new Bitmap(ofd.FileName);
                pictureBox1.Image = img.GetThumbnailImage(300, 250, null, new IntPtr());
            }

        }

        private async void btn_Inserir_Click(object sender, EventArgs e)
        {
            MemoryStream ms = new MemoryStream();
            if (pictureBox1.Image != null)
            {
                pictureBox1.Image.Save(ms, ImageFormat.Jpeg);
            }

            byte[] a = ms.GetBuffer();
            string output = Convert.ToBase64String(a);

            var produto = new ClasseProduto()
            {
                Nome = txtNome.Text,
                Preco = txt_Preco.Text,
                Categoria = cb_Categoria.Text,
                Descricao = txt_Descrição.Text,
                Img = output
            };

            if (Confirma() == true)
            {
                // Envia a nova reserva para o Firebase e aguarda a resposta assíncrona
                var response = await client.PushAsync("Produtos", produto);

                // Verifica se a operação foi bem-sucedida e obtem a chave da nova reserva
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    var key = response.Result.name;
                    MessageBox.Show($"Novo produto criado com sucesso! ID: {key}");
                }
                else
                {
                    MessageBox.Show("Falha ao criar novo produto!");
                }
            }
        }

        #region Confirma campos
        //Ver se o user preencheu todos os campos do form
        private bool Confirma()
        {
            errpErro.Dispose();
            int cnt = 0;
            foreach (Control txtb in this.Controls)
            {
                //ver se o user escreveu n
                if (txtb is TextBox)
                {
                    if (txtb.Text == string.Empty)
                    {
                        errpErro.SetError(txtb, "Preencha o campo");
                        cnt++;
                    }
                }

                //ver se o user escolheu um valor das comboboxes
                if (txtb is ComboBox)
                {
                    if (((ComboBox)txtb).SelectedIndex == -1)
                    {
                        errpErro.SetError(txtb, "Escolha um valor");
                        cnt++;
                    }
                }

                //ver se o user preenhceu os campos dentro das groupboxes
                if (txtb is System.Windows.Forms.GroupBox)
                {
                    foreach (Control tb in txtb.Controls)
                    {
                        if (tb is TextBox && tb is System.Windows.Forms.RadioButton)
                        {
                            errpErro.SetError(txtb, "Preencha os campos");
                        }
                    }
                }
            }
            if (cnt == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}