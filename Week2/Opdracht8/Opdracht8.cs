using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht8
{
    class Opdracht8
    {
        static void Main(string[] args)
        {
            Console.WriteLine("y = a * (b / c)");

            Console.Write("a: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("b: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.Write("c: ");
            int c = Convert.ToInt32(Console.ReadLine());

            int y = a * (b / c);

            Console.WriteLine("Resultaat {0}", y);
            Console.ReadLine();

        }
    }
}
