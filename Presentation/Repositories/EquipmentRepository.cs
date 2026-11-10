using Presentation.Models;
using Presentation.Models.Enums;

namespace Presentation.Repositories;

public class EquipmentRepository : IEquipmentRepository
{
    public Equipment? Get(Guid id)
    {
        Equipment? equipment = _equipment.FirstOrDefault(x => x.Id == id);
        return equipment;
    }
    private readonly List<Equipment> _equipment = new()
    {
        new Equipment(Guid.Parse("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), "Golvslip", "-", Category.Slipmaskin, 800m, false),
        new Equipment(Guid.Parse("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), "Industridammsugare", "-", Category.Dammsugare, 350m, false),
        new Equipment(Guid.Parse("cccccccc-cccc-cccc-cccc-cccccccccccc"), "Kantslip", "-", Category.Slipmaskin, 0m, false)
    };

}
