using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testNums
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());

            int allong = int.Parse(Console.ReadLine());

            var combinationsCounter = 0;
            var result = 0.0;

            for (int i = n; i >= 1; i--)
            {
                for (int j = 1; j <= m; j++)
                {

                    if (result >= allong)
                    {
                        break;
                    }
                    result += (i * j) * 3;
                    combinationsCounter++;

                }
            }
            if (result >= allong)
            {
                Console.WriteLine($"{combinationsCounter} combinations");
                Console.WriteLine($"Sum: {result} >= {allong}");

            }
            else
            {
                Console.WriteLine($"{combinationsCounter} combinations");
                Console.WriteLine($"Sum: {result}");
            }
        }
    }
}