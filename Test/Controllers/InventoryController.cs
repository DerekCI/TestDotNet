using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Test.Models;
using Test.Services;

namespace Test.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InventoryController : ControllerBase
    {
        private readonly IItemService _itemService;
        public InventoryController(IItemService itemService)
        {
            _itemService = itemService;
        }

        [HttpGet]
        public IActionResult GetByUser(User user)
        {
            return Ok(_itemService.GetByUser(user));
        }

        [HttpGet]
        public IActionResult GetAll(Inventory item)
        {
            return Ok(_itemService.GetAll(item));
        }

    }
}
