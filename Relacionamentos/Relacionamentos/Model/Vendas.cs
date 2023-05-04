using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Relacionamentos.Model
{
    internal class Vendas
    {
        public int Numero { get; set; }
        public Clientes Comprador { get; set; }
    }
}
