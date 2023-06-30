namespace P_Académico.Cliente
{
    partial class ApagarEditarCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ApagarEditarCliente));
            dataGridView1 = new DataGridView();
            txtNIF = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtNome = new TextBox();
            label3 = new Label();
            txtApelido = new TextBox();
            label4 = new Label();
            txtEndereço = new TextBox();
            label5 = new Label();
            txtContacto = new TextBox();
            label6 = new Label();
            txtEmail = new TextBox();
            label7 = new Label();
            PickerNascimento = new DateTimePicker();
            btnUpdate = new Button();
            errpErro = new ErrorProvider(components);
            btnApagar = new Button();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errpErro).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 91);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(427, 439);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick_1;
            // 
            // txtNIF
            // 
            txtNIF.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNIF.Location = new Point(445, 139);
            txtNIF.Name = "txtNIF";
            txtNIF.Size = new Size(172, 27);
            txtNIF.TabIndex = 4;
            txtNIF.KeyPress += txtNIF_KeyPress;
            txtNIF.Leave += txtNIF_Leave;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(445, 114);
            label1.Name = "label1";
            label1.Size = new Size(35, 21);
            label1.TabIndex = 5;
            label1.Text = "NIF";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(445, 228);
            label2.Name = "label2";
            label2.Size = new Size(57, 21);
            label2.TabIndex = 7;
            label2.Text = "Nome";
            // 
            // txtNome
            // 
            txtNome.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNome.Location = new Point(445, 252);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(172, 27);
            txtNome.TabIndex = 6;
            txtNome.KeyPress += txtNome_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(445, 341);
            label3.Name = "label3";
            label3.Size = new Size(71, 21);
            label3.TabIndex = 9;
            label3.Text = "Apelido";
            // 
            // txtApelido
            // 
            txtApelido.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtApelido.Location = new Point(445, 365);
            txtApelido.Name = "txtApelido";
            txtApelido.Size = new Size(172, 27);
            txtApelido.TabIndex = 8;
            txtApelido.KeyPress += txtApelido_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(650, 114);
            label4.Name = "label4";
            label4.Size = new Size(85, 21);
            label4.TabIndex = 11;
            label4.Text = "Endereço";
            // 
            // txtEndereço
            // 
            txtEndereço.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtEndereço.Location = new Point(650, 139);
            txtEndereço.Name = "txtEndereço";
            txtEndereço.Size = new Size(172, 27);
            txtEndereço.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(651, 228);
            label5.Name = "label5";
            label5.Size = new Size(171, 21);
            label5.TabIndex = 13;
            label5.Text = "Contacto Telefónico";
            // 
            // txtContacto
            // 
            txtContacto.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtContacto.Location = new Point(650, 252);
            txtContacto.Name = "txtContacto";
            txtContacto.Size = new Size(172, 27);
            txtContacto.TabIndex = 12;
            txtContacto.KeyPress += txtContacto_KeyPress;
            txtContacto.Leave += txtContacto_Leave;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(650, 343);
            label6.Name = "label6";
            label6.Size = new Size(51, 21);
            label6.TabIndex = 15;
            label6.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.Location = new Point(650, 367);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(172, 27);
            txtEmail.TabIndex = 14;
            txtEmail.Leave += txtEmail_Leave;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(567, 415);
            label7.Name = "label7";
            label7.Size = new Size(149, 21);
            label7.TabIndex = 17;
            label7.Text = "Data Nascimento";
            // 
            // PickerNascimento
            // 
            PickerNascimento.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PickerNascimento.Location = new Point(531, 439);
            PickerNascimento.Name = "PickerNascimento";
            PickerNascimento.Size = new Size(228, 27);
            PickerNascimento.TabIndex = 18;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(34, 36, 49);
            btnUpdate.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnUpdate.ForeColor = SystemColors.ButtonFace;
            btnUpdate.Location = new Point(651, 490);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(171, 40);
            btnUpdate.TabIndex = 19;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // errpErro
            // 
            errpErro.ContainerControl = this;
            // 
            // btnApagar
            // 
            btnApagar.BackColor = Color.FromArgb(34, 36, 49);
            btnApagar.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnApagar.ForeColor = SystemColors.ButtonFace;
            btnApagar.Location = new Point(445, 490);
            btnApagar.Name = "btnApagar";
            btnApagar.Size = new Size(172, 40);
            btnApagar.TabIndex = 20;
            btnApagar.Text = "Apagar";
            btnApagar.UseVisualStyleBackColor = false;
            btnApagar.Click += btnApagar_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(34, 36, 49);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(-3, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(847, 86);
            panel1.TabIndex = 21;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._27714062;
            pictureBox1.Location = new Point(31, 13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(73, 57);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(34, 36, 49);
            panel2.Location = new Point(-3, 536);
            panel2.Name = "panel2";
            panel2.Size = new Size(847, 86);
            panel2.TabIndex = 22;
            // 
            // ApagarEditarCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCoral;
            ClientSize = new Size(834, 616);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(btnApagar);
            Controls.Add(btnUpdate);
            Controls.Add(PickerNascimento);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(txtEmail);
            Controls.Add(label5);
            Controls.Add(txtContacto);
            Controls.Add(label4);
            Controls.Add(txtEndereço);
            Controls.Add(label3);
            Controls.Add(txtApelido);
            Controls.Add(label2);
            Controls.Add(txtNome);
            Controls.Add(label1);
            Controls.Add(txtNIF);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ApagarEditarCliente";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Apagar | Editar Cliente";
            Load += ApagarEditarCliente_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errpErro).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox txtNIF;
        private Label label1;
        private Label label2;
        private TextBox txtNome;
        private Label label3;
        private TextBox txtApelido;
        private Label label4;
        private TextBox txtEndereço;
        private Label label5;
        private TextBox txtContacto;
        private Label label6;
        private TextBox txtEmail;
        private Label label7;
        private DateTimePicker PickerNascimento;
        private Button btnUpdate;
        private ErrorProvider errpErro;
        private Button btnApagar;
        private Panel panel2;
        private Panel panel1;
        private PictureBox pictureBox1;
    }
}