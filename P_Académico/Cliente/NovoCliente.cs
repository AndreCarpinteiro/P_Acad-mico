using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using System.Data;
using System.Diagnostics.Metrics;
using System.Runtime.CompilerServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using System.Text.RegularExpressions;
using FirebaseAdmin.Auth;

namespace P_Académico.Cliente
{
    public partial class NovoCliente : Form
    {
        public NovoCliente()
        {
            InitializeComponent();
        }

        IFirebaseConfig fcon = new FirebaseConfig()
        {
            AuthSecret = "OTkUsFiqUxKAbUAqVZS2E5d8WL5G6DHYWSROKFbF",
            BasePath = "https://restaurante-b1d36-default-rtdb.firebaseio.com/"
        };
        IFirebaseClient client;

        private async void inserirbtn_Click(object sender, EventArgs e)
        {


            if (Confirma())
            {
                string genero = null;

                if (radioFemea.Checked)
                {
                    genero = "Feminino";
                }
                else if (radioMacho.Checked)
                {
                    genero = "Masculino";
                }
                else if (radioOutro.Checked)
                {
                    genero = "Outro";
                }

                // Cria um novo utilizador no Firebase Authentication
                /*var user = await FirebaseAuth.DefaultInstance.CreateUserAsync(new UserRecordArgs()
                {
                    Email = txtEmail.Text,
                    Password = "123456",
                    EmailVerified = true
                });*/

                ClasseCliente std = new ClasseCliente()
                {
                    Nome = txtNome.Text,
                    Endereco = txtEndereco.Text,
                    NIF = txtNIF.Text,
                    Apelido = txtApelido.Text,
                    DataNascimento = PickerDataNascimento.Text,
                    ContactoTelefonico = txtContacto.Text,
                    Email = txtEmail.Text,
                    Genero = genero,
                    Id = string.Empty // Inicialize como vazio, será preenchido posteriormente
                };

                // Conecte-se ao Firebase usando a configuração
                client = new FireSharp.FirebaseClient(fcon);

                // Insira o cliente na coleção "ListaClientes" usando o método Push()
                var response = await client.PushAsync("ListaClientes/", std);

                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    // Obtenha o ID do cliente do objeto FirebaseResponse
                    string idCliente = response.Result.name;

                    // Atualize o objeto std com o ID do cliente
                    std.Id = idCliente;

                    // Atualize o registro do cliente com o ID usando o método Set()
                    var updateResponse = await client.SetAsync($"ListaClientes/{idCliente}", std);

                    if (updateResponse.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        MessageBox.Show("Introduzido com Sucesso");
                        LimparCaixas(Controls);
                    }
                    else
                    {
                        MessageBox.Show("Ocorreu um erro ao inserir o cliente");
                    }
                }
                else
                {
                    MessageBox.Show("Ocorreu um erro ao inserir o cliente");
                }
            }
        }

        private void NovoCliente_Load(object sender, EventArgs e)
        {
            try
            {
                client = new FireSharp.FirebaseClient(fcon);
            }
            catch
            {
                MessageBox.Show("Probelma na conecção");
            }

            PickerDataNascimento.MaxDate = DateTime.Today;
        }

        #region Funcões
        //funçao que limpa caixas de texto
        void LimparCaixas(Control.ControlCollection cont)
        {
            foreach (Control control in cont)
            {
                if (control is TextBox)
                {
                    ((TextBox)control).Clear();
                }
                else if (control is System.Windows.Forms.GroupBox)
                {
                    foreach (Control innerControl in control.Controls)
                    {
                        if (innerControl is TextBox)
                        {
                            ((TextBox)innerControl).Clear();
                        }
                    }
                }
            }
        }
        #endregion

        #region Regexs
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
        #endregion

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


        #region Validações
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
        #endregion
    }
}