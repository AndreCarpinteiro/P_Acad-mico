namespace P_Académico.Cliente
{
    partial class NovoCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NovoCliente));
            label7 = new Label();
            txtEndereco = new TextBox();
            txtNIF = new TextBox();
            grpBox = new GroupBox();
            txtEmail = new TextBox();
            label6 = new Label();
            txtContacto = new TextBox();
            label5 = new Label();
            txtApelido = new TextBox();
            PickerDataNascimento = new DateTimePicker();
            txtNome = new TextBox();
            groupBox1 = new GroupBox();
            radioOutro = new RadioButton();
            radioFemea = new RadioButton();
            radioMacho = new RadioButton();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            inserirbtn = new Button();
            errpErro = new ErrorProvider(components);
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            grpBox.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errpErro).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(412, 344);
            label7.Name = "label7";
            label7.Size = new Size(85, 21);
            label7.TabIndex = 40;
            label7.Text = "Endereço";
            // 
            // txtEndereco
            // 
            txtEndereco.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtEndereco.Location = new Point(412, 368);
            txtEndereco.Name = "txtEndereco";
            txtEndereco.Size = new Size(212, 27);
            txtEndereco.TabIndex = 39;
            // 
            // txtNIF
            // 
            txtNIF.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNIF.Location = new Point(412, 294);
            txtNIF.Name = "txtNIF";
            txtNIF.Size = new Size(212, 27);
            txtNIF.TabIndex = 38;
            txtNIF.KeyPress += txtNIF_KeyPress;
            txtNIF.Leave += txtNIF_Leave;
            // 
            // grpBox
            // 
            grpBox.BackColor = Color.FromArgb(34, 36, 49);
            grpBox.Controls.Add(txtEmail);
            grpBox.Controls.Add(label6);
            grpBox.Controls.Add(txtContacto);
            grpBox.Controls.Add(label5);
            grpBox.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            grpBox.ForeColor = SystemColors.ButtonFace;
            grpBox.Location = new Point(412, 100);
            grpBox.Name = "grpBox";
            grpBox.Size = new Size(243, 154);
            grpBox.TabIndex = 37;
            grpBox.TabStop = false;
            grpBox.Text = "Contactos";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(23, 111);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(189, 27);
            txtEmail.TabIndex = 14;
            txtEmail.Leave += txtEmail_Leave;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(23, 87);
            label6.Name = "label6";
            label6.Size = new Size(51, 21);
            label6.TabIndex = 13;
            label6.Text = "Email";
            // 
            // txtContacto
            // 
            txtContacto.Location = new Point(23, 53);
            txtContacto.Name = "txtContacto";
            txtContacto.Size = new Size(189, 27);
            txtContacto.TabIndex = 12;
            txtContacto.KeyPress += txtContacto_KeyPress;
            txtContacto.Leave += txtContacto_Leave;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.ButtonFace;
            label5.Location = new Point(23, 29);
            label5.Name = "label5";
            label5.Size = new Size(171, 21);
            label5.TabIndex = 11;
            label5.Text = "Contacto Telefónico";
            // 
            // txtApelido
            // 
            txtApelido.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtApelido.Location = new Point(51, 215);
            txtApelido.Name = "txtApelido";
            txtApelido.Size = new Size(200, 27);
            txtApelido.TabIndex = 36;
            txtApelido.KeyPress += txtApelido_KeyPress;
            // 
            // PickerDataNascimento
            // 
            PickerDataNascimento.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PickerDataNascimento.Location = new Point(51, 294);
            PickerDataNascimento.Name = "PickerDataNascimento";
            PickerDataNascimento.Size = new Size(200, 27);
            PickerDataNascimento.TabIndex = 35;
            // 
            // txtNome
            // 
            txtNome.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNome.Location = new Point(51, 124);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(200, 27);
            txtNome.TabIndex = 34;
            txtNome.KeyPress += txtNome_KeyPress;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(34, 36, 49);
            groupBox1.Controls.Add(radioOutro);
            groupBox1.Controls.Add(radioFemea);
            groupBox1.Controls.Add(radioMacho);
            groupBox1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.ForeColor = SystemColors.ButtonFace;
            groupBox1.Location = new Point(51, 358);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(215, 109);
            groupBox1.TabIndex = 33;
            groupBox1.TabStop = false;
            groupBox1.Text = "Género";
            // 
            // radioOutro
            // 
            radioOutro.AutoSize = true;
            radioOutro.Location = new Point(15, 72);
            radioOutro.Name = "radioOutro";
            radioOutro.Size = new Size(74, 25);
            radioOutro.TabIndex = 2;
            radioOutro.TabStop = true;
            radioOutro.Text = "Outro";
            radioOutro.UseVisualStyleBackColor = true;
            // 
            // radioFemea
            // 
            radioFemea.AutoSize = true;
            radioFemea.Location = new Point(15, 47);
            radioFemea.Name = "radioFemea";
            radioFemea.Size = new Size(104, 25);
            radioFemea.TabIndex = 1;
            radioFemea.TabStop = true;
            radioFemea.Text = "Femenino";
            radioFemea.UseVisualStyleBackColor = true;
            // 
            // radioMacho
            // 
            radioMacho.AutoSize = true;
            radioMacho.Location = new Point(15, 22);
            radioMacho.Name = "radioMacho";
            radioMacho.Size = new Size(106, 25);
            radioMacho.TabIndex = 0;
            radioMacho.TabStop = true;
            radioMacho.Text = "Masculino";
            radioMacho.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(51, 270);
            label4.Name = "label4";
            label4.Size = new Size(149, 21);
            label4.TabIndex = 32;
            label4.Text = "Data Nascimento";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(51, 197);
            label3.Name = "label3";
            label3.Size = new Size(71, 21);
            label3.TabIndex = 31;
            label3.Text = "Apelido";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(412, 270);
            label2.Name = "label2";
            label2.Size = new Size(35, 21);
            label2.TabIndex = 30;
            label2.Text = "NIF";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(51, 100);
            label1.Name = "label1";
            label1.Size = new Size(57, 21);
            label1.TabIndex = 29;
            label1.Text = "Nome";
            // 
            // inserirbtn
            // 
            inserirbtn.BackColor = Color.FromArgb(34, 36, 49);
            inserirbtn.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            inserirbtn.ForeColor = SystemColors.ButtonFace;
            inserirbtn.Location = new Point(412, 413);
            inserirbtn.Name = "inserirbtn";
            inserirbtn.Size = new Size(212, 59);
            inserirbtn.TabIndex = 28;
            inserirbtn.Text = "Inserir";
            inserirbtn.UseVisualStyleBackColor = false;
            inserirbtn.Click += inserirbtn_Click;
            // 
            // errpErro
            // 
            errpErro.ContainerControl = this;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(34, 36, 49);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(695, 86);
            panel1.TabIndex = 41;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._27714061;
            pictureBox1.Location = new Point(51, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(83, 61);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(34, 36, 49);
            panel2.Location = new Point(0, 478);
            panel2.Name = "panel2";
            panel2.Size = new Size(695, 86);
            panel2.TabIndex = 42;
            // 
            // NovoCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCoral;
            ClientSize = new Size(693, 561);
            Controls.Add(grpBox);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label7);
            Controls.Add(txtEndereco);
            Controls.Add(txtNIF);
            Controls.Add(txtApelido);
            Controls.Add(PickerDataNascimento);
            Controls.Add(txtNome);
            Controls.Add(groupBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(inserirbtn);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "NovoCliente";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Criar Cliente";
            Load += NovoCliente_Load;
            grpBox.ResumeLayout(false);
            grpBox.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errpErro).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label7;
        private TextBox txtEndereco;
        private TextBox txtNIF;
        private GroupBox grpBox;
        private TextBox txtEmail;
        private Label label6;
        private TextBox txtContacto;
        private Label label5;
        private TextBox txtApelido;
        private DateTimePicker PickerDataNascimento;
        private TextBox txtNome;
        private GroupBox groupBox1;
        private RadioButton radioOutro;
        private RadioButton radioFemea;
        private RadioButton radioMacho;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button inserirbtn;
        private ErrorProvider errpErro;
        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
    }
}