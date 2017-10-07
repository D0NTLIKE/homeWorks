using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vowelOrDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            char x = char.Parse(Console.ReadLine());


            if (x=='a'||x == 'e' || x == 'i' || x == 'o' || x == 'u')
            {
                Console.WriteLine("vowel");
            }
            else if (char.IsNumber(x))
            {
                Console.WriteLine("digit");
            }
            else
            {
                Console.WriteLine("other");
            }
        }
    }
}
