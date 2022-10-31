using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    internal class PrimeFactor
    {
        private static int i;

        public static void primeFactors(int n)
        {
         while (n % 2 == 0)
            {
                Console.WriteLine(2 + " ");
                n /= 2;
            }
            for (int i = 3; i <= Math.Sqrt(n); i += 2) ;
            {
                while (n % i == 0)
                {
                    Console.WriteLine(i + " ");
                    n /= i;
                }
            }
            if (n > 2)
                Console.WriteLine(n);
        }
    }
}
