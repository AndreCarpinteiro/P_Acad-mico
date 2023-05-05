using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P_Académico.Pedido
{
    public partial class ucProduto : UserControl
    {
        public ucProduto()
        {
            InitializeComponent();
        }

        public event EventHandler onSelect = null;

        public int id { get; set; }

        public string Preco { get; set; }

        public string categoria { get; set; }

        public string Nome
        {
            get { return lbl_Nome.Text; }
            set { lbl_Nome.Text = value; }
        }

        public Image Imagem
        {
            get { return txt_Imagem.Image; }
            set { txt_Imagem.Image = value; }
        }

        private void txt_Imagem_Click(object sender, EventArgs e)
        {
            onSelect?.Invoke(this, e);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Click(object sender, EventArgs e)
        {
            onSelect?.Invoke(this, e);
        }
    }
}