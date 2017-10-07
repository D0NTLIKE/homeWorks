using System;

namespace _11ConvertSpeedUnits
{
    class Program
    {
        static void Main(string[] args)
        {
            int distanceInMeters = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int seconds = int.Parse(Console.ReadLine());

            int time = hours * 3600 + minutes * 60 + seconds;

            float minutesInSecond = (float)distanceInMeters / time;
            float kiloInHour = ((float)distanceInMeters / 1000) / ((float)time / 3600);
            float milesInHour = ((float)distanceInMeters / 1609) / ((float)time / 3600);

            Console.WriteLine($"{minutesInSecond:0.#######}\n{kiloInHour:0.#######}\n{milesInHour:0.#######}");
        }
    }
}