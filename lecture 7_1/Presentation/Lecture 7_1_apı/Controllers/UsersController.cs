using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Week_7_1.Domain.Entites; 
using Week_7_1.Persistence.Contexts;

namespace Week_7_1.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly Week_7_1DbContext _context;

        public UsersController()
        {
            _context = new();
        }


        [HttpGet]
        public List<User> GetAll()
        {
            return _context.Users.ToList();
        }
    }
}
