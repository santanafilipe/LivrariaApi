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
    public class LivrosController : ControllerBase
    {
        public static List<Livro> _livros = new List<Livro>();
        public static int _id = 0;

        // GET: api/Livro
        [HttpGet]
        public IEnumerable<Livro> Get(string ti = null, string ed = null)
        {
            var query = _livros.Where(l => (ti == null || l.Titulo.Contains(ti)));

            return query.ToList();
        }

        // GET: api/Livro/5
        [HttpGet("{id}", Name = "Get")]
        public Livro Get(int id)
        {
            return _livros.SingleOrDefault(l => l.Id == id);
        }

        // POST: api/Livro
        [HttpPost]
        public void Post([FromBody] Livro livro)
        {
            livro.Id = _id++;
            _livros.Add(livro);
        }

        // PUT: api/Livro/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Livro livro)
        {
            var localLivro = _livros.SingleOrDefault(l => l.Id == id);

            if (localLivro != null)
            {
                _livros.Remove(localLivro);
                _livros.Add(livro);
            }
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var localLivro = _livros.SingleOrDefault(l => l.Id == id);

            if (localLivro != null)
            {
                _livros.Remove(localLivro);
            }
        }
    }
}
