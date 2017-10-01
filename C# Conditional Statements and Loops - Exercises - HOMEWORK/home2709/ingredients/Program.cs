using System;

namespace Problem_8.Calories_Counter
{
    public class Program
    {
        public static void Main()
        {
            int numb = int.Parse(Console.ReadLine());

            int pepper = 0;
            int salami = 0;
            int tomatoSauce = 0;
            int cheese = 0;

            for (int i = 1; i <= numb; i++)
            {
                string ingredients = Console.ReadLine().ToLower();
                if (ingredients == "cheese")
                {
                    cheese += 500;
                }
                else if (ingredients == "salami")
                {
                    salami += 600;
                }
                else if (ingredients == "pepper")
                {
                    pepper += 50;
                }
                else if (ingredients == "tomato sauce")
                {
                    tomatoSauce += 150;
                }
            }
            int allIngredients = cheese + pepper + salami + tomatoSauce;
            Console.WriteLine($"Total calories: {allIngredients}");
        }
    }
}