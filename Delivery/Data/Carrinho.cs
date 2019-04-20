using System;
using System.Collections.Generic;
using Delivery.Models;

namespace Delivery.Data
{
    public class Carrinho
    {
        public static int Id { get; set; }
        public static List<ProdutoExtra> ProdutosExtras { get; set; } = new List<ProdutoExtra>();
    }
}