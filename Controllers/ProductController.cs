using CodeSniffs.API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CodeSniffs.API.Controllers
{
    [Route("api/")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly CodesniffsDbContext _context;

        public ProductController(CodesniffsDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        [Route("Products")]
        public async Task<IActionResult> Products()
        {
            try
            {
                var products = await _context.Products.ToListAsync();
                await _context.SaveChangesAsync();
                return Ok(products);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPost]
        [Route("AddProduct")]
        public async Task<IActionResult> AddProduct( Product product)
        {
            try
            {
                var products = await _context.Products.AddAsync(product);
                await _context.SaveChangesAsync();
                return Ok(products);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPut]
        [Route("Update/{id}")]
        public async Task<IActionResult> Update( int id)
        {
            try
            {
                var products = _context.Products.Find(id);
                if(products == null)
                {
                    return NotFound();
                }
                _context.Entry(products).State = EntityState.Modified;
                await _context.SaveChangesAsync();
                return Ok(products);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPatch]
        [Route("Deactive")]
        public async Task<IActionResult> Deactive(int id, string status)
        {
            try
            {
                var products =  _context.Products.Find(id);
                if (products == null)
                {
                    return NotFound();
                }
                products.Status = status;
                await _context.SaveChangesAsync();
                return Ok(products);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
