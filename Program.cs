using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testirovanie13042023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 1;

            if(a == 1 || a == 2 || a == 12)
            {
                Console.WriteLine("Зима");
            }
            else if(a == 3 || a == 4 || a == 5) 
            {
                Console.WriteLine("Весна");
            }
            else if (a == 6 || a == 7 || a == 8)
            {
                Console.WriteLine("Лето");
            }
            else if (a == 9 || a == 10 || a == 11)
            {
                Console.WriteLine("Осень");
            }

        }
    }
}
