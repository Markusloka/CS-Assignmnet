using C_Assignment.Interfaces;
using C_Assignment.Models;

namespace C_Assignment.Classes
{
    public class MenuService
    {
        public  void MainMenu()
        {
            bool done = true;

            while (done)
            {
                Console.Clear();
                Console.WriteLine("Add Contact (1)");
                Console.WriteLine("View Contacts (2)");
                Console.WriteLine("Delete Contact (3)");
                Console.WriteLine("Exit (4)");

                string menu = Console.ReadLine();

                switch (menu)
                {
                    case "1":
                        AddContactMenu();
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

        private void AddContactMenu()
        {
            
            Console.Write("Firstname: ");
            string firstName = Console.ReadLine()!;
            
            Console.Write("Lastname: ");
            string lastName = Console.ReadLine()!;
            
            Console.Write("Email: ");
            string mail = Console.ReadLine()!;
            
            Console.Write("Phonenumber: ");
            int phoneNumber = Convert.ToInt32(Console.ReadLine()!);
            
            Console.Write("Address: ");
            string home = Console.ReadLine()!;
            
            Console.Write("Postal code: ");
            int postalCode = Convert.ToInt32(Console.ReadLine()!);
            IContact contact = new Contact(firstName, lastName, mail, phoneNumber, home, postalCode);

        }
        private void ShowAddContactMenu()
        {
            //lägg till grejer för att lägga till kontakt
        }
    }
}

