using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_Académico.Reserva
{
    internal class ClasseMesa
    {
        [JsonProperty("ID")]
        public string MesaID { get; set; }
        public int Capacidade { get; set; }

        public List<ClasseMesa> ListaDeMesas { get; set; }
        public ClasseMesa()
        {
            ListaDeMesas = new List<ClasseMesa>();
        }
    }
}
