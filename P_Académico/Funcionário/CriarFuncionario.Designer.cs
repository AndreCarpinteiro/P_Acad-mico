namespace P_Académico.Funcionário
{
    partial class CriarFuncionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CriarFuncionario));
            label7 = new Label();
            txtEndereco = new TextBox();
            txtNIF = new TextBox();
            groupBox2 = new GroupBox();
            txtEmail = new TextBox();
            label6 = new Label();
            txtContacto = new TextBox();
            label5 = new Label();
            txtApelido = new TextBox();
            PickerNascimento = new DateTimePicker();
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
            label8 = new Label();
            PickerAdmissao = new DateTimePicker();
            label9 = new Label();
            errpErro = new ErrorProvider(components);
            cbFuncao = new ComboBox();
            panel1 = new Panel();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            groupBox2.SuspendLayout();
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
            label7.ForeColor = SystemColors.ActiveCaptionText;
            label7.Location = new Point(405, 299);
            label7.Name = "label7";
            label7.Size = new Size(85, 21);
            label7.TabIndex = 26;
            label7.Text = "Endereço";
            // 
            // txtEndereco
            // 
            txtEndereco.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtEndereco.Location = new Point(405, 320);
            txtEndereco.Name = "txtEndereco";
            txtEndereco.Size = new Size(226, 27);
            txtEndereco.TabIndex = 25;
            // 
            // txtNIF
            // 
            txtNIF.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNIF.Location = new Point(405, 261);
            txtNIF.Name = "txtNIF";
            txtNIF.Size = new Size(226, 27);
            txtNIF.TabIndex = 24;
            txtNIF.KeyPress += txtNIF_KeyPress;
            txtNIF.Leave += txtNIF_Leave;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.FromArgb(34, 36, 49);
            groupBox2.Controls.Add(txtEmail);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(txtContacto);
            groupBox2.Controls.Add(label5);
            groupBox2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.ForeColor = SystemColors.ButtonFace;
            groupBox2.Location = new Point(405, 92);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(226, 131);
            groupBox2.TabIndex = 23;
            groupBox2.TabStop = false;
            groupBox2.Text = "Contactos";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(23, 92);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(189, 27);
            txtEmail.TabIndex = 14;
            txtEmail.Leave += txtEmail_Leave;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(23, 74);
            label6.Name = "label6";
            label6.Size = new Size(51, 21);
            label6.TabIndex = 13;
            label6.Text = "Email";
            // 
            // txtContacto
            // 
            txtContacto.Location = new Point(23, 36);
            txtContacto.Name = "txtContacto";
            txtContacto.Size = new Size(189, 27);
            txtContacto.TabIndex = 12;
            txtContacto.KeyPress += txtContacto_KeyPress;
            txtContacto.Leave += txtContacto_Leave;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(23, 18);
            label5.Name = "label5";
            label5.Size = new Size(171, 21);
            label5.TabIndex = 11;
            label5.Text = "Contacto Telefónico";
            // 
            // txtApelido
            // 
            txtApelido.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtApelido.Location = new Point(47, 179);
            txtApelido.Name = "txtApelido";
            txtApelido.Size = new Size(216, 27);
            txtApelido.TabIndex = 22;
            txtApelido.KeyPress += txtApelido_KeyPress;
            // 
            // PickerNascimento
            // 
            PickerNascimento.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PickerNascimento.Location = new Point(45, 243);
            PickerNascimento.Name = "PickerNascimento";
            PickerNascimento.Size = new Size(218, 27);
            PickerNascimento.TabIndex = 21;
            // 
            // txtNome
            // 
            txtNome.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNome.Location = new Point(47, 115);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(216, 27);
            txtNome.TabIndex = 20;
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
            groupBox1.Location = new Point(45, 360);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(218, 103);
            groupBox1.TabIndex = 19;
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
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(44, 219);
            label4.Name = "label4";
            label4.Size = new Size(149, 21);
            label4.TabIndex = 18;
            label4.Text = "Data Nascimento";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(47, 156);
            label3.Name = "label3";
            label3.Size = new Size(71, 21);
            label3.TabIndex = 17;
            label3.Text = "Apelido";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(405, 237);
            label2.Name = "label2";
            label2.Size = new Size(35, 21);
            label2.TabIndex = 16;
            label2.Text = "NIF";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(44, 91);
            label1.Name = "label1";
            label1.Size = new Size(57, 21);
            label1.TabIndex = 15;
            label1.Text = "Nome";
            // 
            // inserirbtn
            // 
            inserirbtn.BackColor = Color.FromArgb(34, 36, 49);
            inserirbtn.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            inserirbtn.Location = new Point(405, 426);
            inserirbtn.Name = "inserirbtn";
            inserirbtn.Size = new Size(226, 37);
            inserirbtn.TabIndex = 14;
            inserirbtn.Text = "Inserir";
            inserirbtn.UseVisualStyleBackColor = false;
            inserirbtn.Click += inserirbtn_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.ActiveCaptionText;
            label8.Location = new Point(405, 360);
            label8.Name = "label8";
            label8.Size = new Size(69, 21);
            label8.TabIndex = 28;
            label8.Text = "Função";
            // 
            // PickerAdmissao
            // 
            PickerAdmissao.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PickerAdmissao.Location = new Point(45, 309);
            PickerAdmissao.Name = "PickerAdmissao";
            PickerAdmissao.Size = new Size(218, 27);
            PickerAdmissao.TabIndex = 30;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = SystemColors.ActiveCaptionText;
            label9.Location = new Point(45, 285);
            label9.Name = "label9";
            label9.Size = new Size(130, 21);
            label9.TabIndex = 29;
            label9.Text = "Data Admissão";
            // 
            // errpErro
            // 
            errpErro.ContainerControl = this;
            // 
            // cbFuncao
            // 
            cbFuncao.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbFuncao.FormattingEnabled = true;
            cbFuncao.Location = new Point(405, 381);
            cbFuncao.Name = "cbFuncao";
            cbFuncao.Size = new Size(226, 29);
            cbFuncao.TabIndex = 31;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(34, 36, 49);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(765, 86);
            panel1.TabIndex = 32;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(34, 36, 49);
            panel2.Location = new Point(0, 469);
            panel2.Name = "panel2";
            panel2.Size = new Size(765, 86);
            panel2.TabIndex = 33;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._27714064;
            pictureBox1.Location = new Point(44, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(74, 57);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // CriarFuncionario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCoral;
            ClientSize = new Size(763, 551);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(cbFuncao);
            Controls.Add(PickerAdmissao);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(txtEndereco);
            Controls.Add(txtNIF);
            Controls.Add(groupBox2);
            Controls.Add(txtApelido);
            Controls.Add(PickerNascimento);
            Controls.Add(txtNome);
            Controls.Add(groupBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(inserirbtn);
            ForeColor = SystemColors.ButtonFace;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "CriarFuncionario";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Criar Funcionário";
            Load += CriarFuncionario_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
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
        private GroupBox groupBox2;
        private TextBox txtEmail;
        private Label label6;
        private TextBox txtContacto;
        private Label label5;
        private TextBox txtApelido;
        private DateTimePicker PickerNascimento;
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
        private Label label8;
        private DateTimePicker PickerAdmissao;
        private Label label9;
        private ErrorProvider errpErro;
        private ComboBox cbFuncao;
        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
    }
}