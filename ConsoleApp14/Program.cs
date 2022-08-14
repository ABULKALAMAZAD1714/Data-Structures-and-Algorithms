using System;

namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {
           // Console.Write("array size input : ");
            //int size = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[5];

            //Console.WriteLine("array input : ");
            //for (int i = 1; i < size; i++)
            //{
            //     array[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //onsole.WriteLine($" size : {}");
            array[1] = 10;
            array[2] = 20;
            array[3] = 30;
            array[4] = 40;
            array[5] = 50;
            for (int i = 0; i <= .Length; i++)
            {
                Console.WriteLine(array[i]);
                //Console.WriteLine($"{array[4]}");

            }
           


        }
    }
}
