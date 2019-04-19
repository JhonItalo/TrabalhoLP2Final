using System.Collections.Generic;

namespace Delivery.Models
{
    public class Funcionario
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public string Funcao { get; set; }
        public string Contato { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public ICollection<Vendas> Vendidos { get; set; } = new List<Vendas>();
        public ICollection<Checkinout> Checkinouts { get; set; } = new List<Checkinout>();

        public Funcionario() { }

        public Funcionario(int iD, string nome, string funcao, string contato, string email, string senha)
        {
            ID = iD;
            Nome = nome;
            Funcao = funcao;
            Contato = contato;
            Email = email;
            Senha = senha;
        }

        public void AddVendidos(Vendas v)
        {
            Vendidos.Add(v);
        }

        public void RemoveVendidos(Vendas v)
        {
            Vendidos.Remove(v);
        }

        public void AddCheckinouts(Checkinout c)
        {
            Checkinouts.Add(c);
        }

        public void RemoveCheckinouts(Checkinout c)
        {
            Checkinouts.Remove(c);
        }
    }
}
