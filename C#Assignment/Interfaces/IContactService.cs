using C_Assignment.Models;
using C_Assignment.Models.Responses;

namespace C_Assignment.Interfaces
{
    public interface IContactService
    {
        ServiceResult AddContactToList(IContact contact);
        ServiceResult DeleteContactFromList(Func<Contact, bool> predicate);
        ServiceResult GetContactFromList(Func<Contact, bool> predicate);

        ServiceResult GetContactsFromList( Contact contact);
        ServiceResult UpdateContactInList(Contact contact);
    }
}

