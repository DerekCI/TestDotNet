using Test.Models;

namespace Test.Services
{
    public class ItemService : IItemService
    {
        private static List<Inventory> items = new List<Inventory>();
        public Inventory GetAll(Inventory items)
        {
            return items;
        }

        public Inventory GetByUser(User user)
        {
            return items[user.UserId];
        }
    }
}
