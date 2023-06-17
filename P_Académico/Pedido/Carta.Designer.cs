namespace P_Académico.Pedido
{
    partial class Carta
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
            Nome = new DataGridViewTextBoxColumn();
            quantidade = new DataGridViewTextBoxColumn();
            Preço = new DataGridViewTextBoxColumn();
            Categoria = new DataGridViewTextBoxColumn();
            btn_Adicionar = new Panel();
            checkBox1 = new CheckBox();
            button1 = new Button();
            panel2 = new Panel();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            datagridClient = new DataGridView();
            nif = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            apelido = new DataGridViewTextBoxColumn();
            ID = new DataGridViewTextBoxColumn();
            listView1 = new ListView();
            Produto = new ColumnHeader();
            Preco = new ColumnHeader();
            columnHeader1 = new ColumnHeader();
            poe = new Button();
            tira = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            btn_Adicionar.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)datagridClient).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Nome, quantidade, Preço, Categoria });
            dataGridView1.Location = new Point(605, 103);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(321, 468);
            dataGridView1.TabIndex = 2;
            // 
            // Nome
            // 
            Nome.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Nome.FillWeight = 150F;
            Nome.HeaderText = "Nome";
            Nome.MinimumWidth = 150;
            Nome.Name = "Nome";
            Nome.Width = 150;
            // 
            // quantidade
            // 
            quantidade.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            quantidade.FillWeight = 50F;
            quantidade.HeaderText = "Quantidade";
            quantidade.MinimumWidth = 50;
            quantidade.Name = "quantidade";
            quantidade.Width = 90;
            // 
            // Preço
            // 
            Preço.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Preço.FillWeight = 50F;
            Preço.HeaderText = "Preço total";
            Preço.MinimumWidth = 50;
            Preço.Name = "Preço";
            Preço.Width = 80;
            // 
            // Categoria
            // 
            Categoria.HeaderText = "Categoria";
            Categoria.Name = "Categoria";
            // 
            // btn_Adicionar
            // 
            btn_Adicionar.BackColor = Color.FromArgb(34, 36, 49);
            btn_Adicionar.Controls.Add(checkBox1);
            btn_Adicionar.Controls.Add(button1);
            btn_Adicionar.Dock = DockStyle.Bottom;
            btn_Adicionar.Location = new Point(0, 583);
            btn_Adicionar.Name = "btn_Adicionar";
            btn_Adicionar.Size = new Size(929, 100);
            btn_Adicionar.TabIndex = 3;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox1.ForeColor = SystemColors.ButtonHighlight;
            checkBox1.Location = new Point(43, 34);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(270, 34);
            checkBox1.TabIndex = 2;
            checkBox1.Text = "Cliente sem reserva";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.LightCoral;
            button1.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(320, 25);
            button1.Name = "button1";
            button1.Size = new Size(297, 63);
            button1.TabIndex = 0;
            button1.Text = "Adicionar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(34, 36, 49);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(929, 100);
            panel2.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(646, 46);
            label3.Name = "label3";
            label3.Size = new Size(249, 30);
            label3.TabIndex = 2;
            label3.Text = "Produtos escolhidos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(368, 46);
            label2.Name = "label2";
            label2.Size = new Size(115, 30);
            label2.TabIndex = 1;
            label2.Text = "Produtos";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(102, 46);
            label1.Name = "label1";
            label1.Size = new Size(110, 30);
            label1.TabIndex = 0;
            label1.Text = "Clientes";
            // 
            // datagridClient
            // 
            datagridClient.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            datagridClient.Columns.AddRange(new DataGridViewColumn[] { nif, dataGridViewTextBoxColumn1, apelido, ID });
            datagridClient.Location = new Point(12, 106);
            datagridClient.Name = "datagridClient";
            datagridClient.RowHeadersVisible = false;
            datagridClient.RowTemplate.Height = 25;
            datagridClient.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            datagridClient.Size = new Size(302, 465);
            datagridClient.TabIndex = 5;
            datagridClient.CellClick += datagridClient_CellClick;
            datagridClient.CellContentClick += datagridClient_CellContentClick;
            datagridClient.SelectionChanged += datagridClient_SelectionChanged_1;
            // 
            // nif
            // 
            nif.HeaderText = "Nif";
            nif.Name = "nif";
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Nome";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // apelido
            // 
            apelido.HeaderText = "Apelido";
            apelido.Name = "apelido";
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Visible = false;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { Produto, Preco, columnHeader1 });
            listView1.Location = new Point(320, 106);
            listView1.Name = "listView1";
            listView1.Size = new Size(225, 465);
            listView1.TabIndex = 6;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // Produto
            // 
            Produto.Text = "Produto";
            Produto.Width = 150;
            // 
            // Preco
            // 
            Preco.Text = "Preço Unit";
            Preco.Width = 70;
            // 
            // poe
            // 
            poe.Location = new Point(551, 215);
            poe.Name = "poe";
            poe.Size = new Size(48, 36);
            poe.TabIndex = 7;
            poe.Text = ">>";
            poe.UseVisualStyleBackColor = true;
            poe.Click += poe_Click;
            // 
            // tira
            // 
            tira.Location = new Point(551, 371);
            tira.Name = "tira";
            tira.Size = new Size(48, 36);
            tira.TabIndex = 8;
            tira.Text = "<<";
            tira.UseVisualStyleBackColor = true;
            tira.Click += tira_Click;
            // 
            // Carta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCoral;
            ClientSize = new Size(929, 683);
            Controls.Add(tira);
            Controls.Add(poe);
            Controls.Add(listView1);
            Controls.Add(datagridClient);
            Controls.Add(panel2);
            Controls.Add(btn_Adicionar);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Carta";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Pedido";
            Load += Carta_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            btn_Adicionar.ResumeLayout(false);
            btn_Adicionar.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)datagridClient).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dataGridView1;
        private Panel btn_Adicionar;
        private Panel panel2;
        private Button button1;
        private DataGridView datagridClient;
        private ListView listView1;
        private Label label3;
        private Label label2;
        private Label label1;
        private ColumnHeader Produto;
        private ColumnHeader Preco;
        private Button poe;
        private Button tira;
        private DataGridViewTextBoxColumn nif;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn apelido;
        private DataGridViewTextBoxColumn ID;
        private CheckBox checkBox1;
        private ColumnHeader columnHeader1;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn quantidade;
        private DataGridViewTextBoxColumn Preço;
        private DataGridViewTextBoxColumn Categoria;
    }
}