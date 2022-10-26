using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02OperacjeNaNapisach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string napis = "ala ma kota";
                          //012345678910 
            int dlugosc = napis.Length;  // komentarz jednowierszowy 

            /* komentarz
             * wielo
             * wierszowy
            */

            Console.WriteLine(dlugosc);

            string s1= napis.Substring(4); //ma kota
            string s2 = napis.Substring(4,2); //ma

            Console.WriteLine(s1);

            bool czyZawiera=  napis.Contains("ma");

            Console.WriteLine(czyZawiera);

            string naDuze= napis.ToUpper();
            string naMale = napis.ToLower();

            string s3 = "ala" + "ma" + "kota";
            // alamakota

            string s4 = napis + " i psa";

            string s5= "ala".ToUpper();

            string s6 = "ala";
            s6= s6.ToUpper();
            //s6.ToUpper(); wynik nie zostanie nigdzie przypisany 
            Console.WriteLine(s6);

            string s7= napis.Replace("ma", "bedzie miala");
            // ala bedzie miala kota 

            int i1= napis.IndexOf("ma"); //zwraca pozycje szukanego ciagu
            // i1 = 4



            Console.ReadKey();




        }
    }
}
