using System;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            // =================
            // R E C U R S I O N
            // =================

            // -------------
            // Get Factorial
            // -------------
            // FactorialRecursion fact = new FactorialRecursion();
            // System.Console.WriteLine(fact.GetFactorial(5));


            // ------------
            // Get Fast Pow
            // ------------

            FastPow fastPow = new FastPow();
            System.Console.WriteLine(fastPow.GetFastPow(2, 10));



            // ===========
            // A R R A Y S
            // ===========

            // int arraySize = 30;
            // int[] array = new int[arraySize];
            // Random rnd = new Random();

            // for(int i = 0; i < arraySize; i++)
            //     array[i] = rnd.Next(0, 32);

            // Console.WriteLine("Unsorted array");
            // for(int i = 0; i < array.Length; i++)
            //     Console.Write(array[i] + " ");

            // Console.WriteLine();


            // ----------
            // Radix Sort
            // ----------
            // RadixSort radixSort = new RadixSort();
            // radixSort.GetRadixSort(array);


            // --------
            // Bogosort
            // --------
            // Bogosort bogosort = new Bogosort();
            // bogosort.GetBogosort(array);


            // -------------
            // Counting Sort
            // -------------
            // CountingSort counting = new CountingSort();
            // counting.GetCountingSort(array); 


            // --------------
            // Insertion Sort
            // --------------
            // InsertionSort insertion = new InsertionSort();
            // insertion.GetInsertionSearch(array);


            // ----------- 
            // Choise Sort
            // -----------
            // ChoiseSort choise = new ChoiseSort();
            // choise.GetChoiseSort(array);

            // Console.WriteLine("Sorted array");
            // for(int i = 0; i < arraySize; i++)
            //     Console.Write(array[i] + " ");

            // Console.WriteLine();


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
