using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Relacionamentos.Model
{
    public class Clientes
    {
        public string Nome { get; set; }
        public List<Vendas> Compras { get; set; } = new List<Vendas>();
    }
}
