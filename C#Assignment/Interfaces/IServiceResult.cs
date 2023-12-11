using C_Assignment.Enums;

namespace C_Assignment.Interfaces
{
    public interface IServiceResult
    {
        object result { get; set; }
        ServiceResultStatus Status { get; set; }
    }
}