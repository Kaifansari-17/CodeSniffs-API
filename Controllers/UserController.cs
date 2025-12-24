using CodeSniffs.API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CodeSniffs.API.Controllers
{
    [Route("Api/")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly CodesniffsDbContext _context;

        public UserController(CodesniffsDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("Users")]
        public async Task<IActionResult> Users()
        {
            try
            {
                var users = await _context.Users.ToListAsync();
                return Ok(users);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPost]
        [Route("AddUser")]
        public async Task<IActionResult> AddUser(User user)
        {
            try
            {
                _context.Users.Add(user);
                await _context.SaveChangesAsync();
                return Ok("Added SuccessFully");

            }
            catch (Exception ex) {
                return BadRequest(ex.Message);
            }
        }
        [HttpPut]
        [Route("Update/{id}")]
        public async Task<IActionResult> Update(int id)
        {
            try
            {
                var users = _context.Users.Find(id);
                if (users == null)
                {
                    return NotFound();
                }
                else
                {
                    _context.Entry(users).State = EntityState.Modified;
                    await _context.SaveChangesAsync();
                    return Ok("Update SuccessFully");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPatch]
        [Route("DeActive/{id}")]
        public async Task<IActionResult> DeActive(int id, string status)
        {
            try
            {
                var users = await _context.Users.FindAsync(id);
                if (users == null)
                {
                    return NotFound();
                }
                else
                {
                    users.Status = status;
                    await _context.SaveChangesAsync();
                    return Ok("");
                }
            }
            catch (Exception ex) 
            {
                return BadRequest(ex.Message);
            }

        }
    }
}
