using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Relacionamentos.Model
{
    public class Autor
    {
        public string Nome { get; set; }
        public ICollection<Livro>? LivrosEscritos { get; set; } = new List<Livro>();
     }
    
}
