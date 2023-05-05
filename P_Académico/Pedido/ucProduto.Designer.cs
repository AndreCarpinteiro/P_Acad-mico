namespace P_Académico.Pedido
{
    partial class ucProduto
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucProduto));
            panel1 = new Panel();
            panel2 = new Panel();
            lbl_Nome = new Label();
            txt_Imagem = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txt_Imagem).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Peru;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(txt_Imagem);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(182, 188);
            panel1.TabIndex = 0;
            panel1.Click += panel1_Click;
            panel1.Paint += panel1_Paint;
            // 
            // panel2
            // 
            panel2.Controls.Add(lbl_Nome);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 143);
            panel2.Name = "panel2";
            panel2.Size = new Size(182, 45);
            panel2.TabIndex = 1;
            // 
            // lbl_Nome
            // 
            lbl_Nome.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Nome.Location = new Point(6, 5);
            lbl_Nome.Name = "lbl_Nome";
            lbl_Nome.Size = new Size(172, 35);
            lbl_Nome.TabIndex = 2;
            lbl_Nome.Text = "Nome Produto";
            lbl_Nome.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txt_Imagem
            // 
            txt_Imagem.Image = (Image)resources.GetObject("txt_Imagem.Image");
            txt_Imagem.Location = new Point(40, 14);
            txt_Imagem.Name = "txt_Imagem";
            txt_Imagem.Size = new Size(97, 97);
            txt_Imagem.SizeMode = PictureBoxSizeMode.Zoom;
            txt_Imagem.TabIndex = 0;
            txt_Imagem.TabStop = false;
            // 
            // ucProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "ucProduto";
            Size = new Size(188, 194);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)txt_Imagem).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox txt_Imagem;
        private Label lbl_Nome;
    }
}
