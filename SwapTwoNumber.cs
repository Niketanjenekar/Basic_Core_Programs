using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class SwapTwoNumber
    {
        public static void DisplaySwapedNumbers()
        {
            int a = 5,b = 10;
            Console.WriteLine("Before Swap a = " + a + " and b = " + b);
            a = a * b;
            b = a / b;
            a = a / b;
            Console.WriteLine("After a = " + a + " and b = " + b);
        }
    }
}
