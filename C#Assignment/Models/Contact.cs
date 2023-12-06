using C_Assignment.Interfaces;

namespace C_Assignment.Models;

public class Contact (string firstName, string lastName, string mail, int phoneNumber, string home, int postalCode) : IContact
{
    public string FirstName { get; set; } = firstName;
    public string LastName { get; set; } = lastName;
    public string Mail { get; set; } = mail;
    public int PhoneNumber { get; set; } = phoneNumber;
    public string Home { get; set; } = home;
    public int PostalCode { get; set; } = postalCode;
}