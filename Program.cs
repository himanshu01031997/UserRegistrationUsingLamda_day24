namespace UserRegistrationUsingLamdaDay24
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter your choice:");
            Console.WriteLine("1.FirstName\n2.LastName\n");
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
                default:
                    break;

            }
            
        }
    }
}