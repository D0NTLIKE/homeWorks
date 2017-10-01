using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aB
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
         

            double exit = a* 1.60934;
            Console.WriteLine($"{exit:f2}");
        }
    }
}
