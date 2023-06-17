namespace P_Académico.Produto
{
    partial class CriarProduto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            txtNome = new TextBox();
            label1 = new Label();
            cb_Categoria = new ComboBox();
            label2 = new Label();
            txt_Preco = new TextBox();
            label3 = new Label();
            txt_Descrição = new TextBox();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            btn_Pesquisar = new Button();
            btn_Inserir = new Button();
            errpErro = new ErrorProvider(components);
            panel1 = new Panel();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errpErro).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNome.Location = new Point(32, 94);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(147, 27);
            txtNome.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(32, 70);
            label1.Name = "label1";
            label1.Size = new Size(57, 21);
            label1.TabIndex = 1;
            label1.Text = "Nome";
            // 
            // cb_Categoria
            // 
            cb_Categoria.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cb_Categoria.FormattingEnabled = true;
            cb_Categoria.Items.AddRange(new object[] { "Prato", "Bebida", "Consumiveis" });
            cb_Categoria.Location = new Point(32, 267);
            cb_Categoria.Name = "cb_Categoria";
            cb_Categoria.Size = new Size(147, 29);
            cb_Categoria.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(32, 155);
            label2.Name = "label2";
            label2.Size = new Size(54, 21);
            label2.TabIndex = 5;
            label2.Text = "Preço";
            // 
            // txt_Preco
            // 
            txt_Preco.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Preco.Location = new Point(32, 179);
            txt_Preco.Name = "txt_Preco";
            txt_Preco.Size = new Size(147, 27);
            txt_Preco.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(32, 237);
            label3.Name = "label3";
            label3.Size = new Size(91, 21);
            label3.TabIndex = 6;
            label3.Text = "Categoria";
            // 
            // txt_Descrição
            // 
            txt_Descrição.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Descrição.Location = new Point(240, 94);
            txt_Descrição.Multiline = true;
            txt_Descrição.Name = "txt_Descrição";
            txt_Descrição.ScrollBars = ScrollBars.Horizontal;
            txt_Descrição.Size = new Size(282, 164);
            txt_Descrição.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(240, 70);
            label4.Name = "label4";
            label4.Size = new Size(87, 21);
            label4.TabIndex = 8;
            label4.Text = "Descrição";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ActiveBorder;
            pictureBox1.Location = new Point(570, 94);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(295, 202);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // btn_Pesquisar
            // 
            btn_Pesquisar.BackColor = Color.FromArgb(34, 36, 49);
            btn_Pesquisar.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Pesquisar.ForeColor = SystemColors.ButtonHighlight;
            btn_Pesquisar.Location = new Point(614, 326);
            btn_Pesquisar.Name = "btn_Pesquisar";
            btn_Pesquisar.Size = new Size(198, 47);
            btn_Pesquisar.TabIndex = 10;
            btn_Pesquisar.Text = "Pesquisar imagem";
            btn_Pesquisar.UseVisualStyleBackColor = false;
            btn_Pesquisar.Click += btn_Pesquisar_Click;
            // 
            // btn_Inserir
            // 
            btn_Inserir.BackColor = Color.FromArgb(34, 36, 49);
            btn_Inserir.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Inserir.ForeColor = SystemColors.ButtonHighlight;
            btn_Inserir.Location = new Point(285, 325);
            btn_Inserir.Name = "btn_Inserir";
            btn_Inserir.Size = new Size(172, 48);
            btn_Inserir.TabIndex = 11;
            btn_Inserir.Text = "Inserir";
            btn_Inserir.UseVisualStyleBackColor = false;
            btn_Inserir.Click += btn_Inserir_Click;
            // 
            // errpErro
            // 
            errpErro.ContainerControl = this;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(34, 36, 49);
            panel1.Controls.Add(pictureBox2);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(902, 61);
            panel1.TabIndex = 12;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(34, 36, 49);
            panel2.Location = new Point(0, 389);
            panel2.Name = "panel2";
            panel2.Size = new Size(902, 61);
            panel2.TabIndex = 13;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources._27714066;
            pictureBox2.Location = new Point(32, 8);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(70, 45);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // CriarProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCoral;
            ClientSize = new Size(900, 448);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(btn_Inserir);
            Controls.Add(btn_Pesquisar);
            Controls.Add(pictureBox1);
            Controls.Add(label4);
            Controls.Add(txt_Descrição);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txt_Preco);
            Controls.Add(cb_Categoria);
            Controls.Add(label1);
            Controls.Add(txtNome);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "CriarProduto";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Criar Produto";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errpErro).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNome;
        private Label label1;
        private ComboBox cb_Categoria;
        private Label label2;
        private TextBox txt_Preco;
        private Label label3;
        private TextBox txt_Descrição;
        private Label label4;
        private PictureBox pictureBox1;
        private Button btn_Pesquisar;
        private Button btn_Inserir;
        private ErrorProvider errpErro;
        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox2;
    }
}