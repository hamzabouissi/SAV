using AutoMapper;
using Core.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Dtos.Users;

namespace WebApplication1.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly UserManager<User> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IMapper _mapper;

        public AuthenticationController(UserManager<User> userManager,RoleManager<IdentityRole> roleManager ,IMapper mapper)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _mapper = mapper;
        }
        // GET: api/Authentication
        [HttpGet]
        public ActionResult<IEnumerable<UserDto>> Get()
        {
            var users = _mapper.Map<IEnumerable<UserDto>>(_userManager.Users.ToList());
            return Ok(users);
        }

        // GET: api/Authentication/5
        [HttpGet("{id}", Name = "Get")]
        public async Task<ActionResult<UserDto>> Get(string id)
        {
            var user = await _userManager.FindByIdAsync(id);
            return user is null ? NotFound() : Ok(_mapper.Map<UserDto>(user));
        }

        // POST: api/Authentication
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] UserRegistrationDto userRegistration)
        {
            foreach (var role in userRegistration.Roles)
            {
                var exist = await _roleManager.RoleExistsAsync(role);
                if (! exist)
                    return BadRequest($"Role({role}) doesn't Exist");
            }
            
            var user = _mapper.Map<User>(userRegistration);
            var result = await _userManager.CreateAsync(user);
            if (!result.Succeeded)
            {
                foreach (var error in result.Errors)
                    ModelState.TryAddModelError(error.Code, error.Description);
                return BadRequest(ModelState);
            }

           
            
            await _userManager.AddToRolesAsync(user, userRegistration.Roles);
            return StatusCode(201);
        }
        // DELETE: api/Authentication/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(string id)
        {
            var user = await _userManager.FindByIdAsync(id.ToString());
            if (user is null)
                return NotFound();
            await _userManager.DeleteAsync(user);
            return NoContent();
        }
    }
}
