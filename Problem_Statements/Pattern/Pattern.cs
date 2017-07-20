using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern
{
   public class Pattern
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pattern for the  given number");
            int number = Convert.ToInt32(Console.ReadLine());
            for(int row = 1; row <= number; row++)
            {
                for(int column =1; column<number-row;column++)

                {
                    Console.Write(" ");
                }
                for(int secondcolumn=1;secondcolumn<=row;secondcolumn++)
                {
                    Console.Write(secondcolumn);
                }
                for( int thirdcolumn = row-1; thirdcolumn>=1;thirdcolumn--)
                {
                    Console.Write(thirdcolumn);

                }
                Console.WriteLine();
               
            }
            Console.ReadLine();
            
              
            }
        }  
    }



    

