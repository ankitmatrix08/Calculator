using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    interface Icalculator
    {
        int Sum(int x, int y);
        int Subtract(int x, int y);

        int Multiply(int x, int y);

        int Division(int dividend, int divisor);
    }
}
