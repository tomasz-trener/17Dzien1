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

            if (c1) //c1==true
            {
                Console.WriteLine("wysoki");
            }
            else
            {
                Console.WriteLine("jesteś niski");
            }

            // <160 to niski , pomiedzy 160 a 180 to sredni, a ponad 180 to wysoki 

            if(wzrost<160)
                Console.WriteLine("niski");
            else
                if (wzrost>180)
                    Console.WriteLine("wyoski");
                else
                    Console.WriteLine("średni");
            
            // lepiej unikac zagniezdzonych ifów 

            // zamiast tego lepiej stosować else ify 

            if(wzrost<160)
                Console.WriteLine($"twój wzrost to {wzrost} i jest niski");
            else if(wzrost>200)
                Console.WriteLine($"twój wzrost to {wzrost} i jest bardzo wyoski");
            else if(wzrost>180)
                Console.WriteLine($"twój wzrost to {wzrost} i jest wysoki");
            else
                Console.WriteLine($"twój wzrost to {wzrost} i jest średni");


            // twój wzrost wynosi xx i jest yy

            string wyn="";
            if (wzrost < 160)
                wyn = "niski";
            else if (wzrost > 200)
                wyn = "bardzo wysoki";
            else if (wzrost > 180)
                wyn = "wysoki";
            //else
            //    wyn = "sredni";

            string raport = $"Twoj wzrost wynosi {wzrost} i jest {wyn}";
            Console.WriteLine(raport);

            // operatory skrótowe 

            string wyn1;
            if (wzrost>180)
            {
                wyn1 = "wysoki";
            }
            else
            {
                wyn1 = "niski";
            }

            string wyn2 = wzrost > 180 ? "wyoski" : "niski";

            string wyn3 = wzrost > 200 ? "bardzo wyoski" : wzrost < 180 ? "niski" : "sredni"; 




            Console.ReadKey();

        }
    }
}
