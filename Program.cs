namespace UserRegistrationUsingLamdaDay24
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the first name:");
            string firstname = Console.ReadLine();
            string result = Pattern.checkfirstname(firstname);
            Console.WriteLine(result);
        }
    }
}