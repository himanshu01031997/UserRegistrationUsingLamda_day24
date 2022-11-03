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
        public const String LAST_NAME = "^[A-Z]{1}[a-zA-Z]{2,}$";
        public static Func<string, string> checklastname = (lastname) =>//func delegate which accept <input ,output> nameofdelegate =input => 
        {
            Regex regex = new Regex(LAST_NAME);
            if (regex.IsMatch(lastname))
                return "lastname is valid";
            else
                return "lastname is invalid";

        };
        public const string EMAIL= "^[A-Za-z0-9]+[@][a-zA-Z]+[.][a-zA-Z]{2,3}$";
        public static Func<string, string> checkemail = (email) =>
        {
            Regex regex = new Regex(EMAIL);
            if (regex.IsMatch(email))
                return "Email is valid";
            else
                return "Email is invalid";

        };
    }
}
