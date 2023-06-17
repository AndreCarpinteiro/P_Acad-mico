namespace P_Académico.Produtos
{
    partial class ApagarProdutos
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
            dataGridView1 = new DataGridView();
            pictureBox1 = new PictureBox();
            btn_Apagar = new Button();
            txt_Nome = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txt_Preco = new TextBox();
            cmb_Categoria = new ComboBox();
            label3 = new Label();
            btn_Update = new Button();
            label4 = new Label();
            txt_Descricao = new TextBox();
            errpErro = new ErrorProvider(components);
            btn_Procurar = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errpErro).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(27, 80);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(352, 555);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ActiveBorder;
            pictureBox1.Location = new Point(435, 80);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(241, 178);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // btn_Apagar
            // 
            btn_Apagar.BackColor = Color.FromArgb(34, 36, 49);
            btn_Apagar.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Apagar.ForeColor = SystemColors.ButtonHighlight;
            btn_Apagar.Location = new Point(435, 593);
            btn_Apagar.Name = "btn_Apagar";
            btn_Apagar.Size = new Size(100, 42);
            btn_Apagar.TabIndex = 2;
            btn_Apagar.Text = "Apagar";
            btn_Apagar.UseVisualStyleBackColor = false;
            btn_Apagar.Click += btn_Apagar_Click;
            // 
            // txt_Nome
            // 
            txt_Nome.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Nome.Location = new Point(435, 294);
            txt_Nome.Name = "txt_Nome";
            txt_Nome.Size = new Size(121, 27);
            txt_Nome.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(435, 270);
            label1.Name = "label1";
            label1.Size = new Size(57, 21);
            label1.TabIndex = 4;
            label1.Text = "Nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(435, 390);
            label2.Name = "label2";
            label2.Size = new Size(54, 21);
            label2.TabIndex = 6;
            label2.Text = "Preço";
            // 
            // txt_Preco
            // 
            txt_Preco.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Preco.Location = new Point(435, 414);
            txt_Preco.Name = "txt_Preco";
            txt_Preco.Size = new Size(121, 27);
            txt_Preco.TabIndex = 5;
            // 
            // cmb_Categoria
            // 
            cmb_Categoria.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cmb_Categoria.FormattingEnabled = true;
            cmb_Categoria.Items.AddRange(new object[] { "Prato", "Bebida", "Consumiveis" });
            cmb_Categoria.Location = new Point(435, 353);
            cmb_Categoria.Name = "cmb_Categoria";
            cmb_Categoria.Size = new Size(121, 29);
            cmb_Categoria.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(435, 329);
            label3.Name = "label3";
            label3.Size = new Size(91, 21);
            label3.TabIndex = 8;
            label3.Text = "Categoria";
            // 
            // btn_Update
            // 
            btn_Update.BackColor = Color.FromArgb(34, 36, 49);
            btn_Update.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Update.ForeColor = SystemColors.ButtonHighlight;
            btn_Update.Location = new Point(580, 593);
            btn_Update.Name = "btn_Update";
            btn_Update.Size = new Size(96, 42);
            btn_Update.TabIndex = 9;
            btn_Update.Text = "Update";
            btn_Update.UseVisualStyleBackColor = false;
            btn_Update.Click += btn_Update_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(435, 448);
            label4.Name = "label4";
            label4.Size = new Size(87, 21);
            label4.TabIndex = 11;
            label4.Text = "Descrição";
            // 
            // txt_Descricao
            // 
            txt_Descricao.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Descricao.Location = new Point(435, 472);
            txt_Descricao.Multiline = true;
            txt_Descricao.Name = "txt_Descricao";
            txt_Descricao.Size = new Size(241, 106);
            txt_Descricao.TabIndex = 10;
            // 
            // errpErro
            // 
            errpErro.ContainerControl = this;
            // 
            // btn_Procurar
            // 
            btn_Procurar.BackColor = Color.FromArgb(34, 36, 49);
            btn_Procurar.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Procurar.ForeColor = SystemColors.ButtonHighlight;
            btn_Procurar.Location = new Point(580, 270);
            btn_Procurar.Name = "btn_Procurar";
            btn_Procurar.Size = new Size(100, 51);
            btn_Procurar.TabIndex = 12;
            btn_Procurar.Text = "Procurar Imagem";
            btn_Procurar.UseVisualStyleBackColor = false;
            btn_Procurar.Click += btn_Procurar_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(34, 36, 49);
            panel1.Controls.Add(pictureBox2);
            panel1.Location = new Point(-2, -4);
            panel1.Name = "panel1";
            panel1.Size = new Size(734, 71);
            panel1.TabIndex = 13;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(34, 36, 49);
            panel2.Location = new Point(-2, 644);
            panel2.Name = "panel2";
            panel2.Size = new Size(734, 71);
            panel2.TabIndex = 14;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources._27714065;
            pictureBox2.Location = new Point(30, 10);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(68, 54);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // ApagarProdutos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCoral;
            ClientSize = new Size(731, 715);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(btn_Procurar);
            Controls.Add(label4);
            Controls.Add(txt_Descricao);
            Controls.Add(btn_Update);
            Controls.Add(label3);
            Controls.Add(cmb_Categoria);
            Controls.Add(label2);
            Controls.Add(txt_Preco);
            Controls.Add(label1);
            Controls.Add(txt_Nome);
            Controls.Add(btn_Apagar);
            Controls.Add(pictureBox1);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "ApagarProdutos";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Apagar Produtos";
            Load += ApagarProdutos_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errpErro).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private PictureBox pictureBox1;
        private Button btn_Apagar;
        private TextBox txt_Nome;
        private Label label1;
        private Label label2;
        private TextBox txt_Preco;
        private ComboBox cmb_Categoria;
        private Label label3;
        private Button btn_Update;
        private Label label4;
        private TextBox txt_Descricao;
        private ErrorProvider errpErro;
        private Button btn_Procurar;
        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox2;
    }
}