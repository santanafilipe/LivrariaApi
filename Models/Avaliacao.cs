using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LivrariaApi.Models
{
    public class Avaliacao : ModelBase
    {
        public short Nota { get; set; }
        public string Titulo { get; set; }
        public string Comentario { get; set; }
        public long IdLivro { get; set; }
        public Livro Livro { get; set; }
    }
}
