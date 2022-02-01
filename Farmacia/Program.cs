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

            List<Remedio> remedios = new List<Remedio>();

            Remedio remedio = new Remedio();
            remedio.Nome = "Gardenal";
            remedio.Quantidade = "50 ml";

            Remedio remedio1 = new Remedio();
            remedio1.Nome = "Paracetamol";
            remedio1.Quantidade = "15 ml";

            Remedio remedio2 = new Remedio();
            remedio2.Nome = "Viagra";
            remedio2.Quantidade = "12 Comp";

            Remedio remedio3 = new Remedio();
            remedio3.Nome = "Dipirona";
            remedio3.Quantidade = "50 ml";

            Remedio remedio4 = new Remedio();
            remedio4.Nome = "Voltarem";
            remedio4.Quantidade = "10 ml";

            remedios.Add(remedio);
            remedios.Add(remedio1);
            remedios.Add(remedio2);
            remedios.Add(remedio3);
            remedios.Add(remedio4);

            receita.Remedio = remedios;
            negocio.ExibeReceita(receita);
            
        }
        
    }
}
