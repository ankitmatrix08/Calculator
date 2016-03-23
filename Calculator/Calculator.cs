using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Calculator : Icalculator
    {
        public int Division(int dividend, int divisor)
        {
            return (dividend / divisor);
        }

        public int Multiply(int x, int y)
        {
            return (x * y);
        }

        public int Subtract(int x, int y)
        {
            return (x - y);
        }

        public int Sum(int x, int y)
        {
            return (x + y);
        }
    }
}
