using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacia
{
    public class Negocio
    {
        public void ExibeReceita(Receita receita)
        {
            Console.WriteLine("Nome: " + receita.Nome);
            Console.WriteLine("Endereco: " + receita.Endereco);
            Console.WriteLine("Remedio: " + receita.Remedio.Nome);
            Console.WriteLine("Quantidade: " + receita.Remedio.Quantidade);

        }
    }
}
