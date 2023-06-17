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
    }
}
