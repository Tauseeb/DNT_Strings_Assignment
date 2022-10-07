using System;

namespace DNT_Strings_Assignment
{
    internal class CompareStrings
    {
        public static void Main( )
        {

            string str1 = "C#";
            string str2 = "Asp.net";
            string str3 = "Assignment";

            int result;
        
            result = String.Compare(str1, str2);
            Console.WriteLine(result);       
            result = String.Compare(str1, str3);
            Console.WriteLine(result);   
            result = String.Compare(str3, str1);
            Console.WriteLine(result);

            Console.ReadLine();
        }
    }
}