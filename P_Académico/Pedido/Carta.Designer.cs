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
            Id = new DataGridViewTextBoxColumn();
            Nome = new DataGridViewTextBoxColumn();
            Preço = new DataGridViewTextBoxColumn();
            Quantidade = new DataGridViewTextBoxColumn();
            Amount = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            panel2 = new Panel();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panelCategoria
            // 
            panelCategoria.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panelCategoria.Location = new Point(34, 106);
            panelCategoria.Name = "panelCategoria";
            panelCategoria.Size = new Size(175, 471);
            panelCategoria.TabIndex = 0;
            // 
            // panelProdutos
            // 
            panelProdutos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelProdutos.BackColor = SystemColors.ButtonFace;
            panelProdutos.Location = new Point(226, 106);
            panelProdutos.Name = "panelProdutos";
            panelProdutos.Size = new Size(586, 471);
            panelProdutos.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Id, Nome, Preço, Quantidade, Amount });
            dataGridView1.Location = new Point(818, 109);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(340, 468);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellFormatting += dataGridView1_CellFormatting;
            // 
            // Id
            // 
            Id.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Id.FillWeight = 30F;
            Id.HeaderText = "Id";
            Id.MinimumWidth = 30;
            Id.Name = "Id";
            Id.Width = 30;
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
            // Preço
            // 
            Preço.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Preço.FillWeight = 50F;
            Preço.HeaderText = "Preço";
            Preço.MinimumWidth = 50;
            Preço.Name = "Preço";
            Preço.Width = 50;
            // 
            // Quantidade
            // 
            Quantidade.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Quantidade.FillWeight = 50F;
            Quantidade.HeaderText = "Quantidade";
            Quantidade.MinimumWidth = 50;
            Quantidade.Name = "Quantidade";
            Quantidade.Width = 50;
            // 
            // Amount
            // 
            Amount.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Amount.FillWeight = 70F;
            Amount.HeaderText = "Amount";
            Amount.MinimumWidth = 70;
            Amount.Name = "Amount";
            Amount.Width = 70;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(34, 36, 49);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 583);
            panel1.Name = "panel1";
            panel1.Size = new Size(1179, 100);
            panel1.TabIndex = 3;
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
            // Carta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1179, 683);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            Controls.Add(panelProdutos);
            Controls.Add(panelCategoria);
            Name = "Carta";
            Text = "Carta";
            Load += Carta_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel panelCategoria;
        private FlowLayoutPanel panelProdutos;
        private DataGridView dataGridView1;
        private Panel panel1;
        private Panel panel2;
        private TextBox textBox1;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn Preço;
        private DataGridViewTextBoxColumn Quantidade;
        private DataGridViewTextBoxColumn Amount;
    }
}