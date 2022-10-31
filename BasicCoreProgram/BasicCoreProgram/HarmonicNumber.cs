using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    internal class HarmonicNumber
    {
        public static void HarmonicNthNum()
        {
            double Harmonic = 0;
            Console.WriteLine("enter the number");
            int num = Convert.ToInt32(Console.ReadLine());
            for (double i = 1; i <= num; i++)
            {
                Harmonic += (1 / i);
            }
            Console.WriteLine("total harmonic Sum:" + Harmonic);
        }
    }
}
