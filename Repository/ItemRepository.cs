using TestAPIs.Models;

namespace TestAPIs.Repository
{
    public class ItemRepository : IItemRepository
    {
        public IEnumerable<Item> GetItems()
        {
            // Hardcoded list of items for now.
            var items = new List<Item>
        {
            new Item { Id = 1, Name = "Item 1", Price = 10.99m },
            new Item { Id = 2, Name = "Item 2", Price = 20.49m },
            new Item { Id = 3, Name = "Item 3", Price = 15.99m }
        };
            return items;
        }
    }

}
