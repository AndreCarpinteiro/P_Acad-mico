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
            grpBox.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errpErro).BeginInit();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(425, 262);
            label7.Name = "label7";
            label7.Size = new Size(56, 15);
            label7.TabIndex = 40;
            label7.Text = "Endereço";
            // 
            // txtEndereco
            // 
            txtEndereco.Location = new Point(425, 283);
            txtEndereco.Name = "txtEndereco";
            txtEndereco.Size = new Size(176, 23);
            txtEndereco.TabIndex = 39;
            // 
            // txtNIF
            // 
            txtNIF.Location = new Point(425, 224);
            txtNIF.Name = "txtNIF";
            txtNIF.Size = new Size(176, 23);
            txtNIF.TabIndex = 38;
            txtNIF.KeyPress += txtNIF_KeyPress;
            txtNIF.Leave += txtNIF_Leave;
            // 
            // grpBox
            // 
            grpBox.Controls.Add(txtEmail);
            grpBox.Controls.Add(label6);
            grpBox.Controls.Add(txtContacto);
            grpBox.Controls.Add(label5);
            grpBox.Location = new Point(425, 54);
            grpBox.Name = "grpBox";
            grpBox.Size = new Size(200, 131);
            grpBox.TabIndex = 37;
            grpBox.TabStop = false;
            grpBox.Text = "Contactos";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(23, 92);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(153, 23);
            txtEmail.TabIndex = 14;
            txtEmail.Leave += txtEmail_Leave;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(23, 74);
            label6.Name = "label6";
            label6.Size = new Size(36, 15);
            label6.TabIndex = 13;
            label6.Text = "Email";
            // 
            // txtContacto
            // 
            txtContacto.Location = new Point(23, 36);
            txtContacto.Name = "txtContacto";
            txtContacto.Size = new Size(153, 23);
            txtContacto.TabIndex = 12;
            txtContacto.KeyPress += txtContacto_KeyPress;
            txtContacto.Leave += txtContacto_Leave;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(23, 18);
            label5.Name = "label5";
            label5.Size = new Size(113, 15);
            label5.TabIndex = 11;
            label5.Text = "Contacto Telefónico";
            // 
            // txtApelido
            // 
            txtApelido.Location = new Point(54, 137);
            txtApelido.Name = "txtApelido";
            txtApelido.Size = new Size(146, 23);
            txtApelido.TabIndex = 36;
            txtApelido.KeyPress += txtApelido_KeyPress;
            // 
            // PickerDataNascimento
            // 
            PickerDataNascimento.Location = new Point(52, 206);
            PickerDataNascimento.Name = "PickerDataNascimento";
            PickerDataNascimento.Size = new Size(200, 23);
            PickerDataNascimento.TabIndex = 35;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(52, 72);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(148, 23);
            txtNome.TabIndex = 34;
            txtNome.KeyPress += txtNome_KeyPress;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioOutro);
            groupBox1.Controls.Add(radioFemea);
            groupBox1.Controls.Add(radioMacho);
            groupBox1.Location = new Point(37, 282);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 103);
            groupBox1.TabIndex = 33;
            groupBox1.TabStop = false;
            groupBox1.Text = "Género";
            // 
            // radioOutro
            // 
            radioOutro.AutoSize = true;
            radioOutro.Location = new Point(15, 72);
            radioOutro.Name = "radioOutro";
            radioOutro.Size = new Size(56, 19);
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
            radioFemea.Size = new Size(78, 19);
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
            radioMacho.Size = new Size(80, 19);
            radioMacho.TabIndex = 0;
            radioMacho.TabStop = true;
            radioMacho.Text = "Masculino";
            radioMacho.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(52, 188);
            label4.Name = "label4";
            label4.Size = new Size(98, 15);
            label4.TabIndex = 32;
            label4.Text = "Data Nascimento";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(54, 119);
            label3.Name = "label3";
            label3.Size = new Size(48, 15);
            label3.TabIndex = 31;
            label3.Text = "Apelido";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(425, 206);
            label2.Name = "label2";
            label2.Size = new Size(25, 15);
            label2.TabIndex = 30;
            label2.Text = "NIF";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(52, 54);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 29;
            label1.Text = "Nome";
            // 
            // inserirbtn
            // 
            inserirbtn.Location = new Point(425, 362);
            inserirbtn.Name = "inserirbtn";
            inserirbtn.Size = new Size(150, 35);
            inserirbtn.TabIndex = 28;
            inserirbtn.Text = "Inserir";
            inserirbtn.UseVisualStyleBackColor = true;
            inserirbtn.Click += inserirbtn_Click;
            // 
            // errpErro
            // 
            errpErro.ContainerControl = this;
            // 
            // NovoCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(675, 452);
            Controls.Add(label7);
            Controls.Add(txtEndereco);
            Controls.Add(txtNIF);
            Controls.Add(grpBox);
            Controls.Add(txtApelido);
            Controls.Add(PickerDataNascimento);
            Controls.Add(txtNome);
            Controls.Add(groupBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(inserirbtn);
            Name = "NovoCliente";
            Text = "Criar Cliente";
            Load += NovoCliente_Load;
            grpBox.ResumeLayout(false);
            grpBox.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errpErro).EndInit();
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
    }
}