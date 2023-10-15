using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Calculate : ICalculate
    {
        public int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public double Divide(int num1, int num2)
        {
            return num1 / num2;
        }

        public int Minus(int num1, int num2)
        {
            return num1 - num2;
        }

        public int Multiply(int num1, int num2)
        {
            return (num1 * num2);
        }
    }
}
