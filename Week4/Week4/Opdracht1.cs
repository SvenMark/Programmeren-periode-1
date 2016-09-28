using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4
{
    class Opdracht1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ik wil 5 verschillende nummers: ");
            int[] number = new int[5];
            Console.Write("Nummer 1: ");
            number[0] = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nummer 2: ");
            number[1] = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nummer 3: ");
            number[2] = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nummer 4: ");
            number[3] = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nummer 5: ");
            number[4] = Convert.ToInt32(Console.ReadLine());
            int max_number = number.Max();
            Console.WriteLine(max_number);
            Console.ReadKey();
        }
    }
}
