using System;

namespace ConsoleApp8
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
            Console.WriteLine("scarch number input : ");
            int scarch = Convert.ToInt32(Console.ReadLine());
           int Result = binarry_scarch(array,scarch);
           if (Result==-1)
            {
                Console.WriteLine("not fount");

            }
            else
            {
                Console.WriteLine($"fount in : {Result + 1} position");
            }
        }
        static int binarry_scarch(int [] array ,int scarch)
        {
            int left=0, right=array.Length-1, mid;
            while (left <= right)
            {
                mid = (left + right) / 2;
                if (array[mid] == scarch)
                   
                {
                    return mid;
                }
                if (array[mid]>scarch)
                {
                    right = mid - 1;

                }
                else
                {
                    left = mid + 1;
                }
              

            }
            return -1;

        }
         
    }
}
