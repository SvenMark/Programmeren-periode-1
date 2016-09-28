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
            int[] getallen1;
            getallen1 = new int[5];
            int[] getallen2;
            getallen2 = new int[5];
            int[] answer;
            answer = new int[5];

            Random Dobbelsteen = new Random();
            for (int i = 0; i < 5; i++)
            {
                int getal1 = Dobbelsteen.Next(1, 10);
                int getal2 = Dobbelsteen.Next(1, 10);
                getallen1[i] = getal1;
                getallen2[i] = getal2;
                answer[i] = getallen1[i] + getallen2[i];
                Console.WriteLine("{0} + {1} = {2}", getallen1[i], getallen2[i], answer[i]);
            }
            Console.ReadKey();
        }
    }
}
