using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Weather.Data;//Connects to DataContext
using Weather.Models; //Connects to User model

namespace Weather.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : Controller
    {
        private readonly DataContext _context;

        public UsersController(DataContext context)
        {
             _context = context;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<User>>> GetUsers()
        {
            var users = await _context.Users.ToListAsync();
            return Ok(users);
        }
        [HttpPost]
        public async Task<ActionResult<User>> AddUser(User user)
        {
           _context.Users.Add(user);
            await _context.SaveChangesAsync();
            return Ok(user);
        }
       
    }
}
