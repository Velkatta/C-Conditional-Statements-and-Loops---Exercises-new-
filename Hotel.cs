using System;

namespace _04._Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nightsCount = int.Parse(Console.ReadLine());

            double priceStudio = 0;
            double priceDouble = 0;
            double priceSuite = 0;

            switch (month)
            {
                case "May":
                case "October":
                    priceStudio = 50;
                    priceDouble = 65;
                    priceSuite = 75;
                    if (nightsCount > 7)
                    {
                        priceStudio *= 0.95;
                    }
                    break;
                case "June":
                case "September":
                    priceStudio = 60;
                    priceDouble = 72;
                    priceSuite = 82;
                    if (nightsCount > 14)
                    {
                        priceDouble *= 0.90;
                    }
                    break;
                case "July":
                case "August":
                case "December":
                    priceStudio = 68;
                    priceDouble = 77;
                    priceSuite = 89;
                    if (nightsCount > 14)
                    {
                        priceSuite *= 0.85;
                    }
                    break;

                default:
                    break;
            }

            if ((nightsCount > 7) && (month == "September" || month == "October"))
            {
                priceStudio *= (1 - (1.0 / nightsCount));
            }
            Console.WriteLine($"Studio: {priceStudio * nightsCount:f2} lv.");
            Console.WriteLine($"Double: {priceDouble * nightsCount:f2} lv.");
            Console.WriteLine($"Suite: {priceSuite * nightsCount:f2} lv.");
        }
    }
}