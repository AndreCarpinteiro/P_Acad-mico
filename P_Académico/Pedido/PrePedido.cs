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
    public partial class PrePedido : Form
    {
        public PrePedido()
        {
            InitializeComponent();
        }

        private void btn_ComReserva_Click(object sender, EventArgs e)
        {
            PedidoComReserva pedidoComReserva = new PedidoComReserva();
            pedidoComReserva.ShowDialog();
        }

        private void btn_SemReserva_Click(object sender, EventArgs e)
        {
            PedidoSemReserva pedidoSemReserva = new PedidoSemReserva();
            pedidoSemReserva.ShowDialog();
        }
    }
}
