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
            }else if (b == 1)
            {
                return a;
            }

            int result = 0;
            for (int i = 1; i < b; i++)
            {
                result += a * a;
            }
            return result;
        }
    }
}
