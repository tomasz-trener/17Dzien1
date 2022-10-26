using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P11PetleBreake
{
    internal class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("Podaj dwie liczby oddzielone spacają");
                string liczby = Console.ReadLine();  // 10 100
                                                     //  012345
                int pozSpacji = liczby.IndexOf(" "); // pozSpacji=2

                if (pozSpacji == -1)
                    continue;

                int nowaLiczba1 = Convert.ToInt32(liczby.Substring(0, pozSpacji));
                int nowaLiczba2 = Convert.ToInt32(liczby.Substring(pozSpacji + 1));

                int nowaSuma = nowaLiczba1 + nowaLiczba2;
                Console.WriteLine(nowaSuma);

                if (pozSpacji>-1)
                    break;  
            }



            

        }
    }
}
