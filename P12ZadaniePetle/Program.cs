using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P12ZadaniePetle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wczytaj zdanie");
            string zdanie = Console.ReadLine();

            Console.WriteLine("Wczytaj wyraz");
            string wyraz = Console.ReadLine();

            //ala ma kota i ma psa
            //                  ma
            //01234....

            int i = 0;
            int suma = 0;
            while (i < zdanie.Length-wyraz.Length)
            {
                string podciag = zdanie.Substring(i, wyraz.Length);
                if (podciag == wyraz)
                    suma++;

                i++;
            }

            Console.WriteLine(suma);
            Console.ReadKey();

        }
    }
}
