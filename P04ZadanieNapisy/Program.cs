using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04ZadanieNapisy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------- część 1 -------");
            Console.WriteLine("Podaj kolejno liczby");
            int liczba1 = Convert.ToInt32(Console.ReadLine());
            int liczba2 = Convert.ToInt32(Console.ReadLine());

            //po lewej stronie jest int a po prawej jest string 
            //int liczba2 = Console.ReadLine();

            //int liczba4 = "5"; // nie moge 
            int liczba5= Convert.ToInt32("5"); // to tez
            int liczba6 = 5; // to dziala

            int suma = liczba1 + liczba2;

            // problem:  łaczenie ze sobą różnych typów w jeden ciąg
            // raportowanie 

            int liczbaZnakow = Convert.ToString(suma).Length;

            string s1 = "Wynik złożony jest z : " +
               liczbaZnakow +
                " znaków";

            string s2 = $"Wynik {suma} złożony z {liczbaZnakow} znaków";

            string s3 = string.Format("Wynik {0} złożony z {1}",
                suma, liczbaZnakow);

            Console.WriteLine("Wynik to:" + suma);
            Console.WriteLine(s3);


            Console.WriteLine("------- część 2 -------");


            Console.WriteLine("Podaj dwie liczby oddzielone spacają");
            string liczby = Console.ReadLine();  // 10 100
                                                //  012345
            int pozSpacji= liczby.IndexOf(" "); // pozSpacji=2

            int nowaLiczba1 = Convert.ToInt32(liczby.Substring(0, pozSpacji));
            int nowaLiczba2 = Convert.ToInt32(liczby.Substring(pozSpacji+1));

            int nowaSuma = nowaLiczba1 + nowaLiczba2;
            Console.WriteLine(nowaSuma);

            Console.ReadKey();
        }
    }
}
