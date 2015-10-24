using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceCalculator
{
    public class Calculator
    {
        public int operatorPlus(int a, int b)
        {
            return a + b;
        }

        public int operatorMinus(int a, int b)
        {
            return a - b;
        }

        public int operatorMultiply(int a, int b)
        {
            return a * b;
        }

        public int operatorDivide(int a, int b)
        {
            return a / b;
        }

        public Double operatorSquare(int a, int b)
        {
            if (b == 0)
            {
                return 1;
            }

            int result = 1;
            for (int i = 0; i < b; i++)
            {
                result = result * a;
            }
            return result;
        }
    }
}
