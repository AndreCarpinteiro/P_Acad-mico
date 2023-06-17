namespace P_Académico.Pedido
{
    partial class MesaPopup
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
            btnOk = new Button();
            btnCancelar = new Button();
            cbMesa = new ComboBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnOk
            // 
            btnOk.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnOk.Location = new Point(22, 102);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(98, 32);
            btnOk.TabIndex = 1;
            btnOk.Text = "OK";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelar.Location = new Point(150, 102);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(93, 32);
            btnCancelar.TabIndex = 2;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // cbMesa
            // 
            cbMesa.FormattingEnabled = true;
            cbMesa.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" });
            cbMesa.Location = new Point(64, 48);
            cbMesa.Name = "cbMesa";
            cbMesa.Size = new Size(121, 23);
            cbMesa.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(34, 9);
            label1.Name = "label1";
            label1.Size = new Size(191, 21);
            label1.TabIndex = 4;
            label1.Text = "Escolha a mesa destino";
            // 
            // MesaPopup
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 36, 49);
            ClientSize = new Size(255, 146);
            Controls.Add(label1);
            Controls.Add(cbMesa);
            Controls.Add(btnCancelar);
            Controls.Add(btnOk);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "MesaPopup";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Mesa Pop-up";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnOk;
        private Button btnCancelar;
        private ComboBox cbMesa;
        private Label label1;
    }
}