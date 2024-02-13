namespace MessangerChat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello User :)");
            Console.WriteLine("First, Enter your Username: ");
            string username = Console.ReadLine();
            Console.WriteLine("And now Enter your Password: ");
            string password = Console.ReadLine();

            Console.WriteLine("1) Users List");
            Console.WriteLine("2) Messages");
            string number = Console.ReadLine();

            int num = Int32.Parse(number);

            switch (num)
            {
                case 1:
                    UI.UsersList();
                    string ToUser = Console.ReadLine();

                    break;
            }
        }
    }
}
