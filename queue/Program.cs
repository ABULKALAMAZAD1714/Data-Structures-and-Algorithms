using System;

namespace queue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("queue size input : ");
            int queuesize = Convert.ToInt32(Console.ReadLine());
            queue q = new queue(queuesize);
            q.insert(1);
            q.insert(2);
            Console.WriteLine("insert item :");
            q.printqueue();
            q.delete();
            Console.WriteLine("delete item : ");
            q.printqueue();
        }
    }
    class queue
    {
        private int[] elements;
        private int front;
        private int back;
        private int max;


        public queue(int size)
        {
            elements = new int[size];
            front = 0;
            back = -1;
            max = size;


        }
        public void insert(int item)
        {
            if (back == max - 1)
            {
                Console.WriteLine("queue is overflow :");
                return;
            }
            else
            {
                elements[++back] = item;
            }

        }
        public int delete()
        {
            if (front==back-1)
            {
                Console.WriteLine($"queue is empty : ");
                return -1; 

            }
            else
            {
                Console.WriteLine($"queue is delete : {elements[front]}");
                return elements[front++];
            }
            

        }
        public void printqueue()
        {
            if (front==back+1)
            {
                Console.WriteLine(" queue is empty :");

            }
            else
            {
                for (int i = front ; i<= back; i ++)
                {
                    Console.WriteLine($"item : {elements[i]}");
                }
                
            }

        }


    }
    
}   