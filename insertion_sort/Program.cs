using System;

namespace insertion_sort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("array size i8nput : ");
            int arraysize = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[arraysize];
            Console.WriteLine("array input : ");
            for (int i = 0; i < arraysize; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());

            }
            insertion_sort(array);
            Console.WriteLine("After sorting : ");
            for (int i = 0; i <array.Length; i++)
            {
                Console.WriteLine($"{array[i]}");
            }
        }
        static void insertion_sort(int[] array)
        {
            int item, j;
            for (int i = 1; i < array.Length; i++)
            {
                item = array[i];
                j = i - 1;
                while (j>=0 && array[j]>item)
                {
                    array[j + 1] = array[j];
                    j = j - 1;

                }
                array[j + 1] = item;
            }
        }
    }
}
