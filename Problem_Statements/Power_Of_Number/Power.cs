using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Power_Of_Number
{
    public class Power
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number  :");
            double number = double.Parse(Console.ReadLine());
            Console.WriteLine("enter power of given number");
            double power = double.Parse(Console.ReadLine());
            double result;
            result = Math.Pow(number, power);
            Console.WriteLine("Power of the given number is {0} ", result);
            Console.ReadLine();

        }
    }
}
