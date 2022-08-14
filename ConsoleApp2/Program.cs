using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("arraysize input : ");
            int arraysize = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[arraysize];
            Console.WriteLine("array input : ");
            for (int i = 0; i < arraysize; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("search number : ");
            int search = Convert.ToInt32(Console.ReadLine());
            int result = linearSearch(array, search);
            if (result == -1)
            {
                Console.WriteLine("not fount");
            }
            else
            {
                Console.WriteLine($" fount is {result + 1 } index ");
            }
                 

        }
        static int linearSearch(int[] a, int s)
        {
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == s)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
