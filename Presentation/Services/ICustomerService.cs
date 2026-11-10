
using Presentation.Models;

namespace Presentation.Services;

public interface ICustomerService
{
    Customer? GetCustomer(Guid id);
    
}
