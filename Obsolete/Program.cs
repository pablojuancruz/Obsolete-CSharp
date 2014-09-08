using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obsolete
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> remedios= new List<string>();

            remedios.Add("Dorflex");
            remedios.Add("Neosaldina");
            remedios.Add("Viagra");
            remedios.Add("Paracetamol");

            var farmacia = new Farmacia{ListaRemedios = remedios};

            Console.WriteLine("Digite o nome do remedio a pesquisar");
            var nomeRemedio = Console.ReadLine();

            bool temRemedio = farmacia.ExisteRemedio(nomeRemedio);

            //bool temRemedio = farmacia.ExisteRemedioContains(nomeRemedio);

            if (temRemedio)
                Console.Write("Remedio foi encontrado");
            else
                Console.Write("Remedio não foi encontrado");

            Console.ReadKey();
            
        }
    }
}
