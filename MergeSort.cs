namespace Algorithms
{
    class MergeSort
    {
        public int[] GetMergeSort(int[] array)
        {
            if (array.Length < 2)
            {
                return array;
            }
            else
            {
                int[] arrayA = new int[array.Length/2];
                for (int i = 0; i < arrayA.Length; i++)
                {
                    arrayA[i] = array[i];
                }
                
                int[] arrayB = new int[array.Length - array.Length/2];
                for (int i = 0; i < arrayB.Length; i++)
                {
                   arrayB[i] = array[i + arrayA.Length];
                }

                MergeSort mergeSortArrayA = new MergeSort();
                int[] sortedArrayA = mergeSortArrayA.GetMergeSort(arrayA);
                MergeSort mergeSortArrayB = new MergeSort();
                int[] sortedArrayB = mergeSortArrayB.GetMergeSort(arrayB);
                
                int pointerA = 0;
                int pointerB = 0;
                int pointerMergeArray = 0;

                while (pointerA < sortedArrayA.Length && pointerB < sortedArrayB.Length) 
                {
                    if (sortedArrayA[pointerA] > sortedArrayB[pointerB])
                    {
                        array[pointerMergeArray] = sortedArrayB[pointerB];
                        pointerMergeArray++;
                        pointerB++;
                    }
                    else if (sortedArrayA[pointerA] < sortedArrayB[pointerB])
                    {
                        array[pointerMergeArray] = sortedArrayA[pointerA];
                        pointerMergeArray++;
                        pointerA++;
                    }
                    else if (sortedArrayA[pointerA] == sortedArrayB[pointerB])
                    {
                        array[pointerMergeArray] = sortedArrayA[pointerA];
                        pointerMergeArray++;
                        pointerA++;
                        array[pointerMergeArray] = sortedArrayB[pointerB];
                        pointerMergeArray++;
                        pointerB++;
                    }
                }
                
                if (pointerA == sortedArrayA.Length)
                {
                    while (pointerB < sortedArrayB.Length)
                    {
                        array[pointerMergeArray] = sortedArrayB[pointerB];
                        pointerMergeArray++;
                        pointerB++;
                    }
                }
                else if (pointerB == sortedArrayB.Length)
                {
                    while (pointerA < sortedArrayA.Length)
                    {
                        array[pointerMergeArray] = sortedArrayA[pointerA];
                        pointerMergeArray++;
                        pointerA++;
                    }
                }
            }
            return array;
        }
    }
} 