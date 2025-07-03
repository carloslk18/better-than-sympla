using KernelBlog.API.Data;
using KernelBlog.API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace KernelBlog.API.Controllers
{
    [ApiController]
    [Route("api/[Controller]")] // Setando rota api/users
    public class UsersController : ControllerBase
    {
        private readonly KernelBlogContext _context;

        public UsersController(KernelBlogContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<User>>> GetUsers()
        {
            var users = await _context.Users.ToListAsync();

            return Ok(users);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<User>> GetUser(int id)
        {
            var user = await _context.Users.FindAsync(id);

            if (user == null)
            {
                return NotFound();
            }

            return Ok(user);
        }

        [HttpPost]
        public async Task<ActionResult<User>> PostUser(User user)
        {
            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetUser), new { id = user.Id }, user);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> PutUser(int id, User user)
        {
            var userEx = await _context.Users.FindAsync(id);

            if (userEx == null)
            {
                return BadRequest(); // Id da url e do corpo deve bater

            }

            userEx.Name = user.Name;
            userEx.Email = user.Email;
            userEx.PasswordHash = user.PasswordHash;
            userEx.Role = user.Role;

            await _context.SaveChangesAsync();

            return NoContent(); // Att com sucesso
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteUser(int id)
        {
            var user = await _context.Users.FindAsync(id);

            if (user == null)
            {
                return NotFound();
            }

            _context.Users.Remove(user);
            await _context.SaveChangesAsync();

            return NoContent(); // Foi
        }


    }
}