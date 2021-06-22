namespace Algorithms
{
    class Quicksort
    {
        public int[] GetQuickSort(int[] array)
        {
            if (array.Length < 2)
                return array;

            int supportElement = array[0];
            int[] tempLesserArray = new int[array.Length];
            int[] tempLargerArray = new int[array.Length];
            int lesserArrayPointer = 0;
            int largerArrayPointer = 0;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < supportElement)
                {
                    tempLesserArray[lesserArrayPointer] = array[i];
                    lesserArrayPointer++;
                }
                else if (array[i] >= supportElement)
                {
                    tempLargerArray[largerArrayPointer] = array[i];
                    largerArrayPointer++;
                }
            }

            int[] lesserArray = new int[lesserArrayPointer];
            for (int i = 0; i < lesserArray.Length; i++)
                lesserArray[i] = tempLesserArray[i];
            Quicksort sortLesserArray = new Quicksort();
            int[] sortedLesserArray = sortLesserArray.GetQuickSort(lesserArray);

            int[] largerArray = new int[largerArrayPointer];
            for (int i = 0; i < largerArray.Length; i++)
                largerArray[i] = tempLargerArray[i];
            Quicksort sortLargerArray = new Quicksort();
            int[] sortedLargerArray = sortLargerArray.GetQuickSort(largerArray);
            
            for (int i = 0; i < sortedLesserArray.Length; i++)
                array[i] = sortedLesserArray[i];
            
            array[sortedLesserArray.Length] = supportElement;
            
            for (int i = sortedLesserArray.Length + 1; i < array.Length; i++)
                array[i] = sortedLargerArray[i - sortedLesserArray.Length - 1];
            
            return array;
        }
    }
}