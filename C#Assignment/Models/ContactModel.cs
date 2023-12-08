using C_Assignment.Interfaces;
using System.Runtime.InteropServices;

namespace C_Assignment.Models;

public class Contact (string firstName, string lastName, string mail, int phoneNumber, string home,string city, int postalCode,string fullName) : IContact
{
    public string FirstName { get; set; } = firstName;
    public string LastName { get; set; } = lastName;
    public string Mail { get; set; } = mail;
    public int PhoneNumber { get; set; } = phoneNumber;
    public string Home { get; set; } = home;
    public string City { get; set; } = city;
    public int PostalCode { get; set; } = postalCode;
    public string FullName { get; set; } = fullName;
}