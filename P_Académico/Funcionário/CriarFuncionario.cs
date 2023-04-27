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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace P_Académico.Funcionário
{
    public partial class CriarFuncionario : Form
    {
        public CriarFuncionario()
        {
            InitializeComponent();
        }
        IFirebaseConfig fcon = new FirebaseConfig()
        {
            AuthSecret = "OTkUsFiqUxKAbUAqVZS2E5d8WL5G6DHYWSROKFbF",
            BasePath = "https://restaurante-b1d36-default-rtdb.firebaseio.com/"
        };
        IFirebaseClient client;

        private void inserirbtn_Click(object sender, EventArgs e)
        {
            if (Confirma() == true)
            {
                string genero = null;

                if (radioFemea.Checked == true)
                {
                    genero = "Femenino";
                }
                else if (radioMacho.Checked == true)
                {
                    genero = "Masculino";
                }
                else if (radioOutro.Checked == true)
                {
                    genero = "Outro";
                }

                ClasseFuncionario std = new ClasseFuncionario()
                {
                    Nome = txtNome.Text,
                    Endereco = txtEndereco.Text,
                    NIF = txtNIF.Text,
                    Apelido = txtApelido.Text,
                    DataNascimento = PickerNascimento.Text,
                    DataAdmissao = PickerAdmissao.Text,
                    Funcao = cbFuncao.Text,
                    ContactoTelefonico = txtContacto.Text,
                    Email = txtEmail.Text,
                    Genero = genero
                };
                var setter = client.Set("ListaFuncionarios/" + txtNIF.Text, std);
                MessageBox.Show("Introduzido com Sucesso");
                #region Limpar os campos                        
                PickerAdmissao.Value = new DateTime(1920, 10, 28);
                PickerNascimento.Value = new DateTime(1920, 10, 28);
                radioFemea.Checked = false;
                radioMacho.Checked = false;
                radioOutro.Checked = false;
                //função que limpa as textboxes
                LimparCaixas(Controls);
                return;
                #endregion
            }
        }

        private void CriarFuncionario_Load(object sender, EventArgs e)
        {
            cbFuncao.Items.Add("Cozinheiro");
            cbFuncao.Items.Add("Ajudante Cozinha");
            cbFuncao.Items.Add("Empregado de Mesa");
            cbFuncao.Items.Add("Empregado de Balcão");
            try
            {
                client = new FireSharp.FirebaseClient(fcon);
            }
            catch
            {
                MessageBox.Show("Probelma na conecção");
            }

            PickerNascimento.MaxDate = DateTime.Today;
            PickerAdmissao.MaxDate = DateTime.Today;
        }

        #region Funcões
        //funçao que limpa caixas de texto
        void LimparCaixas(Control.ControlCollection cont)
        {
            foreach (Control control in cont)
            {
                if (control is System.Windows.Forms.TextBox)
                {
                    ((System.Windows.Forms.TextBox)control).Clear();
                }
                else if (control is System.Windows.Forms.GroupBox)
                {
                    foreach (Control innerControl in control.Controls)
                    {
                        if (innerControl is System.Windows.Forms.TextBox)
                        {
                            ((System.Windows.Forms.TextBox)innerControl).Clear();
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
                if (txtb is System.Windows.Forms.TextBox)
                {
                    if (txtb.Text == string.Empty)
                    {
                        errpErro.SetError(txtb, "Preencha o campo");
                        cnt++;
                    }
                }

                //ver se o user escolheu um valor das comboboxes
                if (txtb is System.Windows.Forms.ComboBox)
                {
                    if (((System.Windows.Forms.ComboBox)txtb).SelectedIndex == -1)
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
                        if (tb is System.Windows.Forms.TextBox && tb is System.Windows.Forms.RadioButton)
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
