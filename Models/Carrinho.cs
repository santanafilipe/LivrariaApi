using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LivrariaApi.Models
{
    public class Carrinho : ModelBase
    {
        public List<PedidoItem> Itens { get; set; }
    }
}
