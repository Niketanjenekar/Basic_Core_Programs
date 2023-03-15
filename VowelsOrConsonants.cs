using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class VowelsOrConsonants
    {
        public static void VowelsorConsonants()
        {
            char ch;
            
            Console.WriteLine("Please Enter the Character : ");
            ch = Convert.ToChar(Console.ReadLine());

            if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u' || ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U')
            {
                Console.WriteLine("The Letter " + ch + " you entered is a Vowel");
            }
            else if((ch >= 'A' && ch <= 'Z') || (ch >= 'a' && ch <= 'z'))
            {

                Console.WriteLine("The Letter" + ch + " you entered is a consonant");
            }



        }
        

    }
}
