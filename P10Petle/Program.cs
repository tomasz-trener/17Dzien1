using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P10Petle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // while 

            //int i = 0;
            //while (i<10)
            //{
            //    Console.WriteLine("hej " +i);
            //    i++;
            //}
            int pozSpacji = -1;
            while (pozSpacji < 0)
            {
                Console.WriteLine("Podaj dwie liczby oddzielone spacją");  //100
                string liczby = Console.ReadLine();  // 10 100
                                                     // 012345
                pozSpacji = liczby.IndexOf(" "); // pozSpacji=2

                if (pozSpacji>-1)
                {
                    int nowaLiczba1 = Convert.ToInt32(liczby.Substring(0, pozSpacji));
                    int nowaLiczba2 = Convert.ToInt32(liczby.Substring(pozSpacji + 1));

                    int nowaSuma = nowaLiczba1 + nowaLiczba2;
                    Console.WriteLine(nowaSuma);
                }    
            }

            
            Console.ReadKey();



        }
    }
}
