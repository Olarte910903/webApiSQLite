using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using practicaApiSQLite;

namespace MyApp.Namespace
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemController : ControllerBase
    {
        private readonly InventarioContext _context;

        public ItemController (InventarioContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetItems()
        {
            var item = _context.items.ToList();
            return Ok(item);
        }
    }
}
