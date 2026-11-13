using Presentation.Repositories;
using Presentation.Services;
string? customerNumber = string.Empty;
string? equipmentNumber = string.Empty;
Guid customerId = Guid.Empty;
Guid equipmentId = Guid.Empty;
var equipmentRepository = new EquipmentRepository();
var customerRepository = new CustomerRepository();
IEquipmentService equipmentService = new EquipmentService(equipmentRepository, customerRepository);

while (true)
{
    Console.WriteLine("Skriv in kund-id:");
    customerNumber = Console.ReadLine();
    if (Guid.TryParse(customerNumber, out customerId))
        break;
}
while (true)
{
    Console.WriteLine("Skriv in utrustnings-id:");
    equipmentNumber = Console.ReadLine();
    if (Guid.TryParse(equipmentNumber, out equipmentId))
        break;
}
try
{
    var priceInfo = equipmentService.GetPriceInfo(customerId, equipmentId);

    if (priceInfo.HasPrice is false)
        Console.WriteLine("Det finns inget pris tillgängligt. Vänligen kontakta oss för ett pris.");
    else if (priceInfo.IncludesVat is true)
            Console.WriteLine($"Pris inklusive moms: {priceInfo.Price:0.00} kr/dygn.");
        else
            Console.WriteLine($"Pris exklusive moms: {priceInfo.Price:0.00} kr/dygn.");
}
catch (ArgumentException ex)
{
    Console.WriteLine(ex.Message);
}