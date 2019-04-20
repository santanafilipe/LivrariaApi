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
    public class AvaliacoesController : ControllerBase
    {
        public static Avaliacao _avaliacao = new Avaliacao();
       
        // GET: api/Avaliacoes/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int idLivro)
        {
            return "value";
        }

        // POST: api/Avaliacoes
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Avaliacoes/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
