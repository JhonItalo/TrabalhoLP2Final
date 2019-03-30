using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Delivery.Models
{
    public class DeliveryContext : DbContext
    {
        public DeliveryContext (DbContextOptions<DeliveryContext> options)
            : base(options)
        {
        }

        public DbSet<Delivery.Models.Funcionario> Funcionario { get; set; }
        public DbSet<Delivery.Models.Vendas> Vendas { get; set; }
        public DbSet<Delivery.Models.Caixa> Caixa { get; set; }
        public DbSet<Delivery.Models.Checkinout> Checkinout { get; set; }
        public DbSet<Delivery.Models.Estoque> Estoque { get; set; }
        public DbSet<Delivery.Models.Extra> Extra { get; set; }
        public DbSet<Delivery.Models.Produto> Produto { get; set; }
        public DbSet<Delivery.Models.ProdutoExtra> ProdutoExtra { get; set; }
        public DbSet<Delivery.Models.RelatorioEstoque> RelatorioEstoque { get; set; }
    }
}
