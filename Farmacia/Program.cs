using System;
using Farmacia;

namespace Farmacia
{
   public class Program
    {
        static void Main(string[] arg)
        {
            Negocio negocio = new Negocio();
            Receita receita = new Receita();
            receita.Nome = "Bebuxa";
            receita.Endereco = "São João da Boa Vista";
            
            Remedio remedio = new Remedio();
            remedio.Nome = "Gardenal";
            remedio.Quantidade = "50 ml";
            receita.Remedio = remedio;
            negocio.ExibeReceita(receita);
            
        }
        
    }
}
