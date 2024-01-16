using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyShoppingListApi.Models;
using System.Text.Json;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Cors;

namespace MyShoppingListApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [EnableCors("AllowLocalhost3000")]
    public class OrdersController : ControllerBase
    {
        private readonly MyDbContext _context;
        public OrdersController(MyDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult CreateOrder([FromBody] Order order)
        {
            _context.Orders.Add(order);
            _context.SaveChanges();

            return Ok(order);
        }
    }
}