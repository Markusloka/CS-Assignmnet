namespace C_Assignment.Interfaces;

public interface IContact
{
 string FirstName { get; set; }
 string LastName { get; set; }
 string Mail { get; set; }
 int PhoneNumber { get; set; }
 string Home { get; set; }
 int PostalCode { get; set; }
}