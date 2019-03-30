using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Delivery.Models
{
    public class Produto
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public float Preco { get; set; }
        public string Tamanho { get; set; }
        public string Descricao { get; set; }
        public float Desconto { get; set; }

        public Produto() { }

        public Produto(int iD, string nome, float preco, string tamanho, string descricao, float desconto)
        {
            ID = iD;
            Nome = nome;
            Preco = preco;
            Tamanho = tamanho;
            Descricao = descricao;
            Desconto = desconto;
        }
    }
}
