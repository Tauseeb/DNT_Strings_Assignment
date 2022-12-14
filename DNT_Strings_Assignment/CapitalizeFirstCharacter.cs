using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNT_Strings_Assignment
{
    internal class CapitalizeFirstCharacter
    {
        static string CapitalizeFirstLetter(string value)
        {
            value = value.ToLower();
            char[] array = value.ToCharArray();
 
            if (array.Length >= 1)
            {
                if (char.IsLower(array[0]))
                {
                    array[0] = char.ToUpper(array[0]);
                }
            }
           
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i - 1] == ' ')
                {
                    if (char.IsLower(array[i]))
                    {
                        array[i] = char.ToUpper(array[i]);
                    }
                }
            }
            return new string(array);
        }
        public static void Main()
        {
            Console.Write("Enter The String Need to be Capitalized: ");
            string str = Console.ReadLine();

            string titleCase = CapitalizeFirstLetter(str);
      
            Console.WriteLine("Capitalized String: " + titleCase);

            
            Console.ReadKey();
        }

       
    }
}
