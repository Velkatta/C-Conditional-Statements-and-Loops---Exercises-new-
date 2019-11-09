using System;

namespace _08._Calories_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int cheese = 500;
            int tomatoSauce = 150;
            int salami = 600;
            int pepper = 50;
            int totalCalories = 0;

            for (int i = 1; i <= n; i++)
            {
                string ingredient = Console.ReadLine().ToLower();

                switch (ingredient)
                {
                    case "cheese":
                        totalCalories += cheese;
                        break;
                    case "tomato sauce":
                        totalCalories += tomatoSauce;
                        break;
                    case "salami":
                        totalCalories += salami;
                        break;
                    case "pepper":
                        totalCalories += pepper;
                        break;

                    default:
                        break;
                }
            }
            Console.WriteLine($"Total calories: {totalCalories}");
        }
    }
}