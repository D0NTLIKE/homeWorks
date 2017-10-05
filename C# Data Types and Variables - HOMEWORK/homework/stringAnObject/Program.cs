using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringAnObject
{
    class Program
    {
        static void Main(string[] args)
        {
            string hello = "Hello";
            string world = "World";
            string halloWord = string.Concat(hello +" "+ world);

            object output = (string)(halloWord);
            Console.WriteLine(output);
        }
    }
}
