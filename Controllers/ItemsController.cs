using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TestAPIs.Models;
using TestAPIs.Repository;

namespace TestAPIs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemsController : ControllerBase
    {
        private readonly IItemRepository _itemRepository;

        public ItemsController(IItemRepository itemRepository)
        {
            _itemRepository = itemRepository;
        }

        [HttpGet]
        public IEnumerable<Item> GetItems()
        {
            return _itemRepository.GetItems();
        }
    }
}
