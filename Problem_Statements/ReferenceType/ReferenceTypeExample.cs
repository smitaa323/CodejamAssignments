using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferenceType
{
    public class ReferenceTypeExample
    {   public int value;
        static void Main(string[] args)
        {
            
            ReferenceTypeExample x = new ReferenceTypeExample();
            x.value = 3;
            ReferenceTypeExample y = new ReferenceTypeExample();
            y = x;
            y.value = 4;
            Console.WriteLine(x.value);//value of x changes as both are pointing to the same location on heap//
            Console.ReadLine();



        }
    }
}
