using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Delivery.Models
{
    public class RelatorioEstoque
    {
        public int ID { get; set; }
        public DateTime Data { get; set; }
        public float Qtde { get; set; }
        public bool Tipo { get; set; }
       

        public RelatorioEstoque() { }

        public RelatorioEstoque(int iD, DateTime data, float qtde, bool tipo)
        {
            ID = iD;
            Data = data;
            Qtde = qtde;
            Tipo = tipo;
            
        }
    }
    }

