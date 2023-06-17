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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            btnClientes = new Button();
            btn_updatefunc = new Button();
            sidebarTimer = new System.Windows.Forms.Timer(components);
            btnFuncionarios = new Button();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            button4 = new Button();
            btnReservas = new Button();
            btn_CriarProdutos = new Button();
            btn_Update_Produto = new Button();
            btn_CriarPedido = new Button();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // btnClientes
            // 
            btnClientes.BackColor = Color.FromArgb(34, 36, 49);
            btnClientes.FlatStyle = FlatStyle.Flat;
            btnClientes.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnClientes.ForeColor = Color.White;
            btnClientes.Location = new Point(0, 123);
            btnClientes.Name = "btnClientes";
            btnClientes.Padding = new Padding(30, 0, 0, 0);
            btnClientes.Size = new Size(200, 54);
            btnClientes.TabIndex = 1;
            btnClientes.Text = "Criar Cliente";
            btnClientes.UseVisualStyleBackColor = false;
            btnClientes.Click += button1_Click;
            // 
            // btn_updatefunc
            // 
            btn_updatefunc.BackColor = Color.FromArgb(34, 36, 49);
            btn_updatefunc.FlatStyle = FlatStyle.Flat;
            btn_updatefunc.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn_updatefunc.ForeColor = Color.White;
            btn_updatefunc.Location = new Point(0, 429);
            btn_updatefunc.Name = "btn_updatefunc";
            btn_updatefunc.Padding = new Padding(30, 0, 0, 0);
            btn_updatefunc.Size = new Size(200, 54);
            btn_updatefunc.TabIndex = 2;
            btn_updatefunc.Text = "Update Delete Funcionário";
            btn_updatefunc.UseVisualStyleBackColor = false;
            btn_updatefunc.Click += btn_updatefunc_Click_1;
            // 
            // sidebarTimer
            // 
            sidebarTimer.Interval = 10;
            sidebarTimer.Tick += sidebar_tick;
            // 
            // btnFuncionarios
            // 
            btnFuncionarios.BackColor = Color.FromArgb(34, 36, 49);
            btnFuncionarios.FlatStyle = FlatStyle.Flat;
            btnFuncionarios.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnFuncionarios.ForeColor = Color.White;
            btnFuncionarios.Location = new Point(0, 358);
            btnFuncionarios.Name = "btnFuncionarios";
            btnFuncionarios.Padding = new Padding(30, 0, 0, 0);
            btnFuncionarios.Size = new Size(200, 54);
            btnFuncionarios.TabIndex = 1;
            btnFuncionarios.Text = "Criar Funcionário";
            btnFuncionarios.UseVisualStyleBackColor = false;
            btnFuncionarios.Click += button2_Click_1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(34, 36, 49);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(btnClientes);
            panel1.Controls.Add(btnFuncionarios);
            panel1.Controls.Add(btn_updatefunc);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 598);
            panel1.TabIndex = 10;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._2771406;
            pictureBox1.Location = new Point(47, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(101, 83);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(34, 36, 49);
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button4.ForeColor = Color.White;
            button4.Location = new Point(0, 194);
            button4.Name = "button4";
            button4.Padding = new Padding(30, 0, 0, 0);
            button4.Size = new Size(200, 54);
            button4.TabIndex = 11;
            button4.Text = "Update Delete Cliente";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click_1;
            // 
            // btnReservas
            // 
            btnReservas.BackColor = Color.FromArgb(34, 36, 49);
            btnReservas.FlatStyle = FlatStyle.Flat;
            btnReservas.Font = new Font("Century Gothic", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnReservas.ForeColor = Color.White;
            btnReservas.Location = new Point(297, 41);
            btnReservas.Name = "btnReservas";
            btnReservas.Padding = new Padding(30, 0, 0, 0);
            btnReservas.Size = new Size(287, 243);
            btnReservas.TabIndex = 11;
            btnReservas.Text = "                                                                                                                                        Criar Reserva";
            btnReservas.UseVisualStyleBackColor = false;
            btnReservas.Click += btnReservas_Click_1;
            // 
            // btn_CriarProdutos
            // 
            btn_CriarProdutos.BackColor = Color.FromArgb(34, 36, 49);
            btn_CriarProdutos.FlatStyle = FlatStyle.Flat;
            btn_CriarProdutos.Font = new Font("Century Gothic", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            btn_CriarProdutos.ForeColor = Color.White;
            btn_CriarProdutos.Location = new Point(780, 41);
            btn_CriarProdutos.Name = "btn_CriarProdutos";
            btn_CriarProdutos.Padding = new Padding(30, 0, 0, 0);
            btn_CriarProdutos.Size = new Size(287, 243);
            btn_CriarProdutos.TabIndex = 12;
            btn_CriarProdutos.Text = "                                                                                                                                         Criar Produtos";
            btn_CriarProdutos.UseVisualStyleBackColor = false;
            btn_CriarProdutos.Click += btn_CriarProdutos_Click_1;
            // 
            // btn_Update_Produto
            // 
            btn_Update_Produto.BackColor = Color.FromArgb(34, 36, 49);
            btn_Update_Produto.FlatStyle = FlatStyle.Flat;
            btn_Update_Produto.Font = new Font("Century Gothic", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Update_Produto.ForeColor = Color.White;
            btn_Update_Produto.Location = new Point(780, 319);
            btn_Update_Produto.Name = "btn_Update_Produto";
            btn_Update_Produto.Padding = new Padding(30, 0, 0, 0);
            btn_Update_Produto.Size = new Size(287, 243);
            btn_Update_Produto.TabIndex = 13;
            btn_Update_Produto.Text = "                                                                                                                 Update Delete Produto";
            btn_Update_Produto.UseVisualStyleBackColor = false;
            btn_Update_Produto.Click += btn_Update_Produto_Click_1;
            // 
            // btn_CriarPedido
            // 
            btn_CriarPedido.BackColor = Color.FromArgb(34, 36, 49);
            btn_CriarPedido.FlatStyle = FlatStyle.Flat;
            btn_CriarPedido.Font = new Font("Century Gothic", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            btn_CriarPedido.ForeColor = Color.White;
            btn_CriarPedido.Location = new Point(298, 319);
            btn_CriarPedido.Name = "btn_CriarPedido";
            btn_CriarPedido.Padding = new Padding(30, 0, 0, 0);
            btn_CriarPedido.Size = new Size(286, 243);
            btn_CriarPedido.TabIndex = 14;
            btn_CriarPedido.Text = "                                                                                                                                      Criar Pedido";
            btn_CriarPedido.UseVisualStyleBackColor = false;
            btn_CriarPedido.Click += btn_CriarPedido_Click_1;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.LightGray;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(367, 94);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(148, 92);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 15;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.LightGray;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(854, 94);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(148, 92);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 16;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.LightGray;
            pictureBox4.Image = Properties.Resources.png_transparent_shopping_cart_icon_product_return_shopping_cart_retail_supermarket_objects_removebg_preview;
            pictureBox4.Location = new Point(367, 378);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(148, 92);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 17;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.LightGray;
            pictureBox5.Image = Properties.Resources._3082745;
            pictureBox5.Location = new Point(854, 378);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(148, 92);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 18;
            pictureBox5.TabStop = false;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCoral;
            ClientSize = new Size(1182, 597);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(btn_CriarPedido);
            Controls.Add(btn_Update_Produto);
            Controls.Add(btn_CriarProdutos);
            Controls.Add(btnReservas);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Menu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu Inicial";
            Load += Menu_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel sidebar;
        private System.Windows.Forms.Timer sidebarTimer;
        private Button btnClientes;
        private Button btn_updatefunc;
        private Button btnFuncionarios;
        private Panel panel1;
        private Button button4;
        private Button btnReservas;
        private Button btn_CriarProdutos;
        private Button btn_Update_Produto;
        private Button btn_CriarPedido;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
    }
}