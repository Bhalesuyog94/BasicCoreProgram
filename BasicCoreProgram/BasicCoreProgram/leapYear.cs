using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    public class leapYear
    {
        public static void CheckLeapyear()
        {
            int year;
            Console.WriteLine("Enter the year :");
            year = Convert.ToInt32(Console.ReadLine());
            if (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0))
            {
                Console.WriteLine(" is leap Year", year);
            }
            else
            {
                Console.WriteLine("is not leap Year", year);
            }

        }
    }
}
