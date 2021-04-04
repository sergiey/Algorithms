using System;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            int arraySize = 20;
            int[] array = new int[arraySize];
            Random rnd = new Random();

            for(int i = 0; i < arraySize; i++)
            {
                array[i] = rnd.Next(0, 11);
            }

            System.Console.WriteLine("Unsorted array");
            for(int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }

            Console.WriteLine();

            // -------------
            // Counting Sort
            // -------------

            CountingSort counting = new CountingSort();
            counting.GetCountingSort(array); 

            System.Console.WriteLine("Sorted array");
            for(int i = 0; i < arraySize; i++)
            {
                Console.Write(array[i] + " ");
            }
            System.Console.WriteLine();


            // --------------
            // Insertion Sort
            // --------------
            
            // InsertionSort insertion = new InsertionSort();
            // insertion.GetInsertionSearch(array);

            // System.Console.WriteLine("Sorted array");
            // for(int i = 0; i < array.Length; i++)
            // {
            //     Console.Write(array[i] + " ");
            // }
            // System.Console.WriteLine();

            // ----------- 
            // Choise Sort
            // -----------

            // ChoiseSort choise = new ChoiseSort();
            // choise.GetChoiseSort(array);

            // System.Console.WriteLine("Sorted array");
            // for(int i = 0; i < arraySize; i++)
            // {
            //     Console.Write(array[i] + " ");
            // }
            // System.Console.WriteLine();


            // -------------
            // Binary Search
            // -------------
            // System.Console.WriteLine("Type number for search");
            
            // int number = Int32.Parse(Console.ReadLine()); 

            // BinarySearch binarySearch = new BinarySearch();
            // int index = binarySearch.GetBinarySearch(array, number);
            // if(index == -1)
            // {
            //     System.Console.WriteLine($"Number {number} not contained in the array");
            // }
            // else
            // {
            //     System.Console.WriteLine($"Index of number {number} in the array is {index}");
            // }
        }
    }
}
