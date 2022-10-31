using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    internal class Powerof2
    {
        public static void PowerofTwo()
        {
            Console.WriteLine("Enter a Number:");
                int num = Convert.ToInt32(Console.ReadLine());
            if (num > 31)
            {
                Console.WriteLine("enter valid number");
            }
            else
            {
                for(int i = 0; i <= num; i++)
                {
       
                    Console.WriteLine("Power of two is:"+ Math.Pow(2,i));
                }
            }
        }
    }
}
