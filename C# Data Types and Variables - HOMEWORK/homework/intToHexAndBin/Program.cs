using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace intToHexAndBin
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(n.ToString("X"));
            Console.WriteLine(Convert.ToString(Convert.ToInt32(n), 2));
        }
    }
}
