using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P014PetlaFor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string zdanie = "ala ma kota";
            
            int i = 0;
            while (i<zdanie.Length)
            {
                Console.WriteLine(zdanie.Substring(i,1));
                i++;
            }

            i = 0;
            while (i<10)
            {

            }

            // 1) treba pamietac o zmienniku i
            // 2) trzeba pamietac o zwiekszaniu tego zmiennika
            // 3) trzeba zerowac zmieenik przed ewentalnym nastepnym uzyciem

            for (int j = 0; j < 10; j++)
                Console.WriteLine(zdanie.Substring(j,1));


            


        }
    }
}
