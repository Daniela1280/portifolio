// Criado por Daniela Pompeu de Sousa
using Microsoft.AspNetCore.Mvc;

namespace ShoppingApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ShoppingController : ControllerBase
    {
        public static List<Item> items = new();

        [HttpGet]
        public IActionResult Get() => Ok(items);

        [HttpPost]
        public IActionResult Add(Item item)
        {
            items.Add(item);
            return Ok(item);
        }
    }

    public class Item
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
    }
}
