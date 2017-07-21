using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathematicalFunction1;
using MathematicalFunction2;

namespace MathematicalFunctions
{
   public class Mathematical
    {
        static void Main(string[] args)
        {
            Mathematical M = new Mathematical();
            AdditionMultiplication AM = new AdditionMultiplication();
            int a = AM.AddTwoValues(10,20);
            int b = AM.AddThreeValues(10, 20, 30);
            int c = AM.MultiplyThreeValue(10, 20, 30);
            SubstractionDivision SD = new SubstractionDivision();
            int x = SD.DivideValues(20, 10);
            int y = SD.SubstractTwoValues(20, 10);
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.ReadLine();


            Console.WriteLine(a);
        }
    }
}
