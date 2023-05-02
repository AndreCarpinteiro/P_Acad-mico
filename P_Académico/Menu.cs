using FireSharp;
using FireSharp.Config;
using FireSharp.Interfaces;
using P_Académico.Cliente;
using P_Académico.Funcionário;
using P_Académico.Reserva;
using P_Académico.Produto;
using P_Académico.Produtos;
using P_Académico.Pedido;

namespace P_Académico
{
    public partial class Menu : Form
    {
        bool sidebarExpand;
        public Menu()
        {
            InitializeComponent();
        }

        private void criaClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cliente.NovoCliente criarCliente = new Cliente.NovoCliente();
            criarCliente.ShowDialog();
        }


        private void sidebar_tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 10;
                if (sidebar.Width == sidebar.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sidebarTimer.Stop();
                }
            }
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width == sidebar.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sidebarTimer.Stop();
                }
            }
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }


        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            NovoCliente criarCliente = new NovoCliente();
            criarCliente.ShowDialog();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            CriarFuncionario criarFuncionario = new CriarFuncionario();
            criarFuncionario.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ApagarEditarCliente apagarEditarCliente = new ApagarEditarCliente();
            apagarEditarCliente.ShowDialog();
        }

        private void btnReservas_Click(object sender, EventArgs e)
        {
            Reservas reserva = new Reservas();
            reserva.ShowDialog();
        }

        private void btn_CriarProdutos_Click(object sender, EventArgs e)
        {
            CriarProduto CriaProduto = new CriarProduto();
            CriaProduto.ShowDialog();
        }

        private void btn_Update_Produto_Click(object sender, EventArgs e)
        {
            ApagarProdutos ApagaProduto = new ApagarProdutos();
            ApagaProduto.ShowDialog();
        }

        private void btn_CriarPedido_Click(object sender, EventArgs e)
        {
            CriarPedido criarPedido = new CriarPedido();
            criarPedido.ShowDialog();
        }
    }
}