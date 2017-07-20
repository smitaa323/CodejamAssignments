using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Reverse
{
   public class ReverseString

    {
        static void Main(string[] args)
        {  Console.WriteLine("enter a string:");
            string text = Console.ReadLine();
            char[] cArray = text.ToCharArray();
            for (int i = 0; i < cArray.Length / 2; i++)
            {
                char temp = cArray[i];
                cArray[i] = cArray[cArray.Length - i - 1];
                cArray[cArray.Length - i - 1] = temp;
               
            } Console.WriteLine(cArray);
          
            Console.ReadLine();

        }
       
        }
    }

