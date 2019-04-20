using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LivrariaApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LivrariaApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PedidosController : ControllerBase
    {
        public static List<Pedido> _pedidos = new List<Pedido>();
        public static int _id = 0;

        // GET: api/Pedidos
        [HttpGet]
        public IEnumerable<Pedido> Get()
        {
            return _pedidos;
        }

        // GET: api/Pedidos/5
        [HttpGet("{id}", Name = "Get")]
        public Pedido Get(int id)
        {
            return _pedidos.SingleOrDefault(l => l.Id == id);
        }

        // POST: api/Pedidos
        [HttpPost]
        public void Post([FromBody] Pedido pedido)
        {
            pedido.Id = _id++;
            _pedidos.Add(pedido);
        }

        // PUT: api/Pedidos/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Pedido pedido)
        {
            var localPedido = _pedidos.SingleOrDefault(l => l.Id == id);

            if (localPedido != null)
            {
                _pedidos.Remove(localPedido);
                _pedidos.Add(pedido);
            }
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var localPedido = _pedidos.SingleOrDefault(l => l.Id == id);

            if (localPedido != null)
            {
                _pedidos.Remove(localPedido);
            }
        }
    }
}
