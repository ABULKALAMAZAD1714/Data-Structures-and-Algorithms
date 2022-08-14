using System;
using System.Collections;

namespace ConsoleApp15
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList array = new ArrayList();
            array.Add("kalam");
            array.Add(01303906782);
            array.Add("city university");
            array.Add("hello");
            array.Add(2.73);
            foreach (var data in array)
            {
                Console.WriteLine($"{data}");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            array.RemoveAt(2);
            array.Remove(1);
            array.RemoveRange(3,1);
            foreach (var data in array)
            {
                Console.WriteLine($"{data}");
            }

            
        }
    }
}
