using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework1
{
    class oneAndTwo
    {
        static void Main(string[] args)
        {
            //	     Water   Coffee	  Beer	  Tea
            //Price   0.70    1.00    1.70    1.20

            string proff = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());

            double pay = 0;
            switch (proff)
            {

                case "Athlete":
                    pay = 0.70;
                    Console.WriteLine($"The {proff} has to pay {quantity*pay:f2}.");
                    break;
                case "Businessman":
                case "Businesswoman":
                    pay = 1.00;
                    Console.WriteLine($"The {proff} has to pay {quantity * pay:f2}.");
                    break;
                case "SoftUni Student":
                    pay = 1.70;
                    Console.WriteLine($"The {proff} has to pay {quantity * pay:f2}.");
                    break;
                default:
                    pay = 1.20;
                    Console.WriteLine($"The {proff} has to pay {quantity * pay:f2}.");
                    break;
            }
            
           
           

        }
    }
}
