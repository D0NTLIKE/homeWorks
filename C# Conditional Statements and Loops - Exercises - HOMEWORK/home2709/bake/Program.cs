using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace home2509
{
    class Program
    {
        static void Main(string[] args)
        {
            int ingCount = 0;

            for (int i = 0; i < 21; i++)
            {
                string word = Console.ReadLine();

                if (word != "Bake!")
                {

                    Console.WriteLine($"Adding ingredient {word}.");
                    ingCount++;
                }
                else
                {
                    Console.WriteLine($"Preparing cake with {ingCount} ingredients.");
                    break;
                }
            }
        }
    }

}
