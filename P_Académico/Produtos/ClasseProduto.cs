using Newtonsoft.Json;
using P_Académico.Funcionário;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_Académico.Produtos
{
    internal class ClasseProduto : ClasseImagem //herança da classe imagem
    {
        public string ProdutoID { get; set; }
        public string Nome { get; set; }
        public string Preco { get; set; }
        public string Categoria { get; set; }
        public string Descricao { get; set; }

        public List<ClasseProduto> ListaDeProdutos { get; set; }

        public ClasseProduto()
        {
            ListaDeProdutos = new List<ClasseProduto>();
        }
    }
}
