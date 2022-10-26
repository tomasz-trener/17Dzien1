using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P13PetlaDoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string zdanie = "ala ma kota";
            int i = 0;

            do
            {
                Console.WriteLine(zdanie.Substring(i,1));
                i++;

            } while (i<zdanie.Length);

            
        }
    }
}
