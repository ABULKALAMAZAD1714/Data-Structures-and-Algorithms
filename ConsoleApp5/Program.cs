using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Console.WriteLine("Array size input : ");
             int arraysize = Convert.ToInt32(Console.ReadLine());
             int []array = new int[arraysize];
             Console.WriteLine("artray input :");
             for (int i = 0; i < arraysize; i++)
             {
                 array[i] = Convert.ToInt32(Console.ReadLine());
             }
             Console.WriteLine("scarch number");
             int scarch = Convert.ToInt32(Console.ReadLine());
             int result = linear_scarch(array, scarch);
             if (result == -1)
             {
                 Console.WriteLine("not fount");
             }
             else
             {
                 Console.WriteLine($"fount result is : {result + 1} posit6ion");
             }
         }
         static int linear_scarch(int[] a,int s)
         {
             for (int i = 0; i <a.Length; i++)
             {
                 if (a[i] == s)
                 {
                     return i;
                 }
             }
             return -1; /
            Console.WriteLine("array size input : ");
            int arraysize = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[arraysize];
            Console.WriteLine("array input : ");
            for (int i = 0; i < arraysize; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("scarch number : ");
            int scarch = Convert.ToInt32(Console.ReadLine());
            int result = binarry_scarch(array, scarch);

            if(result == -1)
            {
                Console.WriteLine("Not found");
            }
            else
            {
                Console.WriteLine($"Found in {result+1} position");
            }
        }
        static int binarry_scarch(int[] array, int search)
        {
            int left = 0, right = array.Length-1, mid;
            while (left <= right)
            {
                mid = (left + right) / 2;
                if (array[mid] == search)
                {
                    return mid;
                }
                if (array[mid] > search)
                {
                    right = mid - 1;
                }
                else
                {
                    left = mid + 1;
                }
            }
            return -1;
            Console.WriteLine("array size input : ");
            int arraysize = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[arraysize];
            Console.WriteLine("array input : ");
            for (int i = 0; i < arraysize; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());

            }
            Console.WriteLine("scarch number input : ");
            int scarch = Convert.ToInt32(Console.ReadLine());
            int result = binarry_scarch(array, scarch);
            if (result == - 1)
            {
                Console.WriteLine("not fount");
            }
            else
            {
                Console.WriteLine($"fount result is : {result + 1} position");
            }
        }
        static int binarry_scarch(int[] array, int scarch)
        {
            int left = 0, right = array.Length - 1, mid;
            while (left<=right)
            {
                mid = (left + right) / 2;
                if(array[mid] == scarch)
                {
                    return mid;
                }
                if(array[mid] > scarch)
                {
                    right = mid - 1;
                }
                else
                {
                    left = mid + 1;
                }
            }
            return -1;
            Console.WriteLine("array size input : ");
            int arraysize = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[arraysize];
            Console.WriteLine("array input : ");
            for (int i = 0; i < arraysize; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());

            }
            Console.WriteLine("scarch number input : ");
            int scarch = Convert.ToInt32(Console.ReadLine());
            int result = binarry_scarch(array, scarch);
            if (result == -1)
            {
                Console.WriteLine("not fount");
            }
            else
            {
                Console.WriteLine($"fount is result : {result + 1} position");
            }
        }
        static int binarry_scarch(int []array,int scarch)
        {
            int left = 0, right = array.Length - 1, mid;
            while (left<=right)
            {
                mid = (left + right) / 2;
                if (array[mid] == scarch)
                {
                    return mid;
                }
                if (array[mid] > scarch)
                {
                    right =mid- 1;
                }
                else
                {
                    left = mid + 1;
                }
            }
            return -1;
            Console.WriteLine("array saze input : ");
            int arraysize = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[arraysize];
            Console.WriteLine("array input : ");
            for (int i = 0; i < arraysize; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("scarch number : ");
            int scarch = Convert.ToInt32(Console.ReadLine());
            int result = binarry_scarch(array, scarch);
            if (result == 1)
            {
                Console.WriteLine("not fount");
            }
            else
            {
                Console.WriteLine($"fount result is : {result+1} position");
            }
        }
        static int binarry_scarch(int[]array,int scarch)
        {
            int left = 0, right = array.Length - 1, mid;
            while (left<=right)
            {
                mid = (left + right) / 2;
                if (mid == scarch)
                {
                    return mid;
                }
                if (array[mid] > scarch)
                {
                    right = mid - 1;
                }
                else
                {
                    left = mid + 1;
                }
            }
            return -1; 
            Console.WriteLine("array size input : ");
            int arraysize = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[arraysize];
            Console.WriteLine("array input : ");
            for (int i = 0; i < arraysize; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());

            }
            Console.WriteLine("scarch input : ");
            int scarch = Convert.ToInt32(Console.ReadLine());
            int result = linear_scarch(array, scarch);
            if (result == -1)
            {
                Console.WriteLine("not fount");
            }
            else
            {
                Console.WriteLine($"fount is result : {result + 1} p0sition");
            }

        }
        static int linear_scarch(int[]a,int scarch)
        {
            for (int i = 0; i <a. Length; i++)
            {
                if (a[i] == scarch)
                {
                    return i;
                }
            }
            return -1;*/
            Console.WriteLine("array size input : ");
            int arraysize = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[arraysize];
            Console.WriteLine("array input : ");
            for (int i = 0; i < arraysize; i++)

            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            bubble_sort(array);
            Console.WriteLine("After sorting : ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"{array[i]}");
            }
        }
        static void bubble_sort(int[]a )
        {
            for (int i = 0; i <a.Length ; i++)
            {
                for (int j = 0; j < a.Length-i-1; j++)
                {
                    if (a[j] > a[j + 1])
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
