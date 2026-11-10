using Presentation.Models;
using Presentation.Repositories;

namespace Presentation.Services;

public class CustomerService : ICustomerService
{
    private readonly ICustomerRepository _customerRepository;
    public Customer? GetCustomer(Guid id)
    {
        return _customerRepository.Get(id);
    }
}
