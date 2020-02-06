using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nikŠimetićZadatak1
{
    class Program
    {
        static void Main(string[] args)
        {
            float a, b, c, prosjek;
            Console.WriteLine("Unesi 3 broja: ");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            prosjek = (a + b + c) / 3;


                Console.WriteLine("Prosjek je:" + prosjek);
            Console.ReadKey();

        }
    }
}
