using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidatePin
{
    public class ValidatePinno
    {
        public static bool IsPin(int pin)
        {
            if (pin.ToString().Length != 7)
            {
                return false;
            }

            else
                return true;
        }
    }
}
