using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class LargestNumbers
    {
        public static void FindLargest()
        {
            int num1, num2, num3;
            Console.WriteLine("Find the Largest Number");

            Console.WriteLine("input the 1st Number");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("input the 2ndNumber");
            num2= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("input the 3rd Number");
            num3=Convert.ToInt32(Console.ReadLine());

            if(num1 > num2)
            {
                if (num1 > num3)
                {
                    Console.WriteLine("The 1st number is the greatest among the three");


                }
                else
                {
                    Console.WriteLine("The third number is The Largest Number");

                }
            }else if(num2 > num3)
            {
                Console.WriteLine("The 2nd number is the Largest Number");

            }
            else
            {
                Console.WriteLine("The 3rd number is the Larget Number");

            }

        }
    }
}
