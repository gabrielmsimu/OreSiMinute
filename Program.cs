using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace OreSiMinute
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti ora curenta");
            int h = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti minutele curente");
            int m = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti cate minute doriti sa adaugati");
            int x = int.Parse(Console.ReadLine());

            int m2 = (m + x) % 60;
            int h2 = h + x / 60;

            Console.WriteLine($"Peste {x} minute va fi ora {h2} si {m2} minute.");

        }
    }
}
