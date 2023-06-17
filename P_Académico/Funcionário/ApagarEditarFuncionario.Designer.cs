namespace P_Académico.Funcionário
{
    partial class ApagarEditarFuncionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ApagarEditarFuncionario));
            btnApagar = new Button();
            btnUpdate = new Button();
            PickerNascimento = new DateTimePicker();
            label7 = new Label();
            label6 = new Label();
            txtEmail = new TextBox();
            label5 = new Label();
            txtContacto = new TextBox();
            label4 = new Label();
            txtEndereço = new TextBox();
            label3 = new Label();
            txtApelido = new TextBox();
            label2 = new Label();
            txtNome = new TextBox();
            label1 = new Label();
            txtNIF = new TextBox();
            dataGridView1 = new DataGridView();
            label8 = new Label();
            txtFuncao = new TextBox();
            errpErro = new ErrorProvider(components);
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errpErro).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnApagar
            // 
            btnApagar.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnApagar.Location = new Point(454, 487);
            btnApagar.Name = "btnApagar";
            btnApagar.Size = new Size(116, 40);
            btnApagar.TabIndex = 37;
            btnApagar.Text = "Apagar";
            btnApagar.UseVisualStyleBackColor = true;
            btnApagar.Click += btnApagar_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnUpdate.Location = new Point(755, 487);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(116, 40);
            btnUpdate.TabIndex = 36;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // PickerNascimento
            // 
            PickerNascimento.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PickerNascimento.Location = new Point(454, 393);
            PickerNascimento.Name = "PickerNascimento";
            PickerNascimento.Size = new Size(200, 27);
            PickerNascimento.TabIndex = 35;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(454, 353);
            label7.Name = "label7";
            label7.Size = new Size(149, 21);
            label7.TabIndex = 34;
            label7.Text = "Data Nascimento";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(700, 369);
            label6.Name = "label6";
            label6.Size = new Size(51, 21);
            label6.TabIndex = 33;
            label6.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.Location = new Point(700, 393);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(172, 27);
            txtEmail.TabIndex = 32;
            txtEmail.Leave += txtEmail_Leave;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(700, 260);
            label5.Name = "label5";
            label5.Size = new Size(171, 21);
            label5.TabIndex = 31;
            label5.Text = "Contacto Telefónico";
            // 
            // txtContacto
            // 
            txtContacto.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtContacto.Location = new Point(700, 284);
            txtContacto.Name = "txtContacto";
            txtContacto.Size = new Size(172, 27);
            txtContacto.TabIndex = 30;
            txtContacto.KeyPress += txtContacto_KeyPress;
            txtContacto.Leave += txtContacto_Leave;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(454, 255);
            label4.Name = "label4";
            label4.Size = new Size(85, 21);
            label4.TabIndex = 29;
            label4.Text = "Endereço";
            // 
            // txtEndereço
            // 
            txtEndereço.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtEndereço.Location = new Point(454, 279);
            txtEndereço.Name = "txtEndereço";
            txtEndereço.Size = new Size(172, 27);
            txtEndereço.TabIndex = 28;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(454, 187);
            label3.Name = "label3";
            label3.Size = new Size(71, 21);
            label3.TabIndex = 27;
            label3.Text = "Apelido";
            // 
            // txtApelido
            // 
            txtApelido.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtApelido.Location = new Point(454, 211);
            txtApelido.Name = "txtApelido";
            txtApelido.Size = new Size(172, 27);
            txtApelido.TabIndex = 26;
            txtApelido.KeyPress += txtApelido_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.LightCoral;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(454, 120);
            label2.Name = "label2";
            label2.Size = new Size(57, 21);
            label2.TabIndex = 25;
            label2.Text = "Nome";
            // 
            // txtNome
            // 
            txtNome.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNome.Location = new Point(454, 144);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(172, 27);
            txtNome.TabIndex = 24;
            txtNome.KeyPress += txtNome_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(700, 193);
            label1.Name = "label1";
            label1.Size = new Size(35, 21);
            label1.TabIndex = 23;
            label1.Text = "NIF";
            // 
            // txtNIF
            // 
            txtNIF.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNIF.Location = new Point(700, 216);
            txtNIF.Name = "txtNIF";
            txtNIF.Size = new Size(172, 27);
            txtNIF.TabIndex = 22;
            txtNIF.KeyPress += txtNIF_KeyPress;
            txtNIF.Leave += txtNIF_Leave;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(24, 112);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(391, 430);
            dataGridView1.TabIndex = 21;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(700, 120);
            label8.Name = "label8";
            label8.Size = new Size(69, 21);
            label8.TabIndex = 39;
            label8.Text = "Função";
            // 
            // txtFuncao
            // 
            txtFuncao.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtFuncao.Location = new Point(700, 144);
            txtFuncao.Name = "txtFuncao";
            txtFuncao.Size = new Size(172, 27);
            txtFuncao.TabIndex = 38;
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
            panel1.Size = new Size(971, 86);
            panel1.TabIndex = 40;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._27714063;
            pictureBox1.Location = new Point(24, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(74, 66);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(34, 36, 49);
            panel2.Location = new Point(0, 564);
            panel2.Name = "panel2";
            panel2.Size = new Size(971, 86);
            panel2.TabIndex = 41;
            // 
            // ApagarEditarFuncionario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCoral;
            ClientSize = new Size(923, 650);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label8);
            Controls.Add(txtFuncao);
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
            Name = "ApagarEditarFuncionario";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Apagar | Editar Funcionario";
            Load += ApagarEditarFuncionario_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errpErro).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnApagar;
        private Button btnUpdate;
        private DateTimePicker PickerNascimento;
        private Label label7;
        private Label label6;
        private TextBox txtEmail;
        private Label label5;
        private TextBox txtContacto;
        private Label label4;
        private TextBox txtEndereço;
        private Label label3;
        private TextBox txtApelido;
        private Label label2;
        private TextBox txtNome;
        private Label label1;
        private TextBox txtNIF;
        private DataGridView dataGridView1;
        private Label label8;
        private TextBox txtFuncao;
        private ErrorProvider errpErro;
        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
    }
}