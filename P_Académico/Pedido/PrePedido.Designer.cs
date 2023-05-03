namespace P_Académico.Pedido
{
    partial class PrePedido
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
            btn_ComReserva = new Button();
            btn_SemReserva = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btn_ComReserva
            // 
            btn_ComReserva.Location = new Point(12, 66);
            btn_ComReserva.Name = "btn_ComReserva";
            btn_ComReserva.Size = new Size(172, 63);
            btn_ComReserva.TabIndex = 0;
            btn_ComReserva.Text = "Cliente com reserva";
            btn_ComReserva.UseVisualStyleBackColor = true;
            btn_ComReserva.Click += btn_ComReserva_Click;
            // 
            // btn_SemReserva
            // 
            btn_SemReserva.Location = new Point(203, 66);
            btn_SemReserva.Name = "btn_SemReserva";
            btn_SemReserva.Size = new Size(172, 63);
            btn_SemReserva.TabIndex = 1;
            btn_SemReserva.Text = "Sem reserva";
            btn_SemReserva.UseVisualStyleBackColor = true;
            btn_SemReserva.Click += btn_SemReserva_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(68, 22);
            label1.Name = "label1";
            label1.Size = new Size(271, 30);
            label1.TabIndex = 2;
            label1.Text = "Vamos criar o pedido";
            // 
            // PrePedido
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(387, 153);
            Controls.Add(label1);
            Controls.Add(btn_SemReserva);
            Controls.Add(btn_ComReserva);
            Name = "PrePedido";
            Text = "CriarPedido";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_ComReserva;
        private Button btn_SemReserva;
        private Label label1;
    }
}