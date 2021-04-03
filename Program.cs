using System;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            int arraySize = 100;
            int[] array = new int[arraySize];
            Random rnd = new Random();

            for(int i = 0; i < arraySize; i++)
            {
                array[i] = rnd.Next(1, 100);
            }

            System.Console.WriteLine("Unsorted array");
            for(int i = 0; i < arraySize; i++)
            {
                Console.Write(array[i] + " ");
            }

            Console.WriteLine();

            ChoiseSort choise = new ChoiseSort();
            choise.GetChoiseSort(array);

            System.Console.WriteLine("Sorted array");
            for(int i = 0; i < arraySize; i++)
            {
                Console.Write(array[i] + " ");
            }


        }
    }
}
