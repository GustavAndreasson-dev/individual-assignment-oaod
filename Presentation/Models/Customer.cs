namespace Presentation.Models;

public class Customer
{
    public Guid Id { get; }
    public string Name { get; }
    public string OrganizationNumber { get; }
    public string Email { get; }
    public string Phone { get; }
    public Customer(Guid id, string name, string organizationNumber, string email, string phone)
    {
        Id = id;
        Name = name;
        OrganizationNumber = organizationNumber;
        Email = email;
        Phone = phone;
    }

}
