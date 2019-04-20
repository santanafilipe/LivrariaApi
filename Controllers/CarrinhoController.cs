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
    public class CarrinhoController : ControllerBase
    {
        public static Carrinho _carrinho = new Carrinho();

        public CarrinhoController()
        {
            _carrinho.Itens = new List<PedidoItem>();
        }

        // GET: api/Carrinho
        [HttpGet]
        public Carrinho Get()
        {
            return _carrinho;
        }

        // POST: api/Carrinho
        [HttpPost]
        public void Post([FromBody] PedidoItem item)
        {
            _carrinho.Itens.Add(item);
        }

        // PUT: api/Carrinho/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] PedidoItem item)
        {
            var localItem = _carrinho.Itens.SingleOrDefault(l => l.IdLivro == id);

            if (localItem != null)
            {
                _carrinho.Itens.Remove(localItem);
                _carrinho.Itens.Add(localItem);
            }
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var localItem = _carrinho.Itens.SingleOrDefault(l => l.Livro.Id == id);

            if (localItem != null)
            {
                _carrinho.Itens.Remove(localItem);
            }
        }
    }
}
