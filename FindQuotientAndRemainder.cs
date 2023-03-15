using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class FindQuotientAndRemainder
    {
        public static void FindQuotientandRemainder()
        {
            int Dividend = 35, Divisor = 5;

            int Remainder = Dividend % Divisor;
            int Quotient = Dividend / Divisor;

            Console.WriteLine("The divident {0} and divisor {1} ", Dividend, Divisor);
            Console.WriteLine(" the Quotient " + Quotient+  " and Remainder is " + Remainder);
        }
    }
}
