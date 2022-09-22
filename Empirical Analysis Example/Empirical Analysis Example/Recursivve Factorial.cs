using System;
using System.Collections.Generic;
using System.Text;

namespace Empirical_Analysis_Example
{
    class Recursivve_Factorial
    {
        public int WorkOutFactorial(int n)
        {
            if (n == 1)
                return 1;
            return n * WorkOutFactorial(n - 1);
        }
    }
}
