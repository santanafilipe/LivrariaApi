using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LivrariaApi.Models
{
    public class Pedido : ModelBase
    {
        public DateTime DataPedido { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Rua { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Cep { get; set; }
        public IEnumerable<PedidoItem> Livros{ get; set; }
    }
}
