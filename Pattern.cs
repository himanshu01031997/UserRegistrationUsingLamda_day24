using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationUsingLamdaDay24
{
    public class Pattern
    {
        public const String FIRST_NAME = "^[A-Z]{1}[a-zA-Z]{2,}$";
        public static Func<string, string> checkfirstname = (firstname) =>//func delegate which accept <input ,output>
        {
            Regex regex = new Regex(FIRST_NAME);
            if (regex.IsMatch(firstname))
                return "firstname is valid";
            else
                return "firstname is invalid";

        };

    }
}
