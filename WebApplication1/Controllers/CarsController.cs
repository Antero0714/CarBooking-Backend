using CarBookingAPI;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Entities;
using WebApplication1.Enums;
using System.Linq;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CarsController : ControllerBase
    {
        private readonly ApplicationDbContext _dbContext;

        public CarsController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public IEnumerable<Car> GetAll()
        {
            return _dbContext.Cars.ToList();
        }

        [HttpGet("{id}")]
        public ActionResult<Car> GetById(int id)
        {
            var car = _dbContext.Cars.Find(id);
            if (car == null)
            {
                return NotFound();
            }
            return car;
        }

        [HttpGet("search")]
        public IEnumerable<Car> Search(
            [FromQuery] string name = null,
            [FromQuery] decimal? minPrice = null,
            [FromQuery] string transmission = null)
        {
            var query = _dbContext.Cars.AsQueryable();

            if (!string.IsNullOrEmpty(name))
            {
                query = query.Where(c => c.Name.Contains(name, StringComparison.OrdinalIgnoreCase));
            }

            if (minPrice.HasValue)
            {
                query = query.Where(c => c.Price >= minPrice.Value);
            }

            if (!string.IsNullOrEmpty(transmission))
            {
                query = query.Where(c => c.Transmissions == transmission);
            }

            return query.ToList();
        }

        [HttpGet("filter")]
        public IEnumerable<Car> Filter(
        [FromQuery] string search = null,
        [FromQuery] string types = null,
        [FromQuery] string capacities = null,
        [FromQuery] decimal? maxPrice = null)
        {
            var query = _dbContext.Cars.AsQueryable();

            if (!string.IsNullOrEmpty(search))
            {
                query = query.Where(c => c.Name.Contains(search));
            }

            if (!string.IsNullOrEmpty(types))
            {
                var typeList = types.Split(','); // Получаем массив строк
                query = query.Where(c => typeList.Contains(c.Type));
            }



            if (!string.IsNullOrEmpty(capacities))
            {
                var capacityList = capacities.Split(',');
                query = query.Where(c => capacityList.Contains(c.Capacity));
            }

            if (maxPrice.HasValue)
            {
                query = query.Where(c => c.Price <= maxPrice.Value);
            }

            return query.ToList();
        }
    }
        [ApiController]
    [Route("api/[controller]")]
    public class CarCommentController : ControllerBase
    {
        private readonly ApplicationDbContext _dbContext;

        public CarCommentController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet("{id}/comments")]
        public ActionResult<string[]> GetComments(int id)
        {
            var car = _dbContext.Cars.Find(id);
            if (car == null || car.Comments == null)
            {
                return NotFound();
            }
            return car.Comments;
        }
    }
}