namespace P_Académico.Pedido
{
    partial class PedidoComReserva
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
            btn_carta = new Button();
            SuspendLayout();
            // 
            // btn_carta
            // 
            btn_carta.Location = new Point(361, 140);
            btn_carta.Name = "btn_carta";
            btn_carta.Size = new Size(132, 47);
            btn_carta.TabIndex = 0;
            btn_carta.Text = "Carta";
            btn_carta.UseVisualStyleBackColor = true;
            btn_carta.Click += btn_carta_Click;
            // 
            // PedidoComReserva
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_carta);
            Name = "PedidoComReserva";
            Text = "PedidoComReserva";
            ResumeLayout(false);
        }

        #endregion

        private Button btn_carta;
    }
}