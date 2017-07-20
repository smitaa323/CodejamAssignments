using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;




namespace Users_Details
{
    public class Userdetails
    {
        static void Main(string[] args)
        {

            
            Console.WriteLine("enter name:");
            string name = Console.ReadLine();
            Console.WriteLine("enter phone number:");
            string phone_number = Console.ReadLine();
            Console.WriteLine("enter city:");
            string city = Console.ReadLine();
            Console.WriteLine("enter pin:");
            int pin = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter house number");
            int house_number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Name : {0}", name);
            Console.WriteLine("house number is : {0}", house_number);
            IsPhoneNumber(phone_number);
            Console.WriteLine("phone number : {0}", phone_number);
            Console.WriteLine("city : {0} ", city);
            IsPin(pin);
            Console.WriteLine("pin is : {0}", pin);
            Console.ReadLine();


        }
        public static bool IsPhoneNumber(string phone_number)
        {
            return Regex.Match(phone_number, @"^(\+[0-9]{9})$").Success;
        }

        public static bool IsPin(int pin)
        {
            if (pin.ToString().Length != 6)
            {
                return false;
            }

            else
                return true;
        }



    }
    }

