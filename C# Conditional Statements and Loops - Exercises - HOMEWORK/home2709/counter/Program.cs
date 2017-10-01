using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace counter
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;

            try
            {
                while (true)
                {
                    int integer = int.Parse(Console.ReadLine());
                    
                    counter++;
                }
            }
            catch (Exception)
            {
                Console.WriteLine(counter);
            }
            
            
        }
    }
}
