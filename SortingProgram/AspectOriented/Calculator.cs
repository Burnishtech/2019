using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AspectOriented
{
    public class Calculator : ICalculator
    {
        int ICalculator.Add(int val1, int val2)
        {
            return val1 + val2;
        }

        int ICalculator.Division(int val1, int val2)
        {
            return val1 / val2;
        }

        int ICalculator.Multiplication(int val1, int val2)
        {
            return val1 * val2;
        }

        int ICalculator.Subtract(int val1, int val2)
        {
            return val1 - val2;
        }
    }
}