using System;

namespace Algorithms
{
    class InsertionSort
    {
        public void GetInsertionSearch(int[] array)
        {
            for(int i = 1; i < array.Length; i++)
            {
                int pos = i;
                while(pos > 0 && array[pos] < array[pos - 1])
                {
                    int tmp = array[pos];
                    array[pos] = array[pos - 1];
                    array[pos - 1] = tmp;
                    pos--;
                }
            }
        }
    }
}