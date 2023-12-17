using System.Diagnostics;
using C_Assignment.Models.Responses;
using C_Assignment.Interfaces;
using C_Assignment.Models;

namespace C_Assignment.Service;



public class ContactService : IContactService
{
    private static readonly List<IContact> _contacts = new List<IContact>();

    public ServiceResult AddContactToList(IContact contact)
    {
        var response = new ServiceResult();
        try
        {
            if (!_contacts.Any(x => x.Email == contact.Email))
            {
                _contacts.Add(contact);
                response.Status = Enums.ServiceResultStatus.SUCCESS;
            }
            else
            {
                response.Status = Enums.ServiceResultStatus.ALREADY_EXISTS;
            }
        }
        catch (Exception ex)
        {
            Debug.WriteLine(ex.Message);
            response.Status = Enums.ServiceResultStatus.FAILED;
            response.result = ex.Message;

        }

        return response;

    }

    

    public ServiceResult DeleteContactFromList(Func<Contact, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public ServiceResult GetContactFromList(Func<Contact, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public ServiceResult GetContactsFromList(Contact contact)
    {
        
        var response = new ServiceResult();
        try
        {
            response.Status = Enums.ServiceResultStatus.SUCCESS;
            response.result = _contacts;
        }
        catch (Exception ex)
        {
            Debug.WriteLine(ex.Message);
            response.Status = Enums.ServiceResultStatus.FAILED;
            response.result = ex.Message;

        }

        return response;
        
    }

    public ServiceResult UpdateContactInList(Contact contact)
    {
        throw new NotImplementedException();
    }
} 
