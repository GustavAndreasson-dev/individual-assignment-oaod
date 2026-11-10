using Presentation.Models;

namespace Presentation.Repositories;

public interface IEquipmentRepository
{
    Equipment? Get(Guid id);
}
