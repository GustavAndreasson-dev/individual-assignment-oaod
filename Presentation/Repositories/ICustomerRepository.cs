
using Presentation.Models;

namespace Presentation.Repositories;

public interface ICustomerRepository
{
    Customer? Get(Guid id);
}
