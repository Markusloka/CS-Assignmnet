using C_Assignment.Interfaces;
using C_Assignment.Models;
using C_Assignment.Models.Responses;
using C_Assignment.Service;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace C_Assignment.Classes
{
    public class MenuService : IMenuService
    {
        private readonly IContactService _contactService = new ContactService();

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
                Console.WriteLine();
                Console.Write("Enter Menu Option: ");

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
                        ShowExitApplicationOption();
                        break;

                    default:
                        Console.WriteLine("Invalid Option selected, Press any key to try again");
                        Console.ReadKey();
                        break;
                }
                //1:30 i videon kolla
                
            }
        }


        private void ShowExitApplicationOption()
        {
            Console.Clear();
            Console.Write("Are you sure you want to close this application? (y/n): ");
            var option = Console.ReadLine() ?? "";

            if (option.Equals("y", StringComparison.CurrentCultureIgnoreCase))
            {
                Environment.Exit(0);
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

            Contact contact = new Contact(firstName, lastName, mail, phoneNumber, home, city, postalCode);

            var res = _contactService.AddContactToList(contact);


            switch (res.Status)
            {
                case Enums.ServiceResultStatus.SUCCESS:
                    Console.WriteLine($"{fullName}, Has been added to your contacts ");
                    Console.ReadKey();
                    break;
                case Enums.ServiceResultStatus.FAILED:
                    Console.WriteLine($"Failed to add {fullName} to your contacts ");
                    Console.WriteLine("See error message :: " + res.Result.ToString());

                    Console.ReadKey();
                    break;
                case Enums.ServiceResultStatus.ALREADY_EXISTS:
                    Console.WriteLine($"{fullName}, Already exists");
                    Console.ReadKey();
                    break;
            }

        }



        public void ShowContactsOption()
        {
            DisplayMenuTitle("Your Contacts, press the id to view details");
            var res = _contactService.GetContactsFromList();

            if (res.Status == Enums.ServiceResultStatus.SUCCESS)
            {
                if (res.Result is IEnumerable<IContact> contactList)
                    if (!contactList.Any())
                {
                    Console.WriteLine("No contacts found");
                }
                    else
                    {
                        foreach (var contact in contactList)
                        {
                            Console.WriteLine($"{contact.FullName}");
                        }
                    }      
            }
            Console.ReadKey();
        }

        public void DeleteContactOption()
        {
            DisplayMenuTitle("Write the Email of the contact you want to remove");
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

