using System;
using System.Collections;

namespace Algorithms
{
    class RadixSort
    {
        public void GetRadixSort(int[] array)
        {
            int[] zeroRankArray = new int[array.Length];
            int[] oneRankArray = new int[array.Length];

            int maxNumber = array[0];
            for(int i = 1; i < array.Length; i++)
                if(array[i] > maxNumber)
                    maxNumber = array[i];

            int maxRank = (int)Math.Log2(maxNumber) + 1;

            for(int i = 0; i < maxRank; i++)
            {
                int zeroRankCounter = 0;
                int oneRankCounter = 0;

                for(int j = 0; j < array.Length; j++)
                {
                    int v = array[j] >> i;
                    if(v % 2 == 0)
                    {
                        zeroRankArray[zeroRankCounter] = array[j];
                        zeroRankCounter++;
                    }
                    else 
                    {
                        oneRankArray[oneRankCounter] = array[j];
                        oneRankCounter++;
                    }
                }

                for(int k = 0; k < zeroRankCounter; k++)
                    array[k] = zeroRankArray[k];

                for(int l = 0; l < oneRankCounter; l++)
                    array[l + zeroRankCounter] = oneRankArray[l];
            }
        }
    }
}