using C_Assignment.Interfaces;
using C_Assignment.Models;
using System.ComponentModel.DataAnnotations;

namespace C_Assignment.Classes
{
    public class MenuService : IMenuService
    {
        public void MainMenu()
        {
            bool done = true;

            while (done)
            {
                DisplayMenuTitle("Menu Options");
                Console.WriteLine("Add Contact (1)");
                Console.WriteLine("View Contacts (2)");
                Console.WriteLine("Delete Contact (3)");
                Console.WriteLine("Update Contact (4)");
                Console.WriteLine("Exit (5)");

                string menu = Console.ReadLine()!;

                switch (menu)
                {
                    case "1":
                        AddContactOption();
                        break;

                    case "2":
                        ShowContactsOption();
                        break;

                    case "3":
                        DeleteContactOption();
                        break;

                    case "4":
                        UpdateContactOption();
                        break;

                    case "5":
                    default:
                        done = false;
                        break;
                }
            }
        }

        public void AddContactOption()
        {
            DisplayMenuTitle("Fill Contact info");
            Console.Write("Firstname: ");
            string firstName = Console.ReadLine()!;

            Console.Write("Lastname: ");
            string lastName = Console.ReadLine()!;

            Console.Write("Email: ");
            string mail = Console.ReadLine()!;

            Console.Write("Phonenumber: ");
            int phoneNumber = int.Parse(Console.ReadLine()!);

            Console.Write("Address: ");
            string home = Console.ReadLine()!;

            Console.Write("City: ");
            string city = Console.ReadLine()!;

            Console.Write("Postal code: ");
            int postalCode = int.Parse(Console.ReadLine()!);

            string fullName = firstName + " " + lastName;

            Console.WriteLine($"{fullName}, Has been added to your contacts ");
            Console.ReadKey();
            IContact contact = new Contact(firstName, lastName, mail, phoneNumber, home, city, postalCode, fullName);
        }



        public void ShowContactsOption()
        {
            DisplayMenuTitle("Your Contacts, press the id to view details");
            Console.ReadKey();
            throw new NotImplementedException();
        }

        public void DeleteContactOption()
        {
            DisplayMenuTitle("Write the full name of the contact you want to remove");
            Console.ReadKey();

            throw new NotImplementedException();
        }

        public void UpdateContactOption()
        {
            DisplayMenuTitle("Choose which contact to update by pressing the id");
            Console.ReadKey();

            throw new NotImplementedException();
        }

        public void ShowContactDetailsOption()
        {
            DisplayMenuTitle("placeholder");
            Console.ReadKey();

            throw new NotImplementedException();
        }

        private void DisplayMenuTitle(string title)
        {
            Console.Clear();
            Console.WriteLine($"## {title} ##");
            Console.WriteLine();
        }


        //38 min i vide service patterns
    }
}

