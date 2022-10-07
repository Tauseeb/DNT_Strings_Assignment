using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNT_Strings_Assignment
{
    internal class StringPalindrome
    {
        public static void Main()
        {
            string str, rvsStr = string.Empty;
            Console.Write("Enter a string : ");
            str = Console.ReadLine();
            if (str != null)
            {
                for (int i = str.Length - 1; i >= 0; i--)
                {
                    rvsStr += str[i].ToString();
                }
                if (rvsStr == str)
                {
                    Console.WriteLine("String is Palindrome  = {0} ", str);
                }
                else
                {
                    Console.WriteLine("String is not Palindrome  = {0} ", str);
                }
            }
            Console.ReadLine();
        }
    }
}
