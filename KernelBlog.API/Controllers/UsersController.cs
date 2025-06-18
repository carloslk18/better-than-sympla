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
        public async Task<ActionResult<IEnumerable<User>>> GetUsers()
        {
            return await _context.Users.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<User>> GetUser(int id)
        {
            var user = await _context.Users.FindAsync(id);

            if (user == null)
            {
                return NotFound();
            }

            return user;
        }
    }
}