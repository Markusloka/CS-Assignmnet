using C_Assignment.Enums;
using C_Assignment.Interfaces;
namespace C_Assignment.Models.Responses;
public class ServiceResult : IServiceResult
{
    public ServiceResultStatus Status { get; set; }
    public object Result { get; set; } = null!;
}
