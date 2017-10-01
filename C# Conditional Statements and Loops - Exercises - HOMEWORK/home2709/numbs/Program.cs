using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace magicLetter
{
    class Program
    {
        static void Main(string[] args)
        {
            char startLetter = char.Parse(Console.ReadLine());
            char endLetter = char.Parse(Console.ReadLine());
            string ignoreLetter = Console.ReadLine();

            string end = "";

            for (char i = startLetter; i <= endLetter; i++)
            {
                for (char j = startLetter; j <= endLetter; j++)
                {
                    for (char k = startLetter; k <= endLetter; k++)
                    {
                        end = $"{i}{j}{k}";
                        if (!end.Contains(ignoreLetter))
                        {
                            Console.Write(end + " ");
                        }
                    }
                }
            }
        }
    }
}