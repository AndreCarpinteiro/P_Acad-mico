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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(25, 28);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(352, 555);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ActiveBorder;
            pictureBox1.Location = new Point(433, 28);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(241, 178);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // btn_Apagar
            // 
            btn_Apagar.Location = new Point(433, 541);
            btn_Apagar.Name = "btn_Apagar";
            btn_Apagar.Size = new Size(100, 42);
            btn_Apagar.TabIndex = 2;
            btn_Apagar.Text = "Apagar";
            btn_Apagar.UseVisualStyleBackColor = true;
            btn_Apagar.Click += btn_Apagar_Click;
            // 
            // txt_Nome
            // 
            txt_Nome.Location = new Point(433, 236);
            txt_Nome.Name = "txt_Nome";
            txt_Nome.Size = new Size(100, 23);
            txt_Nome.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(433, 218);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 4;
            label1.Text = "Nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(433, 338);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 6;
            label2.Text = "Preço";
            // 
            // txt_Preco
            // 
            txt_Preco.Location = new Point(433, 356);
            txt_Preco.Name = "txt_Preco";
            txt_Preco.Size = new Size(100, 23);
            txt_Preco.TabIndex = 5;
            // 
            // cmb_Categoria
            // 
            cmb_Categoria.FormattingEnabled = true;
            cmb_Categoria.Location = new Point(433, 295);
            cmb_Categoria.Name = "cmb_Categoria";
            cmb_Categoria.Size = new Size(121, 23);
            cmb_Categoria.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(433, 277);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 8;
            label3.Text = "Categoria";
            // 
            // btn_Update
            // 
            btn_Update.Location = new Point(578, 541);
            btn_Update.Name = "btn_Update";
            btn_Update.Size = new Size(96, 42);
            btn_Update.TabIndex = 9;
            btn_Update.Text = "Update";
            btn_Update.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(433, 396);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 11;
            label4.Text = "Descrição";
            // 
            // txt_Descricao
            // 
            txt_Descricao.Location = new Point(433, 414);
            txt_Descricao.Multiline = true;
            txt_Descricao.Name = "txt_Descricao";
            txt_Descricao.Size = new Size(241, 112);
            txt_Descricao.TabIndex = 10;
            // 
            // ApagarProdutos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(698, 605);
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
            Name = "ApagarProdutos";
            Text = "ApagarProdutos";
            Load += ApagarProdutos_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
    }
}