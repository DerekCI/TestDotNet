using Test.Models;

namespace Test.Services
{
    public interface IItemService
    {
        Inventory GetByUser(User user);
        Inventory GetAll(Inventory items);

    }
}
