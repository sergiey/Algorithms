using System;

namespace Algorithms
{
    class FactorialRecursion
    {
        public double GetFactorial(double number)
        {
            if(number == 0)
                return 1;
            return number * GetFactorial(number - 1);
        }
    }


}