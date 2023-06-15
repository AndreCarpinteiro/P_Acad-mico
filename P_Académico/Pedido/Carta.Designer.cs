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
            panelCategoria = new FlowLayoutPanel();
            panelProdutos = new FlowLayoutPanel();
            dataGridView1 = new DataGridView();
            btn_Adicionar = new Panel();
            button1 = new Button();
            panel2 = new Panel();
            textBox1 = new TextBox();
            Nome = new DataGridViewTextBoxColumn();
            Amount = new DataGridViewTextBoxColumn();
            Id = new DataGridViewTextBoxColumn();
            Preço = new DataGridViewTextBoxColumn();
            Quantidade = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            btn_Adicionar.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panelCategoria
            // 
            panelCategoria.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panelCategoria.Location = new Point(7, 106);
            panelCategoria.Name = "panelCategoria";
            panelCategoria.Size = new Size(254, 471);
            panelCategoria.TabIndex = 0;
            // 
            // panelProdutos
            // 
            panelProdutos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelProdutos.BackColor = SystemColors.ButtonFace;
            panelProdutos.Location = new Point(272, 106);
            panelProdutos.Name = "panelProdutos";
            panelProdutos.Size = new Size(586, 471);
            panelProdutos.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Nome, Amount, Id, Preço, Quantidade });
            dataGridView1.Location = new Point(866, 106);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(303, 468);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellFormatting += dataGridView1_CellFormatting;
            // 
            // btn_Adicionar
            // 
            btn_Adicionar.BackColor = Color.FromArgb(34, 36, 49);
            btn_Adicionar.Controls.Add(button1);
            btn_Adicionar.Dock = DockStyle.Bottom;
            btn_Adicionar.Location = new Point(0, 583);
            btn_Adicionar.Name = "btn_Adicionar";
            btn_Adicionar.Size = new Size(1179, 100);
            btn_Adicionar.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(954, 39);
            button1.Name = "button1";
            button1.Size = new Size(130, 37);
            button1.TabIndex = 0;
            button1.Text = "Adicionar";
            button1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(34, 36, 49);
            panel2.Controls.Add(textBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1179, 100);
            panel2.TabIndex = 4;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(661, 66);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(151, 31);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
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
            // Amount
            // 
            Amount.HeaderText = "Amount";
            Amount.Name = "Amount";
            Amount.ReadOnly = true;
            Amount.Visible = false;
            // 
            // Id
            // 
            Id.HeaderText = "ID";
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Visible = false;
            // 
            // Preço
            // 
            Preço.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Preço.FillWeight = 50F;
            Preço.HeaderText = "Preço";
            Preço.MinimumWidth = 50;
            Preço.Name = "Preço";
            Preço.Width = 60;
            // 
            // Quantidade
            // 
            Quantidade.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Quantidade.FillWeight = 50F;
            Quantidade.HeaderText = "Quantidade";
            Quantidade.MinimumWidth = 50;
            Quantidade.Name = "Quantidade";
            Quantidade.Width = 90;
            // 
            // Carta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1179, 683);
            Controls.Add(panel2);
            Controls.Add(btn_Adicionar);
            Controls.Add(dataGridView1);
            Controls.Add(panelProdutos);
            Controls.Add(panelCategoria);
            Name = "Carta";
            Text = "Carta";
            Load += Carta_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            btn_Adicionar.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel panelCategoria;
        private FlowLayoutPanel panelProdutos;
        private DataGridView dataGridView1;
        private Panel btn_Adicionar;
        private Panel panel2;
        private TextBox textBox1;
        private Button button1;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn Amount;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Preço;
        private DataGridViewTextBoxColumn Quantidade;
    }
}