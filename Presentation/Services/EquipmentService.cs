using Presentation.Models;
using Presentation.Repositories;

namespace Presentation.Services;

public class EquipmentService : IEquipmentService
{
    private readonly IEquipmentRepository _equipmentRepository;
    private readonly ICustomerRepository _customerRepository;

    public EquipmentService(IEquipmentRepository equipmentRepository, ICustomerRepository customerRepository)
    {
        _equipmentRepository = equipmentRepository;
        _customerRepository = customerRepository;
    }

    public Equipment? GetEquipment(Guid id)
    {
        return _equipmentRepository.Get(id);
    }

    public PriceInfoResult GetPriceInfo(Guid customerId, Guid equipmentId)
    {
        var equipment = _equipmentRepository.Get(equipmentId)
            ?? throw new ArgumentException($"Utrustning {equipmentId} hittades inte.");
        var customer = _customerRepository.Get(customerId)
            ?? throw new ArgumentException($"Kund {customerId} hittades inte.");

        if (equipment.Price == 0)
            return new PriceInfoResult(0, false, false);

        bool isCompany = !string.IsNullOrWhiteSpace(customer.OrganizationNumber);
        if (isCompany)
            return new PriceInfoResult(equipment.Price, false, true);

        return new PriceInfoResult(equipment.Price * (1.25m), true, true);
    }
}
