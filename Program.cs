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
            int n = 0, som;

            for (int i = 1; i <= n; i++)
            {
                som = 0;
                Console.WriteLine(n);
                if ((i % 2) == 1)
                {
                    Console.WriteLine(i);
                    som = som + i;
                    Console.WriteLine(som);
                }
            }

            Console.ReadKey();
        }
    }
}
