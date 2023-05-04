using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Relacionamentos.Model
{
    public class Livro
    {
        public string Titulo { get; set; } 
        public ICollection<Autor> Autores{ get; set; } = new List<Autor>();
    }
}
