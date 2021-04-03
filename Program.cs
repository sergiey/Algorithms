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

            // Choise Sort
            ChoiseSort choise = new ChoiseSort();
            choise.GetChoiseSort(array);

            System.Console.WriteLine("Sorted array");
            for(int i = 0; i < arraySize; i++)
            {
                Console.Write(array[i] + " ");
            }
            System.Console.WriteLine();

            System.Console.WriteLine("Type number for search");
            int number = Int32.Parse(Console.ReadLine()); 

            // Binary Search
            BinarySearch binarySearch = new BinarySearch();
            int index = binarySearch.GetBinarySearch(array, number);
            if(index == -1)
            {
                System.Console.WriteLine($"Number {number} not contained in the array");
            }
            else
            {
                System.Console.WriteLine($"Index of number {number} in the array is {index}");
            }
        }
    }
}
