using C_Assignment.Models.Responses;
using C_Assignment.Interfaces;
using C_Assignment.Models;

namespace C_Assignment.Service;



public class ContactService : IContactService
{
    private static readonly List<IContact> _contacts = [];

    public ServiceResult AddContactToList(Contact contact)
    {
        _contacts.Add(contact);
    }

    public ServiceResult DeleteContactFromList(Func<Contact, bool> predicate)
    {
        IContact contact = _contacts.FirstOrDefault(predicate);
    }

    public ServiceResult GetContactFromList(Func<Contact, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public ServiceResult GetContactsFromlist()
    {
        throw new NotImplementedException();
    }

    public ServiceResult UpdateContactInList(Contact contact)
    {
        throw new NotImplementedException();
    }
}
