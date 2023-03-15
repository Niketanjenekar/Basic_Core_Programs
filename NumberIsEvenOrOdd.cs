using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class NumberIs_EvenOrOdd
    {
        public static void NumberisEvenorOdd()
        {
            int num, even, odd;
            Console.WriteLine("Please enter the Number : ");
            num = Convert.ToInt32(Console.ReadLine());

            even = num % 2;
            odd = num % 3;

            if (num == even)
            {
                Console.WriteLine("The number is Even");

            }else
            {
                Console.WriteLine("the number is Odd");
            }
        }
    }
}
