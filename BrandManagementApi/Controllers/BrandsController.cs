using BrandManagementApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BrandManagementApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandsController : ControllerBase
    {
        private readonly BrandContext _dbContext;

        public BrandsController(BrandContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Brand>>> GetBrands()
        {
            var brands = await _dbContext.Brands.ToListAsync();
            return Ok(brands);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Brand>> GetBrand(int id)
        {
            var brand = await _dbContext.Brands.FindAsync(id);

            if (brand == null)
            {
                return NotFound();
            }

            return Ok(brand);
        }

        [HttpPost]
        public async Task<ActionResult<Brand>> PostBrand(Brand brand)
        {
            _dbContext.Brands.Add(brand);
            await _dbContext.SaveChangesAsync();

            return CreatedAtAction(nameof(GetBrand), new { id = brand.Id }, brand);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutBrand(int id, Brand brand)
        {
            brand.Id = id;

            _dbContext.Entry(brand).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBrand(int id)
        {
            var brand = await _dbContext.Brands.FindAsync(id);

            if (brand == null)
            {
                return NotFound();
            }

            _dbContext.Brands.Remove(brand);
            await _dbContext.SaveChangesAsync();

            return NoContent();
        }

        private bool BrandExists(int id)
        {
            return _dbContext.Brands.Any(e => e.Id == id);
        }
    }
}