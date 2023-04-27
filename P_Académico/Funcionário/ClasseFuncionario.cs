using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_Académico.Funcionário
{
    internal class ClasseFuncionario
    {
        public string Nome { get; set; }
        public string Apelido { get; set; }
        public string ContactoTelefonico { get; set; }
        public string Email { get; set; }
        public string DataNascimento { get; set; }
        public string NIF { get; set; }
        public string Endereco { get; set; }
        public string Genero { get; set; }
        public string DataAdmissao { get; set; }
        public string Funcao { get; set; }

        public List<ClasseFuncionario> ListaDeFuncionarios { get; set; }

        public ClasseFuncionario()
        {
            ListaDeFuncionarios = new List<ClasseFuncionario>();
        }
    }
}
