using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 8;
            if (number % 2 == 0)
            {
                Console.WriteLine($"even");
            }
            else
            {
                Console.WriteLine($"odd");
            }
            for (int i = 0; i <= 11; i++)
                
            {
                Console.WriteLine(i);
            }
            int num = 10;
            while (num<=20)
            {
                Console.WriteLine($"start :{num}");
                num++;

            }
        }
    }
}
