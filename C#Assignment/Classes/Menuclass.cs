namespace C_Assignment.Classes
{
    public class Menuclass
    {
        public static void MainMenu()
        {
            bool done = true;

            while (done)
            {
                Console.WriteLine("Add Contact (1)");
                Console.WriteLine("View Contacts (2)");
                Console.WriteLine("Delete Contact (3)");
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
                        done = false;
                        break;
                }
            }
        }
    }
}

