namespace UserRegistrationUsingLamdaDay24
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter your choice:");
            Console.WriteLine("1.FirstName\n2.LastName\n3.Email\n4.PhoneNo\n5.password\n6.validatepw\n7.validatenumeric\n");
            int choice= Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("enter the first name:");
                    string firstname = Console.ReadLine();
                    string result = Pattern.checkfirstname(firstname);
                    Console.WriteLine(result);
                    break;
                case 2:
                    Console.WriteLine("enter the last name:");
                    string lastname = Console.ReadLine();
                    string result1 = Pattern.checklastname(lastname);
                    Console.WriteLine(result1);
                    break;
                case 3:
                    Console.WriteLine("enter the email:");
                    string email = Console.ReadLine();
                    string result2 = Pattern.checkemail(email);
                    Console.WriteLine(result2);
                    break;
                case 4:
                    Console.WriteLine("enter the mobile:");
                    string phone = Console.ReadLine();
                    string result3 = Pattern.checkphone(phone);
                    Console.WriteLine(result3);
                    break;
                case 5:
                    Console.WriteLine("enter the password:");
                    string password = Console.ReadLine();
                    string result4 = Pattern.checkpw(password);
                    Console.WriteLine(result4);
                    break;
                case 6:
                    Console.WriteLine("enter the password:");
                    string password1 = Console.ReadLine();
                    string result5 = Pattern.checkupper(password1);
                    Console.WriteLine(result5);
                    break;
                case 7:
                    Console.WriteLine("enter the Password:");
                    string password2 = Console.ReadLine();
                    string result6 = Pattern.checknumeric(password2);
                    Console.WriteLine(result6);
                    break;


                default:
                    break;

            }
            
        }
    }
}