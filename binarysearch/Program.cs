using System;

namespace binarysearch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("input arraysize : ");
            int arraysize = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[arraysize];
            Console.WriteLine("input array : ");
            for (int i = 0; i <arraysize; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("search number : ");
            int search = Convert.ToInt32(Console.ReadLine());
            int result = binarysearch(array, search);
            if (result == -1)
            {
                Console.WriteLine("not fount");
            }
            else
            {
                Console.WriteLine($"fount is {result+1 } index");
            }
        }
        static int binarysearch (int[] a, int x)
        {
            int left, right, mid;
            left = 0;
            right = a.Length - 1;
            while (left <= right)
            {
                mid = (left + right) / 2;
                if (a[mid] == x)
                {
                    return mid;
                }
                if (a[mid] < x)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }
            return -1;
        }
    }
}
