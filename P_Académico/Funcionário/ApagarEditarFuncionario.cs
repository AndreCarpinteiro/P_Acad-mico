using FireSharp;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P_Académico.Funcionário
{
    public partial class ApagarEditarFuncionario : Form
    {
        public ApagarEditarFuncionario()
        {
            InitializeComponent();
        }
        ClasseFuncionario funcionario = new ClasseFuncionario();

        IFirebaseConfig fcon = new FirebaseConfig()
        {
            AuthSecret = "OTkUsFiqUxKAbUAqVZS2E5d8WL5G6DHYWSROKFbF",
            BasePath = "https://restaurante-b1d36-default-rtdb.firebaseio.com/"
        };
        IFirebaseClient client;

        private void btnApagar_Click(object sender, EventArgs e)
        {
            FirebaseResponse response = client.Delete("ListaFuncionarios/" + txtNIF.Text);
            MessageBox.Show("Apagado com sucesso");
            txtNIF.Text = string.Empty;
            txtEndereço.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtContacto.Text = string.Empty;
            txtNome.Text = string.Empty;
            txtApelido.Text = string.Empty;
            PickerNascimento.Text = string.Empty;
            txtFuncao.Text = string.Empty;
            AtualizaDataGrid();
        }

        private void ApagarEditarFuncionario_Load(object sender, EventArgs e)
        {
            try
            {
                client = new FirebaseClient(fcon);
            }
            catch
            {
                MessageBox.Show("Problema na conecção");
            }

            AtualizaDataGrid();
        }

        public async void AtualizaDataGrid()
        {
            FirebaseResponse res = await client.GetAsync(@"ListaFuncionarios");
            string json = res.Body.ToString();
            if (!String.IsNullOrEmpty(json))
            {
                Dictionary<string, ClasseFuncionario> data = JsonConvert.DeserializeObject<Dictionary<string, ClasseFuncionario>>(res.Body.ToString());
                if (data != null && data.Count > 0)
                {
                    PreencherDataGrid(data);
                }
            }
        }

        void PreencherDataGrid(Dictionary<string, ClasseFuncionario> record)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

            dataGridView1.Columns.Add("NIF", "NIF");
            dataGridView1.Columns.Add("Nome", "Nome");
            dataGridView1.Columns.Add("Apelido", "Apelido");
            dataGridView1.Columns.Add("Funcao", "Funcao");

            foreach (var item in record)
            {
                dataGridView1.Rows.Add(item.Key, item.Value.Nome, item.Value.Apelido, item.Value.Funcao);
                funcionario.ListaDeFuncionarios.Add(record[item.Key]);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                // Obter a linha selecionada
                DataGridViewRow linhaSelecionada = dataGridView1.CurrentRow;

                // Obter o valor da célula na primeira coluna da linha selecionada
                string valorCelula = linhaSelecionada.Cells[0].Value.ToString();

                txtNIF.Text = valorCelula;
                int count = 0;
                foreach (ClasseFuncionario item in funcionario.ListaDeFuncionarios)
                {
                    if (valorCelula == funcionario.ListaDeFuncionarios[count].NIF)
                    {
                        txtApelido.Text = funcionario.ListaDeFuncionarios[count].Apelido;
                        txtNome.Text = funcionario.ListaDeFuncionarios[count].Nome;
                        txtEndereço.Text = funcionario.ListaDeFuncionarios[count].Endereco;
                        txtEmail.Text = funcionario.ListaDeFuncionarios[count].Email;
                        txtContacto.Text = funcionario.ListaDeFuncionarios[count].ContactoTelefonico;
                        PickerNascimento.Text = funcionario.ListaDeFuncionarios[count].DataNascimento;
                        txtFuncao.Text = funcionario.ListaDeFuncionarios[count].Funcao;
                    }
                    count++;
                }

            }
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            var cli = new ClasseFuncionario
            {
                NIF = txtNIF.Text,
                Endereco = txtEndereço.Text,
                Apelido = txtApelido.Text,
                Nome = txtNome.Text,
                ContactoTelefonico = txtContacto.Text,
                Email = txtEmail.Text,
                DataNascimento = PickerNascimento.Text,
                Funcao = txtFuncao.Text
            };

            if (Confirma() == true)
            {
                FirebaseResponse resp = await client.UpdateAsync("ListaFuncionarios/" + txtNIF.Text, cli);
                txtNIF.Text = string.Empty;
                txtEndereço.Text = string.Empty;
                txtEmail.Text = string.Empty;
                txtContacto.Text = string.Empty;
                txtNome.Text = string.Empty;
                txtApelido.Text = string.Empty;
                PickerNascimento.Text = string.Empty;
                txtFuncao.Text = string.Empty;

                AtualizaDataGrid();
                MessageBox.Show("Atualizado com sucesso");
            }
            else
            {
                MessageBox.Show("Erro");
            }
        }

        #region Confirma campos
        //Ver se o user preencheu todos os campos do form
        private bool Confirma()
        {
            errpErro.Dispose();
            int cnt = 0;
            foreach (Control txtb in this.Controls)
            {
                //ver se o user escreveu n
                if (txtb is TextBox)
                {
                    if (txtb.Text == string.Empty)
                    {
                        errpErro.SetError(txtb, "Preencha o campo");
                        cnt++;
                    }
                }

                //ver se o user escolheu um valor das comboboxes
                if (txtb is ComboBox)
                {
                    if (((ComboBox)txtb).SelectedIndex == -1)
                    {
                        errpErro.SetError(txtb, "Escolha um valor");
                        cnt++;
                    }
                }

                //ver se o user preenhceu os campos dentro das groupboxes
                if (txtb is System.Windows.Forms.GroupBox)
                {
                    foreach (Control tb in txtb.Controls)
                    {
                        if (tb is TextBox && tb is System.Windows.Forms.RadioButton)
                        {
                            errpErro.SetError(txtb, "Preencha os campos");
                        }
                    }
                }
            }
            if (cnt == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion

        #region Regexs
        private void txtNIF_Leave(object sender, EventArgs e)
        {
            //regex para um número de 9 dígitos
            Regex padrao = new Regex(@"^[0-9]{9}$");
            if (padrao.IsMatch(txtNIF.Text))
            {
                return;
            }
            else
            {
                MessageBox.Show("NIF inserido Inválido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNIF.Clear();
                txtNIF.Focus();
            }
        }

        private void txtContacto_Leave(object sender, EventArgs e)
        {
            Regex padrao = new Regex(@"^([9]{1})+(6|3|2|1{1})+([0-9]{7})$");
            //regex para numeros de telefone em Portugal, para as 3 maiores operadoras (Meo, NOS, Vodafone)
            if (padrao.IsMatch(txtContacto.Text))
            {
                return;
            }
            else
            {
                MessageBox.Show("Contacto Telefónico Inválido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtContacto.Clear();
                txtContacto.Focus();
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            Regex padrao = new Regex(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
            //regex para o email ser válido
            if (padrao.IsMatch(txtEmail.Text))
            {
                return;
            }
            else
            {
                MessageBox.Show("E-mail inserido Inválido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Clear();
                txtEmail.Focus();
            }
        }
        #endregion

        void CtrlInputNumeros(KeyPressEventArgs e) //funcao nao aceita numeros e os caracteres definidos na string
        {
            string chars = "\".,_><+*!#$%&/()=?»«'][{}\\";

            if ((Char.IsDigit(e.KeyChar) || chars.IndexOf(e.KeyChar) != -1) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            CtrlInputNumeros(e);
        }

        private void txtApelido_KeyPress(object sender, KeyPressEventArgs e)
        {
            CtrlInputNumeros(e);
        }

        void CtrlInputLetras(KeyPressEventArgs e) //funcao nao aceita numeros e os caracteres definidos na string
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtContacto_KeyPress(object sender, KeyPressEventArgs e)
        {
            CtrlInputLetras(e);
        }

        private void txtNIF_KeyPress(object sender, KeyPressEventArgs e)
        {
            CtrlInputLetras(e);
        }
    }
}
