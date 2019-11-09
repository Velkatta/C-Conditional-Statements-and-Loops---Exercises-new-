using System;

namespace _02._Choose_a_Drink_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            string profession = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());

            double price = 0;
            double water = 0.70;
            double coffee = 1.00;
            double beer = 1.70;
            double tea = 1.20;

            if (profession == "Athlete")
            {
                price = water * quantity;
            }
            else if (profession == "Businessman" || profession == "Businesswoman")
            {
                price = coffee * quantity;
            }
            else if (profession == "SoftUni Student")
            {
                price = beer * quantity;
            }
            else
            {
                price = tea * quantity;
            }
            Console.WriteLine($"The {profession} has to pay {price:f2}.");
        }
    }
}