using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swapping
{
    public class swap
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter first number:");
            double firstnumber = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second number:");
            double secondnumber = double.Parse(Console.ReadLine());
            firstnumber = firstnumber + secondnumber;
            secondnumber = firstnumber - secondnumber;
            firstnumber = firstnumber - secondnumber;
            Console.WriteLine("first number is :{0}", firstnumber);
            Console.WriteLine("second number is :{0}", secondnumber);
            Console.ReadLine();
        }
    }
}
