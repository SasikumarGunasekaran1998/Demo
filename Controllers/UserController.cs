using System.Collections.Generic;
using Data;
using Entites;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Controllers
{
        [ApiController]
        [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        public DataContext Data { get; set; }
        public UserController(DataContext data)
        {
            Data = data;

        }
    [HttpGet]
    public async Task<ActionResult<IEnumerable<userData>>> GetUser()
    {
        return await Data.User.ToListAsync();
    }
    
    [HttpGet("{id}")]
    public async Task<ActionResult<userData>> GetUser(int id)
    {
        return await Data.User.FindAsync(id);
    }
    
    }
}