using System;

namespace _09._Count_the_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;

            while (true)
            {
                try
                {
                    string input = Console.ReadLine();
                    int number = int.Parse(input);
                    count++;
                }
                catch (Exception)
                {
                    Console.WriteLine($"{count}");
                    break;             
                }
            }
        }
    }
}