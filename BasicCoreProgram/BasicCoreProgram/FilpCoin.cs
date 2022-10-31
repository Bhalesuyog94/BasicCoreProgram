
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    public class FilpCoin
    {
        public static void NumberFilpCoin()
        {
            Console.WriteLine("Enter no of time want to flip the coin:");
            int n = Convert.ToInt32(Console.ReadLine());
            int T_count = 0;
            int H_count = 0;
            double heads, tails;
            for (int i = 0; i < n; i++)
            {
                Random r = new Random();
                double Check = r.NextDouble();

                if(Check < 0.5)
                {
                    T_count++;
                }
                else
                {
                    H_count++;
                }
                Console.WriteLine("Number of head counts:" + H_count);
                Console.WriteLine("Number of tail counts:" + T_count);
                heads = H_count / (double)n * 100;
                tails = T_count / (double)n * 100;
                Console.WriteLine("Percentage of Head is:" + heads);
                Console.WriteLine("Percentage of Tail is:" + tails);
            }
        }
    }
}
