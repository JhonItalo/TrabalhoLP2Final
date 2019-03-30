using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Delivery.Models
{
    public class Caixa
    {
        public int ID { get; set; }
        public float Valor { get; set; }
        public float Valortransacao { get; set; }
        public bool Tipotransacao { get; set; }
        public string Motivo { get; set; }
        public Funcionario FunId { get; set; }

        public Caixa() { }

        public Caixa(int iD, float valor, float valortransacao, bool tipotransacao, string motivo, Funcionario funId)
        {
            ID = iD;
            Valor = valor;
            Valortransacao = valortransacao;
            Tipotransacao = tipotransacao;
            Motivo = motivo;
            FunId = funId;
        }
    }
}
