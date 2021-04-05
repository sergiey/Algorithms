using System;

namespace Algorithms
{
    class Bogosort
    {
        public void GetBogosort(int[] array)
        {
            bool isSorted = false;
            Random rnd = new Random();
            int counter = 0;

            while(!isSorted)
            {
                for(int i = 0; i < array.Length - 1; i++)
                {
                    if(array[i] > array[i + 1])
                    {
                        isSorted = false;
                        break;
                    }
                    else
                        isSorted = true;
                }

                if(isSorted)
                    break;

                for(int i = 0; i < array.Length; i++)
                {
                    int tmp = array[i];
                    int rndIndex = rnd.Next(0, array.Length); 
                    array[i] = array[rndIndex];
                    array[rndIndex] = tmp;
                }
                for(int i = 0; i < array.Length; i++)
                {
                    Console.Write(array[i] + " ");
                }
                System.Console.WriteLine();
                counter++;
                System.Console.WriteLine($"Count of iterations: {counter}");
            }
        }
    }
}