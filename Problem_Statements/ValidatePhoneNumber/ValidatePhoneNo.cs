using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ValidatePhoneNumber
{
    public class ValidatePhoneNo
    {


        public static bool IsPhoneNumber(string phone_number)
        {
            return Regex.Match(phone_number, @"^(\+[0-9]{9})$").Success;
        }

    }
}
