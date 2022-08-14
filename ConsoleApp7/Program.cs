using System;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  Console.WriteLine("array size input : ");
              int arraysize = Convert.ToInt32(Console.ReadLine());
              int[] array = new int[arraysize];
              Console.WriteLine("array input ; ");
              for (int i = 0; i < arraysize; i++)
              {
                  array[i] = Convert.ToInt32(Console.ReadLine());
              }

              bubble_sort(array);
              Console.WriteLine("after sorting : ");
              for (int i = 0; i <array.Length; i++)
              {
                  Console.WriteLine($"{array[i]}");
              }
          }
           static void bubble_sort(int[] array)
          {
              int i, j, tem;
              for ( i = 0; i < array.Length; i++)
              {
                  for ( j = 0; j < array.Length-i-1; j++)
                  {
                      if (array[j]>array[j+1])
                      {
                          tem = array[j];
                          array[j] = array[j + 1];
                          array[j + 1] = tem;

                      }

                  }

              }*/
            Console.WriteLine("array size input : ");
            int arraysize = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[arraysize];
            Console.WriteLine("array input : ");
            for (int i = 0; i < arraysize; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());

            }
            selection_sort(array);
            Console.WriteLine("After sorting : ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"{array[i]}");

            }
        }
        static void selection_sort(int[] array)
        {
            int temp, index_min;
            for (int i = 0; i < array.Length - 1; i++)
            {
                index_min = i;
                for (int j = i+1; j < array.Length; j++)
                {
                    if (array[j] < array[index_min])
                    {
                        index_min = j;

                    }


                }
                if (index_min != i)
                {
                    temp = array[i];
                    array[i] = array[index_min];
                    array[index_min] = temp;


                }


            }
        }

    }
}
