using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esther
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 45, som = 0;

            for (int i = 0; i <= n; i++)
            {
                if ((i % 2) == 1)
                {
                    Console.WriteLine(i);
                    som = som + i;
                }
            }

            Console.WriteLine(som);
            Console.ReadKey();
            // je pense que c'est la bonne solution 
        }
    }
}
