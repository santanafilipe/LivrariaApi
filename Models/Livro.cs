using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LivrariaApi.Models
{
    public class Livro : ModelBase
    {
        public string Titulo { get; set; }
        public string Edicao { get; set; }
        public string Editora { get; set; }
        public string Idioma { get; set; }
        public decimal PrecoUnitario { get; set; }
        public IEnumerable<Autor> Autores { get; set; }
        public IEnumerable<Avaliacao> Comentarios { get; set; }
    }
}
