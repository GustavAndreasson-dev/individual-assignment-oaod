using Presentation.Models;

namespace Presentation.Services;

public interface IEquipmentService
{
    Equipment? GetEquipment(Guid id);
    PriceInfoResult GetPriceInfo(Guid customerId, Guid equipmentId);
}
