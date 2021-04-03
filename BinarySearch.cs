using System;

namespace Algorithms
{
    class BinarySearch
    {
        public int GetBinarySearch(int[] array, int number)
        {
            int leftBorder = 0;
            int rightBorder = array.Length;
            int middleIndex;

            while(rightBorder - leftBorder != 1)
            {
                middleIndex = (rightBorder + leftBorder) / 2;
                if (number > array[middleIndex])
                {
                    leftBorder = middleIndex;
                }
                else if (number < array[middleIndex])
                {
                    // 1 3 4 5 7 8
                    rightBorder = middleIndex;
                }
                else return middleIndex;
            }
            return -1;            
        }
    }
}