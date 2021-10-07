using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PI_1.Data.Contexts;
using PI_1.Models;
using System.Linq;
using System.Threading.Tasks;

namespace PI_1.Controllers
{
    public class CarsController : Controller
    {
        private readonly AppDbContext _appDbContext;

        public CarsController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<IActionResult> Index()
        {
            var cars = await _appDbContext.CarEntities
                .Select(x => x.ToViewModel())
                .AsNoTracking()
                .ToArrayAsync();

            return View(cars);
        }
    }
}