namespace P_Académico
{
    partial class Menu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            sidebar = new FlowLayoutPanel();
            panel1 = new Panel();
            panel2 = new Panel();
            btnClientes = new Button();
            panel4 = new Panel();
            button3 = new Button();
            sidebarTimer = new System.Windows.Forms.Timer(components);
            panel3 = new Panel();
            btnFuncionarios = new Button();
            button4 = new Button();
            btnReservas = new Button();
            btn_CriarProdutos = new Button();
            btn_Update_Produto = new Button();
            sidebar.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // sidebar
            // 
            sidebar.BackColor = Color.FromArgb(34, 36, 49);
            sidebar.Controls.Add(panel1);
            sidebar.Controls.Add(panel2);
            sidebar.Controls.Add(panel4);
            sidebar.Dock = DockStyle.Left;
            sidebar.Location = new Point(0, 0);
            sidebar.MaximumSize = new Size(245, 597);
            sidebar.MinimumSize = new Size(85, 597);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(245, 597);
            sidebar.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(242, 68);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnClientes);
            panel2.Location = new Point(3, 77);
            panel2.Name = "panel2";
            panel2.Size = new Size(242, 53);
            panel2.TabIndex = 2;
            // 
            // btnClientes
            // 
            btnClientes.BackColor = Color.FromArgb(34, 36, 49);
            btnClientes.FlatStyle = FlatStyle.Flat;
            btnClientes.ForeColor = Color.White;
            btnClientes.Location = new Point(-35, -10);
            btnClientes.Name = "btnClientes";
            btnClientes.Padding = new Padding(30, 0, 0, 0);
            btnClientes.Size = new Size(278, 74);
            btnClientes.TabIndex = 1;
            btnClientes.Text = "     Clientes";
            btnClientes.UseVisualStyleBackColor = false;
            btnClientes.Click += button1_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(button3);
            panel4.Location = new Point(3, 136);
            panel4.Name = "panel4";
            panel4.Size = new Size(242, 68);
            panel4.TabIndex = 3;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(34, 36, 49);
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.White;
            button3.Location = new Point(-18, -3);
            button3.Name = "button3";
            button3.Padding = new Padding(30, 0, 0, 0);
            button3.Size = new Size(278, 74);
            button3.TabIndex = 2;
            button3.Text = "Produtos";
            button3.UseVisualStyleBackColor = false;
            // 
            // sidebarTimer
            // 
            sidebarTimer.Interval = 10;
            sidebarTimer.Tick += sidebar_tick;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnFuncionarios);
            panel3.Location = new Point(2, 146);
            panel3.Name = "panel3";
            panel3.Size = new Size(242, 53);
            panel3.TabIndex = 3;
            // 
            // btnFuncionarios
            // 
            btnFuncionarios.BackColor = Color.FromArgb(34, 36, 49);
            btnFuncionarios.FlatStyle = FlatStyle.Flat;
            btnFuncionarios.ForeColor = Color.White;
            btnFuncionarios.Location = new Point(-35, -10);
            btnFuncionarios.Name = "btnFuncionarios";
            btnFuncionarios.Padding = new Padding(30, 0, 0, 0);
            btnFuncionarios.Size = new Size(278, 74);
            btnFuncionarios.TabIndex = 1;
            btnFuncionarios.Text = "        Funcionários";
            btnFuncionarios.UseVisualStyleBackColor = false;
            btnFuncionarios.Click += button2_Click_1;
            // 
            // button4
            // 
            button4.Location = new Point(321, 114);
            button4.Name = "button4";
            button4.Size = new Size(106, 51);
            button4.TabIndex = 4;
            button4.Text = "Update Delete Cliente";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // btnReservas
            // 
            btnReservas.Location = new Point(321, 182);
            btnReservas.Name = "btnReservas";
            btnReservas.Size = new Size(106, 50);
            btnReservas.TabIndex = 5;
            btnReservas.Text = "Reservas";
            btnReservas.UseVisualStyleBackColor = true;
            btnReservas.Click += btnReservas_Click;
            // 
            // btn_CriarProdutos
            // 
            btn_CriarProdutos.Location = new Point(321, 249);
            btn_CriarProdutos.Name = "btn_CriarProdutos";
            btn_CriarProdutos.Size = new Size(106, 50);
            btn_CriarProdutos.TabIndex = 6;
            btn_CriarProdutos.Text = "Criar Produtos";
            btn_CriarProdutos.UseVisualStyleBackColor = true;
            btn_CriarProdutos.Click += btn_CriarProdutos_Click;
            // 
            // btn_Update_Produto
            // 
            btn_Update_Produto.Location = new Point(321, 316);
            btn_Update_Produto.Name = "btn_Update_Produto";
            btn_Update_Produto.Size = new Size(106, 50);
            btn_Update_Produto.TabIndex = 7;
            btn_Update_Produto.Text = "Update Delete Produto";
            btn_Update_Produto.UseVisualStyleBackColor = true;
            btn_Update_Produto.Click += btn_Update_Produto_Click;
            // 
            // Menu
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.LightCoral;
            ClientSize = new Size(1182, 597);
            Controls.Add(btn_Update_Produto);
            Controls.Add(btn_CriarProdutos);
            Controls.Add(btnReservas);
            Controls.Add(button4);
            Controls.Add(panel3);
            Controls.Add(sidebar);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Menu";
            Text = "Menu Inicial";
            Load += Menu_Load;
            sidebar.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel sidebar;
        private System.Windows.Forms.Timer sidebarTimer;
        private Panel panel1;
        private Button btnClientes;
        private Panel panel2;
        private Panel panel4;
        private Button button3;
        private Panel panel3;
        private Button btnFuncionarios;
        private Button button4;
        private Button btnReservas;
        private Button btn_CriarProdutos;
        private Button btn_Update_Produto;
    }
}