using System;

namespace LinearSearch
{
    public class person
    {
        public string firstname;
        public string lastname;
        public int phon;
        public void Introduce()
        {
            Console.WriteLine($" my name is {firstname} {lastname}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            /* Console.Write("input array size : ");

             int arraySize = Convert.ToInt32(Console.ReadLine());

             int[] array = new int[arraySize];

             Console.WriteLine("input array : ");

             for (int i = 0; i < arraySize; i++)

             {
                 array[i] = Convert.ToInt32(Console.ReadLine());

             }
             Console.Write("search number : ");
             int search = Convert.ToInt32(Console.ReadLine());

             int result = linearSearch(array, search);

             if(result == -1)
             {
                 Console.WriteLine("Not found");
             }
             else
             {
                 Console.WriteLine($"Found in {result + 1} position");
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
            Console.WriteLine("input arraysize : ");
            int arraysize = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[arraysize];
            Console.WriteLine("input array : ");
            for (int i = 0; i < arraysize; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("input search : ");
            int search = Convert.ToInt32(Console.ReadLine());

            int result = LinearSearch(array, search);

            if (result ==-1)
            {
                Console.WriteLine("not fount");
            }
            else
            {
                Console.WriteLine($"fount : {result + 1} position");
            }
        }
        static int LinearSearch(int[] a, int s)
        {
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == s)
                {
                    return i;
                }
            }
            return -1; */

            person ob = new person();
            ob.firstname="abul kalam";
            ob.lastname = "azad";
            ob.Introduce();
            person ob1 = new person();
            ob.firstname = "md selim";
            ob.lastname = "raza";
            ob.Introduce();
        }
 
    }
}
