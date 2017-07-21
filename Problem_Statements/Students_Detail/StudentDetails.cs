using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students_Detail
{
   public class StudentDetails
    {
        static void Main(string[] args)
        {
            StudentDetails p = new StudentDetails();
            p.Display();
        }

        void Display()
        {
            Console.WriteLine("Enter name of the student :");
            string name = Console.ReadLine();
            Console.WriteLine("enter class:");
            int Class = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter section:");
            string section = Console.ReadLine();
            Console.WriteLine("Enter roll number:");
            int roll_number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter university name:");
            string university_name = Console.ReadLine();
            Console.WriteLine("Enter age of the student:");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" Name of the student : {0}", name);
            Console.WriteLine(" Class of the student : {0}", Class);
            Console.WriteLine(" Age of the student : {0}", age);
            Console.WriteLine(" Section of the student : {0}", section);
            IsRollnumber(roll_number);
            Console.WriteLine(" Roll number of the student : {0}", roll_number);
            Console.WriteLine(" University of the student : {0}", university_name);
            Console.ReadLine();





        }
        public static bool IsRollnumber(int roll_number)
        {
            if (roll_number.ToString().Length != 10)
            {
                return false;
            }

            else
                return true;
        }
    }
}
