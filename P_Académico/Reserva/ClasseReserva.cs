using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using P_Académico.Cliente;

namespace P_Académico
{
    internal class ClasseReserva : ClasseCliente //Herança da classe cliente
    {
        public int MesaID { get; set; }
        public string DataReserva { get; set; }
        public int NumeroPessoas { get; set; }
        public List<ClasseReserva> ListaDeReservas { get; set; }

        public ClasseReserva()
        {
            ListaDeReservas = new List<ClasseReserva>();
        }
    }
}
