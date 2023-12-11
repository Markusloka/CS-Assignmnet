using C_Assignment.Models.Responses;
using C_Assignment.Interfaces;
using C_Assignment.Models;

namespace C_Assignment.Service;



public class ContactService : IContactService
{
    public ServiceResult AddContactToList(Contact contact)
    {
        throw new NotImplementedException();
    }

    public ServiceResult DeleteContactFromList(Func<Contact, bool> predicate)
    {
        throw new NotImplementedException();
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
