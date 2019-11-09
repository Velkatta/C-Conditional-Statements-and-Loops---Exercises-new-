using System;

namespace _03._Restaurant_Discount
{
    class Program
    {
        static void Main(string[] args)
        {
            int groupSize = int.Parse(Console.ReadLine());
            string package = Console.ReadLine();

            double price = 0;
            string hall = string.Empty;

            if (groupSize <= 50)
            {
                price += 2500;
                hall = "Small Hall";
            }
            else if (groupSize <= 100)
            {
                price += 5000;
                hall = "Terrace";
            }
            else if (groupSize <= 120)
            {
                price += 7500;
                hall = "Great Hall";
            }
            else
            {
                Console.WriteLine("We do not have an appropriate hall.");
                return;
            }

            switch (package)
            {
                case "Normal":
                    price += 500;
                    price *= 0.95;
                    break;
                case "Gold":
                    price += 750;
                    price *= 0.90;
                    break;
                case "Platinum":
                    price += 1000;
                    price *= 0.85;
                    break;

                default:
                    break;
            }
            double totalPrice = price / groupSize;

            Console.WriteLine($"We can offer you the {hall}");
            Console.WriteLine($"The price per person is {totalPrice:f2}$");
        }
    }
}