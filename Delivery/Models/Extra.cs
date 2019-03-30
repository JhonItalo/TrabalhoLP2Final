using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Delivery.Models
{
    public class Extra
    {
        public int ID { get; set; }
        public string Nome{ get; set; }
        public float Preco { get; set; }

        public Extra() { }

        public Extra(int iD, string nome, float preco)
        {
            ID = iD;
            Nome = nome;
            Preco = preco;
        }
    }
}
