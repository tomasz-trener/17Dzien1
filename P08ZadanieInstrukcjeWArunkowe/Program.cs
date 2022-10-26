using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P08ZadanieInstrukcjeWArunkowe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wczytaj równanie matematyczne");
            string rownanie = Console.ReadLine();

            string op = rownanie.Substring(1, 1);
            int liczba1 = Convert.ToInt32(rownanie.Substring(0, 1));
            int liczba2 = Convert.ToInt32(rownanie.Substring(2));

            //string wynikS = null;

            double liczbaNiecalkowita = 5.4;

            double? wynik=null;
            if (liczba2 !=0 && op=="/")
            {
                if (op == "+")
                    wynik = liczba1 + liczba2;
                else if (op == "-")
                    wynik = liczba1 - liczba2;
                else if (op == "*")
                    wynik = liczba1 * liczba2;
                else if (op == "/")
                    wynik = Convert.ToDouble(liczba1) / liczba2;
                else
                    Console.WriteLine("zły operator");
            }else
                Console.WriteLine("nie można dzielić przez 0");
  

            if(wynik!= null)
                Console.WriteLine(wynik);

            Console.ReadKey();




        }
    }
}
