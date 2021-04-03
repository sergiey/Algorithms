using System;

namespace Algorithms
{
    class ChoiseSort
    {
        public void GetChoiseSort(int[] array)
        {
            int i = 0;

            while(i < array.Length - 1)
            {
                int j = 1;
                while(j < array.Length - i)
                {
                    if (array[i + j] < array[i])
                    {
                        int tmp = array[i];
                        array[i] = array[i + j];
                        array[i + j] = tmp;
                    }
                    else
                    {
                        j++;
                    }
                }
                i++;
            }
        }

    }
}