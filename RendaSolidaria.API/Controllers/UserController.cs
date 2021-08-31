using HotChocolate;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RendaSolidaria.Infra.Data.Context;
using RendaSolidaria.Infra.Data.Repositories.Interfaces;

namespace RendaSolidaria.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _userRepository;
        private MainContext _context;

        public UserController(IUserRepository userRepository, [ScopedService] MainContext context)
        {
            _userRepository = userRepository;
            _context = context;
        }

        [HttpGet]
        public IActionResult GetUser()
        {
            var user = _userRepository.Get(_context);
            return StatusCode(200, user);
        }
    }
}
