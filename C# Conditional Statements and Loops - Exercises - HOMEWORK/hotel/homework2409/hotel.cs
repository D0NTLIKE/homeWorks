using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework2409
{
    class hotel
    {
        static void Main(string[] args)
        {
            //Console.WriteLine($"Studio: {} lv.");
            //Console.WriteLine($"Double: {} lv.");
            //Console.WriteLine($"Suite: {} lv.");


            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());

            double studio = 0;
            double ddouble = 0;
            double suite = 0;

            switch (month)
            {
                case "May":
                case "October":
                    studio = 50; ddouble = 65; suite = 75;
                    break;
                case "June":
                case " September":
                    studio = 60; ddouble = 72; suite = 82;
                    break;
                case "July":
                case "August":
                case "December":
                    studio = 68; ddouble = 77; suite = 89;
                    break;

            }
            if ((month == "May" || month == "October") && nights > 7)
            {
                studio *= 0.95;
            }
            else if ((month == "June" || month == "September") && nights > 14)
            {
                ddouble *= 0.9;
            }
            else if ((month == "July" || month == "August" || month == "December") && nights > 14)
            {
                suite *= 0.85;
            }

            double studioVac = studio * nights;
            double doubleVac = ddouble * nights;
            double suiteVac = suite * nights;

            if ((month == "September" || month == "October") && nights > 7)
            {
                studioVac -= studio;
            }
            Console.WriteLine($"Studio: {studioVac:f2} lv.");
            Console.WriteLine($"Double: {doubleVac:f2} lv.");
            Console.WriteLine($"Suite: {suiteVac:f2} lv.");
        }
    }
}
