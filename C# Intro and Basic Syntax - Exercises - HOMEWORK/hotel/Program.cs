using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            string num1 = Console.ReadLine();
            string num2 = Console.ReadLine();
            string num3 = Console.ReadLine();
            string num4 = Console.ReadLine();

            string one = num1.PadLeft(4, '0');
            string two = num2.PadLeft(4, '0');
            string tree = num3.PadLeft(4, '0');
            string four = num4.PadLeft(4, '0');

            string cart = $"{one} {two} {tree} {four}";
            Console.WriteLine(cart);
        }
    }
}
