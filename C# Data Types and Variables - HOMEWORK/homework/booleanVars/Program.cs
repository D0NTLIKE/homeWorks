using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace booleanVars
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            bool isInput = Convert.ToBoolean(input);
            if (isInput ==true)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
            
        }
    }
}
