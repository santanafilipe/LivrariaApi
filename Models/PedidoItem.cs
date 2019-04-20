using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LivrariaApi.Models
{
    public class PedidoItem
    {
        public long IdPedido { get; set; }
        public long IdLivro { get; set; }

        public Pedido Pedido { get; set; }
        public Livro Livro { get; set; }
    }
}
