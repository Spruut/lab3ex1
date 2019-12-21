using System;

namespace lab3ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter n");
            int n = Convert.ToInt32(Console.ReadLine());

            Random rnd = new Random();
            int[] arr = new int[n];
            for(int i=0; i < n; i++)
            {
                arr[i] = rnd.Next(-30, 45);
                Console.Write(arr[i]+" ");
            }
            Console.WriteLine();
            int counter = 0;
            Table(arr, counter);
        }
        static void Table(int[] arr, int counter)
        {
            counter = 0;
            for (int i = 0; i < arr.Length / 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write($"{arr[counter]}\t");
                    counter++;
                }
                Console.WriteLine();
            }
            for (int i = 0; i < arr.Length % 10; i++)
            {
                Console.Write($"{arr[counter]}\t");
                counter++;
            }
        }
    }
}
