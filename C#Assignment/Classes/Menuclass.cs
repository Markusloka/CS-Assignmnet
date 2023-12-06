namespace C_Assignment.Classes
{
    public class Menuclass;

    {
    public void Run()
    {
        bool continue = true;

        while (continue)
        {
            Console.WriteLine("Enter Customer Details (1)");
            Console.WriteLine("Enter usage data (2)");
            Console.WriteLine("Display usage data (3)");
            Console.WriteLine("Exit (4)");

            string menu = Console.ReadLine();

            switch (menu)
            {
                case "1":
                    //statement 
                    break;

                case "2":
                    //statement 
                    break;

                case "3":
                    //statement 
                    break;

                case "4":
                default:
                    continue = false;
                    break;
            }
        }
    }
    }
}

