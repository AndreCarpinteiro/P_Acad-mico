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
            panel1 = new Panel();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panelCategoria
            // 
            panelCategoria.Location = new Point(34, 106);
            panelCategoria.Name = "panelCategoria";
            panelCategoria.Size = new Size(175, 471);
            panelCategoria.TabIndex = 0;
            // 
            // panelProdutos
            // 
            panelProdutos.BackColor = SystemColors.ButtonFace;
            panelProdutos.Location = new Point(226, 106);
            panelProdutos.Name = "panelProdutos";
            panelProdutos.Size = new Size(586, 471);
            panelProdutos.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(833, 109);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(325, 468);
            dataGridView1.TabIndex = 2;
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
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1179, 100);
            panel2.TabIndex = 4;
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
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel panelCategoria;
        private FlowLayoutPanel panelProdutos;
        private DataGridView dataGridView1;
        private Panel panel1;
        private Panel panel2;
    }
}