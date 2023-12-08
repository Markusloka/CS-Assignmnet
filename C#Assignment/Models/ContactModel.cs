using C_Assignment.Interfaces;
using System.Runtime.InteropServices;

namespace C_Assignment.Models;

public class Contact (string firstName, string lastName, string mail, int phoneNumber, string home,string city, int postalCode) : IContact
{
    public string FirstName { get; set; } = firstName;
    public string LastName { get; set; } = lastName;
    public string Email { get; set; } = mail;
    public int PhoneNumber { get; set; } = phoneNumber;
    public string Home { get; set; } = home;
    public string City { get; set; } = city;
    public int PostalCode { get; set; } = postalCode;
    public string FullName => $"{FirstName} {LastName}";


    public override string ToString()
    {
        return $"{FullName}, {Email}, {PhoneNumber}, {Home}, {City}, {PostalCode}";
    }
}