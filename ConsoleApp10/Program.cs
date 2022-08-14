using System;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any lower case input : ");
            char upper = Convert.Tochar(Console.ReadLine());
            Console.WriteLine($"upper case :{upper+32}");

        }
    }
}
