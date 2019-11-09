using System;

namespace _11._5_Different_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            if (a + 5 > b)
            {
                Console.WriteLine("No");
                return;
            }

            for (int i = a; i <= b - 4; i++)
            {
                for (int j = a + 1; j <= b - 3; j++)
                {
                    for (int k = a + 2; k <= b - 2; k++)
                    {
                        for (int m = a + 3; m <= b - 1; m++)
                        {
                            for (int g =  a + 4 ; g <= b; g++)
                            {
                                if (a <= i && i < j && j < k && k < m && m < g && g <= b)
                                {
                                    Console.WriteLine($"{i} {j} {k} {m} {g}");
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}