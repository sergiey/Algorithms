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
                // 5 2 1 7
                // 2 5 1 7
                // 1 5 2 7 

            }
        }

    }

}