using System;

namespace Algorithms
{
    class FastPow
    {
        public double GetFastPow(double number, int basePow)
        {
            if (basePow == 0)
                return 1;
            else if (basePow % 2 != 0)
                return number * GetFastPow(number, --basePow);
            else
                return GetFastPow(number * number, basePow / 2);
        }
    }
}