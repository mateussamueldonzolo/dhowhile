using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            string continuar;
            int soma = 0;

            do
            {
                for (i = 0; i < 10; i++)
                {
                    
                    Console.WriteLine(i);
                }
                Console.WriteLine("Desejas continuar?");
                continuar = Console.ReadLine();
            } while (continuar == "N" || continuar == "n");

            if (continuar=="s" || continuar ==",S")
            {
                Console.WriteLine ("Gamer Over");
            }
           

            Console.Read();
        }
    }
}
