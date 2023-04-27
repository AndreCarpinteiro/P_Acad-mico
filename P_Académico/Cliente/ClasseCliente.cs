using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_Académico.Cliente
{
    internal class ClasseCliente
    {
        public string Nome { get; set; }
        public string Apelido { get; set; }
        public string ContactoTelefonico { get; set; }
        public string Email { get; set; }
        public string DataNascimento { get; set; }
        public string NIF { get; set; }
        public string Endereco { get; set; }
        public string Genero { get; set; }

        public List<ClasseCliente> ListaDeClientes { get; set; }

        public ClasseCliente()
        {
            ListaDeClientes = new List<ClasseCliente>();
        }
    }
}
