using TestAPIs.Models;

namespace TestAPIs.Repository
{
    public interface IItemRepository
    {
        IEnumerable<Item> GetItems();
    }
}
