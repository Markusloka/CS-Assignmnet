using C_Assignment.Interfaces;

namespace C_Assignment.Models;

public class Contact : IContact
{
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public string Mail { get; set; } = null!;
}