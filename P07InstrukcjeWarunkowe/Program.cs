using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P07InstrukcjeWarunkowe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj swój wzrost");

            int wzrost = Convert.ToInt32(Console.ReadLine());

            bool c1 = wzrost > 180;

            if (c1)
            {
                Console.WriteLine("wysoki");
            }

            Console.ReadKey();

        }
    }
}
