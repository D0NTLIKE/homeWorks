using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restHall
{
    class Program
    {
        static void Main(string[] args)
        {
            //	   Small Hall	Terrace	Great Hall
           // Price   2500$  	5000$	7500$
            //Capacity    50    100     120

            double groupSize = double.Parse(Console.ReadLine());
            string pack = Console.ReadLine();


            double discount = 0;
             if (groupSize > 120)
            {
                Console.WriteLine("We do not have an appropriate hall.");
            }
            if (groupSize <=50)
            {
                Console.WriteLine($"We can offer you the Small Hall");
                if (pack == "Normal")
                {
                    discount = (500+2500) * 0.05;
                    Console.WriteLine($"The price per person is {((500+2500)-discount)/groupSize:f2}$");
                }
                else if (pack == "Gold")
                {
                    discount = (2500 + 750) * 0.10;
                    Console.WriteLine($"The price per person is {((750 + 2500) - discount) / groupSize:f2}$");
                }
                else
                {
                    discount = (2500 + 1000) * 0.15;
                    Console.WriteLine($"The price per person is {((1000 + 2500) - discount) / groupSize:f2}$");

                }
            }
            else if ((groupSize >50) && (groupSize <=100))
            {
                Console.WriteLine($"We can offer you the Terrace");
                if (pack == "Normal")
                {
                    discount = (500 + 5000) * 0.05;
                    Console.WriteLine($"The price per person is {((500 + 5000) - discount) / groupSize:f2}$");
                }
                else if (pack == "Gold")
                {
                    discount = (5000 + 750) * 0.1; 
                    Console.WriteLine($"The price per person is {((750 + 5000) - discount) / groupSize:f2}$");
                }
                else if(pack == "Platinum")
                {
                    discount = (5000 + 1000) * 0.15;
                    Console.WriteLine($"The price per person is {((1000 + 5000) - discount) / groupSize:f2}$");

                }
            }
            else if(groupSize>100 && groupSize <=120)
            {
                Console.WriteLine($"We can offer you the Great Hall");
                if (pack == "Normal")
                {
                    discount = (500 + 7500) * 0.05;
                    
                    Console.WriteLine($"The price per person is {((500 + 7500) - discount) / groupSize:f2}$");
                }
                else if (pack == "Gold")
                {
                    discount = (7500 + 750) * 0.1;
                    Console.WriteLine($"The price per person is {((750 + 7500) - discount) / groupSize:f2}$");
                }
                else if(pack == "Platinum")
                {
                    discount = (7500 + 1000) * 0.15;
                    Console.WriteLine($"The price per person is {((1000 + 7500) - discount) / groupSize:f2}$");

                }
            }
            
        }
    }
}
