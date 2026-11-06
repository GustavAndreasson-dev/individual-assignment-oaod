using Presentation.Models;

namespace Presentation.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        public Customer? Get(Guid id)
        {
            Customer? customer = _customers.FirstOrDefault(c => c.Id == id);
           
                return customer;
            
        }

        private readonly List<Customer> _customers = new()
        {
            new Customer(Guid.Parse("11111111-1111-1111-1111-111111111111"), "Bygg AB", "556677-8899", "info@bygg.se", "010-123456"),
            new Customer(Guid.Parse("22222222-2222-2222-2222-222222222222"), "Anna Svensson", "", "anna@mail.se", "070-1234567")
        };

    }
}