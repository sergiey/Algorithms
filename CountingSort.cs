using System;

namespace Algorithms
{
    class CountingSort
    {
        public void GetCountingSort(int[] array)
        {
            int maxNumber = array[0];
            for(int i = 1; i < array.Length; i++)
            {
                if(array[i] > maxNumber)
                {
                    maxNumber = array[i];
                }
            }

            int[] counterArray = new int[maxNumber + 1];
            for(int i = 0; i < array.Length; i++)
            {
                counterArray[array[i]] += 1;
            }

            int leftBorder = 0;
            int rightBorder = counterArray[0];

            for(int i = 0; i <= maxNumber; i++)
            {
                for(int j = leftBorder; j < rightBorder; j++)
                {
                    array[j] = i;
                }
                if(i < counterArray.Length - 1)
                {
                   leftBorder = rightBorder;
                   rightBorder += counterArray[i + 1];
                }
            }
        }
    }
}