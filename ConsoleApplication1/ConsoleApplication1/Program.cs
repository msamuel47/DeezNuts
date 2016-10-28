using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 200; i++)
                {
                    Console.WriteLine("Bonjour ma gang de crottée");
                }
            Console.WriteLine("allo");
            string deezNuts = Console.ReadLine();
            Console.WriteLine(deezNuts);
            Console.ReadKey();
            Console.WriteLine("Veuillez appuyer pour continuer");
        }

        void AfficherQuelqueChoseDeLaid()
        {
            for (int i = 0; i < 1000; i++)
                {
                    Console.WriteLine("Vous êtes très laid x{0}", i);
                }
        }
    }
}
