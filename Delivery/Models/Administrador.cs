using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Delivery.Models
{
    public class Administrador
    {
        public int ID { get; set; }
        public string Usuario { get; set; }
        public string Senha { get; set; }

        public Administrador() { }

        public Administrador(int iD, string usuario, string senha)
        {
            ID = iD;
            Usuario = usuario;
            Senha = senha;
        }
    }
}
