using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_Académico.Pedido
{
    internal class Pedido
    {
        public string Id { get; set; }
        public string Nome { get; set; }
        public string Categoria { get; set; }
        public string Preco { get; set; }
        public string User { get; set; }
        public int Quantidade { get; set; }
        public DataPedido Data { get; set; }
    }

    public class DataPedido
    {
        public int date { get; set; }
        public int day { get; set; }
        public int hours { get; set; }
        public int minutes { get; set; }
        public int month { get; set; }
        public int seconds { get; set; }
        public long time { get; set; }
        public int timezoneOffset { get; set; }
        public int year { get; set; }
    }
}
