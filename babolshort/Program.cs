using System;

namespace babolshort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("array size input : ");
            int arraysize = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[arraysize];
            Console.WriteLine("array input : ");
            for (int i = 0; i < arraysize; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            bubble_sort(array);
            Console.Write("After sorting : ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]}\t");
            }
        }
        static void bubble_sort(int []a)
        {
            for ( int i = 0; i < a.Length; i++)
            {
                for ( int j = 0; j < a.Length-i-1; j++)

                {
                  if( a[j] > a[j + 1])
                    {
                        int temp = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = temp;
                    }
                }
            }
        }
    }
}
