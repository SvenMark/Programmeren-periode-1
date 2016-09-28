using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht4
{
    class Opdracht4
    {
        static void Main(string[] args)
        {
            Console.Write("Celsius: ");
            int Celsius = Convert.ToInt32(Console.ReadLine());
            int Fahrenheit = (Celsius * 9) / 5 + 32;
            Console.WriteLine("Fahrenheit: {0}", Fahrenheit);
            Console.ReadLine();
            //float 7 getallen double 16.
        }
    }
}
