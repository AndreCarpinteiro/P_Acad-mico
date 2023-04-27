using FireSharp;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using Newtonsoft.Json;
using P_Académico.Cliente;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P_Académico.Reserva
{
    public partial class Reservas : Form
    {
        List<ClasseCliente> clientes = new List<ClasseCliente>();
        List<ClasseReserva> reservas = new List<ClasseReserva>();
        List<ClasseMesa> mesas = new List<ClasseMesa>();

        //criar uma lista de mesas reservadas para a data selecionada
        List<string> mesasReservadas = new List<string>();

        //criar uma lista de mesas disponíveis, ou seja, todas as mesas que não estão na lista de mesas reservadas
        List<ClasseMesa> mesasDisponiveis = new List<ClasseMesa>();

        int validaRserva = 0;
        int mesaID = -1;
        DateTime dataEscolhida;
        ArrayList datasReservadas = new ArrayList();

        public Reservas()
        {
            InitializeComponent();
        }

        IFirebaseConfig fcon = new FirebaseConfig()
        {
            AuthSecret = "OTkUsFiqUxKAbUAqVZS2E5d8WL5G6DHYWSROKFbF",
            BasePath = "https://restaurante-b1d36-default-rtdb.firebaseio.com/"
        };

        IFirebaseClient client;
        //Converter o formato da data para ser aceite no SQL
        string selectDateAsString;

        private async void Reservas_Load(object sender, EventArgs e)
        {
            DP_Reserva.MinDate = DateTime.Now; //Apenas permite reservas para o futuro
            try
            {
                client = new FirebaseClient(fcon);
            }
            catch
            {
                MessageBox.Show("Problema na conecção");
            }

            FirebaseResponse response = await client.GetAsync("ListaClientes");
            string json = response.Body.ToString();
            Dictionary<string, ClasseCliente> data = JsonConvert.DeserializeObject<Dictionary<string, ClasseCliente>>(json);
            clientes = data.Values.ToList();

            FirebaseResponse response2 = await client.GetAsync("Mesas");
            string json2 = response2.Body.ToString();
            List<ClasseMesa> data2 = JsonConvert.DeserializeObject<List<ClasseMesa>>(json2);
            mesas = data2;

            foreach (ClasseCliente cliente in clientes)
            {
                Lb_ClientesNif.Items.Add(cliente.Nome + " " + cliente.Apelido + "  " + cliente.NIF);
            }
        }

        private void Lb_ClientesNif_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Lb_ClientesNif.SelectedItem != null)
            {
                if (Lb_ClientesNif.SelectedIndex != -1) // Verificar se algo está selecionado
                {
                    string selectedText = Lb_ClientesNif.SelectedItem.ToString(); // obter o texto selecionado
                    string[] parts = selectedText.Split(); // dividir a string em partes
                    string nif;
                    if (parts.Length > 0) // verificar se há elementos na matri
                    {
                        nif = parts[parts.Length - 1]; // obter o último valor

                        // Pesquisar o objeto ClasseCliente correspondente na lista de clientes
                        ClasseCliente clienteSelecionado = clientes.Find(c => c.NIF == nif);

                        // Verificar se o objeto foi encontrado antes de atualizar os campos de texto
                        if (clienteSelecionado != null)
                        {
                            txtNIF.Text = clienteSelecionado.NIF;
                            txtApelido.Text = clienteSelecionado.Apelido;
                            txtNome.Text = clienteSelecionado.Nome;
                            txtContacto.Text = clienteSelecionado.ContactoTelefonico;
                        }
                        else
                        {
                            MessageBox.Show("O objeto ClasseCliente correspondente não foi encontrado na lista!");
                        }
                    }
                }
            }
        }

        private async void btn_12_Click(object sender, EventArgs e)
        {
            hora_selecionada.Clear();
            hora_selecionada.Text = "12:00";

            selectDateAsString = DP_Reserva.Value.ToString("yyyy-MM-dd");
            //Adicionar a hora escolhida a data
            selectDateAsString += "/12:00:00";

            //Parte a data e adiciona ahora do botão para comparar com a hora do sistema
            DateTime date1 = new DateTime(DP_Reserva.Value.Year, DP_Reserva.Value.Month, DP_Reserva.Value.Day, 12, 0, 0);
            DateTime date2;
            date2 = DateTime.Now;
            dataEscolhida = date1;

            // Compara as datas
            int result = DateTime.Compare(date1, date2);

            if (result < 0)
            {
                btn_12.BackColor = Color.Red;
                validaRserva = 0;
                lb_Mesas.Items.Clear();
            }
            else
            {
                ConteudoBotoes(12);

                btn_12.BackColor = Color.Green;
                validaRserva = 1;
            }
        }

        private void lb_Mesas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lb_Mesas.SelectedItem != null)
            {
                string pattern = @"Mesa:\s*(\d+)";
                Match match = Regex.Match(lb_Mesas.SelectedItem.ToString(), pattern);
                if (match.Success && int.TryParse(match.Groups[1].Value, out int result))
                {
                    mesaID = result;
                    txt_Mesa.Text = mesaID.ToString();
                }

                txt_Mesa.Text = mesaID.ToString();
            }
        }

        private async void btnReservar_Click(object sender, EventArgs e)
        {
            int reservaID;


            var reserva = new ClasseReserva()
            {
                Nome = txtNome.Text,
                NIF = txtNIF.Text,
                Apelido = txtApelido.Text,
                DataReserva = dataEscolhida.ToString(),
                ContactoTelefonico = txtContacto.Text,
                MesaID = mesaID
            };

            // adicionar a mesa à lista de mesas reservadas
            mesasReservadas.Add(mesaID.ToString());

            // atualizar a list box de mesas
            lb_Mesas.Items.Clear();
            foreach (ClasseMesa mesa in mesas)
            {
                if (!mesasReservadas.Contains(mesa.MesaID.ToString()))
                {
                    lb_Mesas.Items.Add("Mesa: " + mesa.MesaID + "  Capacidade: " + mesa.Capacidade);
                }
            }

            // Envia a nova reserva para o Firebase e aguarda a resposta assíncrona
            var response = await client.PushAsync("Reservas", reserva);

            // Verifica se a operação foi bem-sucedida e obtem a chave da nova reserva
            if (response.StatusCode == System.Net.HttpStatusCode.OK && validaRserva == 1)
            {
                var key = response.Result.name;
                MessageBox.Show($"Nova reserva criada com sucesso! ID: {key}");
            }
            else
            {
                MessageBox.Show("Falha ao criar nova reserva!");
            }
        }

        private async void btn_13_Click(object sender, EventArgs e)
        {
            hora_selecionada.Clear();
            hora_selecionada.Text = "13:00";

            selectDateAsString = DP_Reserva.Value.ToString("yyyy-MM-dd");
            //Adicionar a hora escolhida a data
            selectDateAsString += "/13:00:00";

            //Parte a data e adiciona ahora do botão para comparar com a hora do sistema
            DateTime date1 = new DateTime(DP_Reserva.Value.Year, DP_Reserva.Value.Month, DP_Reserva.Value.Day, 13, 0, 0);
            DateTime date2;
            date2 = DateTime.Now;
            dataEscolhida = date1;

            // Compara as datas
            int result = DateTime.Compare(date1, date2);

            if (result < 0)
            {
                btn_13.BackColor = Color.Red;
                validaRserva = 0;
                lb_Mesas.Items.Clear();
            }
            else
            {
                ConteudoBotoes(13);

                btn_13.BackColor = Color.Green;
                validaRserva = 1;
            }
        }

        private async void btn_14_Click(object sender, EventArgs e)
        {
            hora_selecionada.Clear();
            hora_selecionada.Text = "14:00";

            selectDateAsString = DP_Reserva.Value.ToString("yyyy-MM-dd");
            //Adicionar a hora escolhida a data
            selectDateAsString += "/14:00:00";

            //Parte a data e adiciona ahora do botão para comparar com a hora do sistema
            DateTime date1 = new DateTime(DP_Reserva.Value.Year, DP_Reserva.Value.Month, DP_Reserva.Value.Day, 14, 0, 0);
            DateTime date2;
            date2 = DateTime.Now;
            dataEscolhida = date1;

            // Compara as datas
            int result = DateTime.Compare(date1, date2);

            if (result < 0)
            {
                btn_14.BackColor = Color.Red;
                validaRserva = 0;
                lb_Mesas.Items.Clear();
            }
            else
            {
                ConteudoBotoes(14);

                btn_14.BackColor = Color.Green;
                validaRserva = 1;
            }
        }

        private async void btn_15_Click(object sender, EventArgs e)
        {
            hora_selecionada.Clear();
            hora_selecionada.Text = "15:00";

            selectDateAsString = DP_Reserva.Value.ToString("yyyy-MM-dd");
            //Adicionar a hora escolhida a data
            selectDateAsString += "/15:00:00";

            //Parte a data e adiciona ahora do botão para comparar com a hora do sistema
            DateTime date1 = new DateTime(DP_Reserva.Value.Year, DP_Reserva.Value.Month, DP_Reserva.Value.Day, 15, 0, 0);
            DateTime date2;
            date2 = DateTime.Now;
            dataEscolhida = date1;

            // Compara as datas
            int result = DateTime.Compare(date1, date2);

            if (result < 0)
            {
                btn_15.BackColor = Color.Red;
                validaRserva = 0;
                lb_Mesas.Items.Clear();
            }
            else
            {
                ConteudoBotoes(15);

                btn_15.BackColor = Color.Green;
                validaRserva = 1;
            }
        }

        private async void btn_19_Click(object sender, EventArgs e)
        {
            hora_selecionada.Clear();
            hora_selecionada.Text = "19:00";

            selectDateAsString = DP_Reserva.Value.ToString("yyyy-MM-dd");
            //Adicionar a hora escolhida a data
            selectDateAsString += "/19:00:00";

            //Parte a data e adiciona ahora do botão para comparar com a hora do sistema
            DateTime date1 = new DateTime(DP_Reserva.Value.Year, DP_Reserva.Value.Month, DP_Reserva.Value.Day, 19, 0, 0);
            DateTime date2;
            date2 = DateTime.Now;
            dataEscolhida = date1;

            // Compara as datas
            int result = DateTime.Compare(date1, date2);

            if (result < 0)
            {
                btn_19.BackColor = Color.Red;
                validaRserva = 0;
                lb_Mesas.Items.Clear();
            }
            else
            {

                ConteudoBotoes(19);

                btn_19.BackColor = Color.Green;
                validaRserva = 1;
            }
        }

        private async void btn_20_Click(object sender, EventArgs e)
        {
            hora_selecionada.Clear();
            hora_selecionada.Text = "20:00";

            selectDateAsString = DP_Reserva.Value.ToString("yyyy-MM-dd");
            //Adicionar a hora escolhida a data
            selectDateAsString += "/20:00:00";

            //Parte a data e adiciona ahora do botão para comparar com a hora do sistema
            DateTime date1 = new DateTime(DP_Reserva.Value.Year, DP_Reserva.Value.Month, DP_Reserva.Value.Day, 20, 0, 0);
            DateTime date2;
            date2 = DateTime.Now;
            dataEscolhida = date1;

            // Compara as datas
            int result = DateTime.Compare(date1, date2);

            if (result < 0)
            {
                btn_20.BackColor = Color.Red;
                validaRserva = 0;
                lb_Mesas.Items.Clear();
            }
            else
            {

                ConteudoBotoes(20);

                btn_20.BackColor = Color.Green;
                validaRserva = 1;
            }
        }

        private async void btn_21_Click(object sender, EventArgs e)
        {
            hora_selecionada.Clear();
            hora_selecionada.Text = "21:00";

            selectDateAsString = DP_Reserva.Value.ToString("yyyy-MM-dd");
            //Adicionar a hora escolhida a data
            selectDateAsString += "/21:00:00";

            //Parte a data e adiciona ahora do botão para comparar com a hora do sistema
            DateTime date1 = new DateTime(DP_Reserva.Value.Year, DP_Reserva.Value.Month, DP_Reserva.Value.Day, 21, 0, 0);
            DateTime date2;
            date2 = DateTime.Now;
            dataEscolhida = date1;

            // Compara as datas
            int result = DateTime.Compare(date1, date2);

            if (result < 0)
            {
                btn_21.BackColor = Color.Red;
                validaRserva = 0;
                lb_Mesas.Items.Clear();
            }
            else
            {

                ConteudoBotoes(21);

                btn_21.BackColor = Color.Green;
                validaRserva = 1;
            }
        }

        private async void btn_22_Click(object sender, EventArgs e)
        {
            hora_selecionada.Clear();
            hora_selecionada.Text = "22:00";

            selectDateAsString = DP_Reserva.Value.ToString("yyyy-MM-dd");
            //Adicionar a hora escolhida a data
            selectDateAsString += "/22:00:00";

            //Parte a data e adiciona ahora do botão para comparar com a hora do sistema
            DateTime date1 = new DateTime(DP_Reserva.Value.Year, DP_Reserva.Value.Month, DP_Reserva.Value.Day, 22, 0, 0);
            DateTime date2;
            date2 = DateTime.Now;
            dataEscolhida = date1;

            // Compara as datas
            int result = DateTime.Compare(date1, date2);

            if (result < 0)
            {
                btn_22.BackColor = Color.Red;
                validaRserva = 0;
                lb_Mesas.Items.Clear();
            }
            else
            {
                ConteudoBotoes(22);

                btn_22.BackColor = Color.Green;
                validaRserva = 1;
            }
        }

        private async void ConteudoBotoes(int hora)
        {
            FirebaseResponse response = await client.GetAsync("Reservas");
            string json = response.Body.ToString();
            Dictionary<string, ClasseReserva> data = JsonConvert.DeserializeObject<Dictionary<string, ClasseReserva>>(json);

            mesasReservadas.Clear();
            if (data != null)
            {
                reservas = data.Values.ToList();

                foreach (ClasseReserva reserva in reservas)
                {

                    //verificar se a reserva é para a data selecionada
                    if (DateTime.TryParseExact(reserva.DataReserva, new[] { "yyyy-MM-dd/HH:mm:ss", "dd/MM/yyyy HH:mm:ss" }, CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime dataReserva)) //Compara as datas
                    {
                        DateTime dataSelecionada = DP_Reserva.Value.Date.AddHours(hora);

                        //verificar se a reserva é para a data selecionada
                        if (dataReserva == dataSelecionada)
                        {
                            //adicionar o ID da mesa reservada à lista de mesas reservadas
                            mesasReservadas.Add(reserva.MesaID.ToString());
                        }
                    }
                }
            }

            mesasDisponiveis.Clear();
            if (mesas != null)
            {
                foreach (ClasseMesa mesa in mesas)
                {
                    if (!mesasReservadas.Contains(mesa.MesaID) && !mesasDisponiveis.Contains(mesa))//se a lista de mesas reservadas não contiver o ID que passou no ciclo, adiciona à lista de disponiveis
                    {
                        mesasDisponiveis.Add(mesa); // Adicionar as mesas que estão disponiveis à lista
                    }
                }
            }

            //adicionar as mesas disponíveis ao ListBox
            lb_Mesas.Items.Clear();
            foreach (ClasseMesa mesa in mesasDisponiveis) //Preencher a list box consoante a lista de mesas disponiveis
            {
                lb_Mesas.Items.Add("Mesa: " + mesa.MesaID + "  Capacidade: " + mesa.Capacidade);
            }
        }

        private void btn_19_Leave(object sender, EventArgs e)
        {
            btn_19.BackColor = Color.Gray;
        }

        private void btn_20_Leave(object sender, EventArgs e)
        {
            btn_20.BackColor = Color.Gray;
        }

        private void btn_21_Leave(object sender, EventArgs e)
        {
            btn_21.BackColor = Color.Gray;
        }

        private void btn_22_Leave(object sender, EventArgs e)
        {
            btn_22.BackColor = Color.Gray;
        }

        private void btn_12_Leave(object sender, EventArgs e)
        {
            btn_12.BackColor = Color.Gray;
        }

        private void btn_13_Leave(object sender, EventArgs e)
        {
            btn_13.BackColor = Color.Gray;
        }

        private void btn_14_Leave(object sender, EventArgs e)
        {
            btn_14.BackColor = Color.Gray;
        }

        private void btn_15_Leave(object sender, EventArgs e)
        {
            btn_15.BackColor = Color.Gray;
        }
    }
}


