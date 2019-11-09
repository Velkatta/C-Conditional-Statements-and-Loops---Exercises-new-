using System;

namespace _13._Game_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());

            int count = 0;

            for (int i = m; i >= n; i--)
            {
                for (int k = m; k >= n; k--)
                {
                    if (i + k == magicNumber)
                    {
                        Console.WriteLine($"Number found! {i} + {k} = {magicNumber}");
                        return;
                    }
                    count++;
                }
            }
            Console.WriteLine($"{count} combinations - neither equals {magicNumber}");
        }
    }
}