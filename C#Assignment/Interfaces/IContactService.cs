using C_Assignment.Models;
using C_Assignment.Models.Responses;

namespace C_Assignment.Interfaces
{
    public interface IContactService
    {
        IServiceResult AddContactToList(IContact contact);
        IServiceResult DeleteContactFromList(Func<Contact, bool> predicate);
        IServiceResult GetContactFromList(Func<Contact, bool> predicate);
      
        IServiceResult GetContactsFromList();
        IServiceResult UpdateContactInList(Contact contact);
    }
}

