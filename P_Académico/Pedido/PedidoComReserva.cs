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
    public partial class PedidoComReserva : Form
    {
        public PedidoComReserva()
        {
            InitializeComponent();
        }

        private void btn_carta_Click(object sender, EventArgs e)
        {
            Carta carta = new Carta();
            carta.ShowDialog();
        }
    }
}
