using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacia
{
    public class Receita
    {
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public List<Remedio> Remedio { get; set; }
      
    }
}

