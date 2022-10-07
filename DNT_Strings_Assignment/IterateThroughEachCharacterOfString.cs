using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNT_Strings_Assignment
{
    internal class IterateThroughEachCharacterOfString
    {
        public static void Main()
        {
            string str ;

            Console.WriteLine("Please Enter the string..");
            str = Console.ReadLine();
            Console.WriteLine();
            
            Console.WriteLine("Individual characters from given string:");

          
            for (int i = 0; i < str.Length; i++)
            {
                Console.Write(str[i] + "  ");
            }
        }
    }
}
