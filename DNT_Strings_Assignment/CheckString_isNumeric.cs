using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNT_Strings_Assignment
{
    internal class CheckString_isNumeric
    {
        public static void Main()
        {

            string str;
            Console.WriteLine("Please Enter A Value..");
            str=Console.ReadLine();

            bool numeric = true;

            try
            {
                double num = Convert .ToDouble(str);
            }
            catch (Exception e)
            {
                numeric = false;
            }

            if (numeric)
            {
                Console.WriteLine(str + " is a number");
            }
              
           else
           {
                Console.WriteLine(str + " is not a number");
           }
             

            Console.ReadLine();
        }
    }
}
