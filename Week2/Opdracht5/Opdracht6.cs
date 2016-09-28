using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht5
{
    class Opdracht6
    {
        static void Main(string[] args)
        {
            Console.Write("Euro: ");
            double Euro = Convert.ToDouble(Console.ReadLine());
            double Dollar = Euro * 1.2231;
            Console.WriteLine("Dollar: {0}", Dollar);
            Console.ReadLine();
        }
    }
}
