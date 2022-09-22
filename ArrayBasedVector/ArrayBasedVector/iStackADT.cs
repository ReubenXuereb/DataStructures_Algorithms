using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayBasedVector
{
    interface iStackADT
    {
        
        void Push(int value);
        int Pop();
        int Peek();
    }

}
