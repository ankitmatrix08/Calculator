using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator;

namespace DateParserTest
{
    class Program
    {
        static void Main(string[] args)
        {
            string format = "dd/MM/yyyy hh:mm:ss";
            DateTime promiseDate;
            CultureInfo provider = CultureInfo.InvariantCulture;

            Calculator.Calculator c = new Calculator.Calculator();
            int x = c.Multiply(2, 3);
            var y= c.Division(10, 5);

            if (DateTime.TryParseExact("03/22/2015 00:00:00", format, provider, DateTimeStyles.None, out promiseDate))
            {
                Console.Write("Paresed Date:- " + promiseDate);
            }
            else
            {
                Console.Write("UN-Paresed Date:- " + promiseDate);
            }

            Console.ReadLine();

        }
    }
}

