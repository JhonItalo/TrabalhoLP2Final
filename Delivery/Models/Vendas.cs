using System;
using System.Collections.Generic;

namespace Delivery.Models
{
    public class Vendas
    {
        public int ID { get; set; }
        public float Total { get; set; }
        public string Metodopagamento { get; set; }
        public float Desconto { get; set; }
        public string Rua { get; set; }
        public string Bairro { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public DateTime Datahora { get; set; }
        public ICollection<ProdutoExtra> Produtosextras { get; set; } = new List<ProdutoExtra>();

        public Vendas() { }

        public Vendas(int iD, float total, string metodopagamento, float desconto, string rua, string bairro, string numero, string complemento, DateTime datahora)
        {
            ID = iD;
            Total = total;
            Metodopagamento = metodopagamento;
            Desconto = desconto;
            Rua = rua;
            Bairro = bairro;
            Numero = numero;
            Complemento = complemento;
            Datahora = datahora;
            
        }

        public void AddProdutosextras(ProdutoExtra pe)
        {
            Produtosextras.Add(pe);
        }

        public void RemoveProdutosextras(ProdutoExtra pe)
        {
            Produtosextras.Remove(pe);
        }
    }
}
