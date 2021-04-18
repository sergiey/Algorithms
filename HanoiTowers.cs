using System;

namespace Algorithms
{
    class HanoiTowers
    {
        public void GetSortHanoiTowers(int fromPin, int toPin, int numberOfDisks)
        {
            if(numberOfDisks == 1)
                System.Console.WriteLine($"Move disk from pin {fromPin} to pin {toPin}");
            else
            {
                int tmp = 6 - toPin - fromPin;
                GetSortHanoiTowers(fromPin, tmp, numberOfDisks - 1);
                GetSortHanoiTowers(fromPin, toPin, 1);
                GetSortHanoiTowers(tmp, toPin, numberOfDisks - 1);
            }   
        }
    }
}