using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspectOriented
{
    interface ICalculator
    {
        int Add(int val1, int val2);
        int Division(int val1, int val2);
        int Multiplication(int val1, int val2);
        int Subtract(int val1, int val2);
    }
}
