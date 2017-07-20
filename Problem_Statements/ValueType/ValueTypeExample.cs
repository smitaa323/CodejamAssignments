using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueType
{
    public class ValueTypeExample
    {
        static void Main(string[] args)
        {
            int x = new int();
            x = 20;
            int y = new int();
            y = x;
            y = 30;     
            Console.WriteLine( x);
            Console.ReadLine(); // The value of x does not change as x and y have different locations on the stack , hence x retains its value//

        }
    }
}
