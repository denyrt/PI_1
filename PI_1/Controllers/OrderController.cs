using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PI_1.Commands;
using PI_1.Data.Contexts;
using PI_1.Data.Models;
using PI_1.Models;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace PI_1.Controllers
{
    public class OrderController : Controller
    {
        private readonly AppDbContext _appDbContext;

        public OrderController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var orders = await _appDbContext.OrderEntities
                .Include(x => x.Car)
                .Select(x => x.ToOrderView())
                .AsNoTracking()
                .ToArrayAsync();

            return View(orders);
        }

        [HttpGet("OrderForm/{id}")]
        public async Task<IActionResult> OrderForm([FromRoute] Guid id)
        {
            var car = await _appDbContext.CarEntities.FindAsync(id);
            if (car == null)
            {
                return Conflict();
            }

            return View(car.ToViewModel());
        }

        [HttpPost("MakeOrder")]
        public async Task<IActionResult> MakeOrder([FromForm] MakeOrderCommand command)
        {
            var orderEntity = new OrderEntity
            {
                ClientName = command.ClientName,
                Address = command.Address,
                CarId = command.CarId
            };
            
            await _appDbContext.OrderEntities.AddAsync(orderEntity);
            await _appDbContext.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
