using System;
using System.Collections.Generic;
using System.Text;

namespace Empirical_Analysis_Example
{
    class Iterative_Factorial
    {
        public int WorkOutFactorial(int n)
        {
            int ans = n;
            for(int i = n-1; i >=1; i--)
            {
                ans = ans * i;
            }
            return ans;
        }
    }
}
