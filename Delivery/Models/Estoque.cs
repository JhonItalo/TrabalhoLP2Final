using System.Collections.Generic;

namespace Delivery.Models
{
    public class Estoque
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public float Qtde { get; set; }
        public ICollection<RelatorioEstoque> Relatorio { get; set; } = new List<RelatorioEstoque>();

        public Estoque() { }

        public Estoque(int iD, string nome, float qtde)
        {
            ID = iD;
            Nome = nome;
            Qtde = qtde;
        }

        public void AddRelatorio(RelatorioEstoque re)
        {
            Relatorio.Add(re);
        }

        public void RemoveRelatorio(RelatorioEstoque re)
        {
            Relatorio.Remove(re);
        }
    }
}
