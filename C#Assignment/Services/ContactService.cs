using System.Diagnostics;
using C_Assignment.Models.Responses;
using C_Assignment.Interfaces;
using C_Assignment.Models;
using C_Assignment.Services;

namespace C_Assignment.Service;



public class ContactService : IContactService
{
    private static readonly List<IContact> _contacts = [];
    private readonly FileService _fileService = new FileService(@"C:\Projects\content.txt");

    public IServiceResult AddContactToList(IContact contact)
    {
        IServiceResult response = new ServiceResult();
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
            response.Result = ex.Message;

        }

        return response;

    }

    public IServiceResult GetContactsFromList()
    {
        
       IServiceResult response = new ServiceResult();
        try
        {
            response.Status = Enums.ServiceResultStatus.SUCCESS;
            response.Result = _contacts;
        }
        catch (Exception ex)
        {
            Debug.WriteLine(ex.Message);
            response.Status = Enums.ServiceResultStatus.FAILED;
            response.Result = ex.Message;

        }

        return response;
        
    }

    public IServiceResult UpdateContactInList(Contact contact)
    {
        throw new NotImplementedException();
    }


    public IServiceResult DeleteContactFromList(Func<Contact, bool> predicate)
    {

        IServiceResult response = new ServiceResult();
        try
        {
            response.Status = Enums.ServiceResultStatus.SUCCESS;
            response.Result = _contacts;
        }
        catch (Exception ex)
        {
            Debug.WriteLine(ex.Message);
            response.Status = Enums.ServiceResultStatus.FAILED;
            response.Result = ex.Message;

        }

        return response;
    }

    public IServiceResult GetContactFromList(Func<Contact, bool> predicate)
    {
        throw new NotImplementedException();
    }

    
} 
