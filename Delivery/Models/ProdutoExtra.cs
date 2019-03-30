using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Delivery.Models
{
    public class ProdutoExtra
    {
        public int ID { get; set; }
        public int Qtde_pro { get; set; }
        public int Qtde_ext { get; set; }
        public float Preco_pro { get; set; }
        public float Preco_ext { get; set; }
       
        public Produto ProId { get; set; }
        public Extra ExtId { get; set; }

        public ProdutoExtra() { }

        public ProdutoExtra(int iD, int qtde_pro, int qtde_ext, float preco_pro, float preco_ext, Produto proId, Extra extId)
        {
            ID = iD;
            Qtde_pro = qtde_pro;
            Qtde_ext = qtde_ext;
            Preco_pro = preco_pro;
            Preco_ext = preco_ext;
           
            ProId = proId;
            ExtId = extId;
        }
    }
}
