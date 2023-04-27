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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errpErro).BeginInit();
            SuspendLayout();
            // 
            // btnApagar
            // 
            btnApagar.Location = new Point(487, 487);
            btnApagar.Name = "btnApagar";
            btnApagar.Size = new Size(116, 40);
            btnApagar.TabIndex = 37;
            btnApagar.Text = "Apagar";
            btnApagar.UseVisualStyleBackColor = true;
            btnApagar.Click += btnApagar_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(609, 487);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(116, 40);
            btnUpdate.TabIndex = 36;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // PickerNascimento
            // 
            PickerNascimento.Location = new Point(487, 435);
            PickerNascimento.Name = "PickerNascimento";
            PickerNascimento.Size = new Size(200, 23);
            PickerNascimento.TabIndex = 35;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(487, 417);
            label7.Name = "label7";
            label7.Size = new Size(98, 15);
            label7.TabIndex = 34;
            label7.Text = "Data Nascimento";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(487, 352);
            label6.Name = "label6";
            label6.Size = new Size(36, 15);
            label6.TabIndex = 33;
            label6.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(487, 369);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(172, 23);
            txtEmail.TabIndex = 32;
            txtEmail.Leave += txtEmail_Leave;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(487, 292);
            label5.Name = "label5";
            label5.Size = new Size(113, 15);
            label5.TabIndex = 31;
            label5.Text = "Contacto Telefónico";
            // 
            // txtContacto
            // 
            txtContacto.Location = new Point(487, 309);
            txtContacto.Name = "txtContacto";
            txtContacto.Size = new Size(172, 23);
            txtContacto.TabIndex = 30;
            txtContacto.KeyPress += txtContacto_KeyPress;
            txtContacto.Leave += txtContacto_Leave;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(487, 219);
            label4.Name = "label4";
            label4.Size = new Size(56, 15);
            label4.TabIndex = 29;
            label4.Text = "Endereço";
            // 
            // txtEndereço
            // 
            txtEndereço.Location = new Point(487, 236);
            txtEndereço.Name = "txtEndereço";
            txtEndereço.Size = new Size(172, 23);
            txtEndereço.TabIndex = 28;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(487, 151);
            label3.Name = "label3";
            label3.Size = new Size(48, 15);
            label3.TabIndex = 27;
            label3.Text = "Apelido";
            // 
            // txtApelido
            // 
            txtApelido.Location = new Point(487, 168);
            txtApelido.Name = "txtApelido";
            txtApelido.Size = new Size(172, 23);
            txtApelido.TabIndex = 26;
            txtApelido.KeyPress += txtApelido_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(487, 84);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 25;
            label2.Text = "Nome";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(487, 101);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(172, 23);
            txtNome.TabIndex = 24;
            txtNome.KeyPress += txtNome_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(487, 25);
            label1.Name = "label1";
            label1.Size = new Size(25, 15);
            label1.TabIndex = 23;
            label1.Text = "NIF";
            // 
            // txtNIF
            // 
            txtNIF.Location = new Point(487, 42);
            txtNIF.Name = "txtNIF";
            txtNIF.Size = new Size(172, 23);
            txtNIF.TabIndex = 22;
            txtNIF.KeyPress += txtNIF_KeyPress;
            txtNIF.Leave += txtNIF_Leave;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(46, 27);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(391, 430);
            dataGridView1.TabIndex = 21;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(693, 25);
            label8.Name = "label8";
            label8.Size = new Size(46, 15);
            label8.TabIndex = 39;
            label8.Text = "Função";
            // 
            // txtFuncao
            // 
            txtFuncao.Location = new Point(693, 42);
            txtFuncao.Name = "txtFuncao";
            txtFuncao.Size = new Size(172, 23);
            txtFuncao.TabIndex = 38;
            // 
            // errpErro
            // 
            errpErro.ContainerControl = this;
            // 
            // ApagarEditarFuncionario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1005, 553);
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
            Name = "ApagarEditarFuncionario";
            Text = "ApagarEditarFuncionario";
            Load += ApagarEditarFuncionario_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errpErro).EndInit();
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
    }
}