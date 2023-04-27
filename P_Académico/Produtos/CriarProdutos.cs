using FireSharp;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using P_Académico.Produtos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
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
                pictureBox1.Image = img.GetThumbnailImage(350, 200, null, new IntPtr());
            }

        }

        private async void btn_Inserir_Click(object sender, EventArgs e)
        {
            MemoryStream ms = new MemoryStream();
            pictureBox1.Image.Save(ms, ImageFormat.Jpeg);

            byte[] a = ms.GetBuffer();

            string output = Convert.ToBase64String(a);

            var data = new Imagem
            {
                Img = output,
            };

            SetResponse response = await client.SetAsync("Imagem/", data);
            Imagem result = response.ResultAs<Imagem>();

            MessageBox.Show("Imagem Inserida");


            MessageBox.Show("Imagem Inserida");

        }
    }
}