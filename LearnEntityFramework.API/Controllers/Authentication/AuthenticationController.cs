using LearnEntityFramework.API.Repositories.Authentication;
using LearnEntityFramework.EFLibrary.Entities;
using Microsoft.AspNetCore.Mvc;

namespace LearnEntityFramework.API.Controllers.Authentication
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly UserRoleRepository _userRoleRepo;

        public AuthenticationController(UserRoleRepository userRoleRepo)
        {
            _userRoleRepo = userRoleRepo;
        }

        [HttpGet("user-role")]
        public async Task<IActionResult> GetAllUserRoleAsync()
        {
            var result = await _userRoleRepo.GetAllAsync();

            return Ok(result);
        }

        [HttpPost("user-role")]
        public async Task<IActionResult> NewUserRoleAsync(UserRoleEntity userRole)
        {
            if (userRole is null)
                return BadRequest("Pareameter Method Null");

            var result = await _userRoleRepo.CreateAsync(userRole);

            return Ok(result);
        }

        [HttpPut("user-role")]
        public async Task<IActionResult> UpdateUserRoleAsync(UserRoleEntity userRole)
        {
            if (userRole is null)
                return BadRequest("Pareameter Method Null");

            var result = await _userRoleRepo.UpdateAsync(userRole);

            return Ok(result);
        }

        [HttpDelete("user-role")]
        public async Task<IActionResult> DeleteUserRoleAsync(int key)
        {

            var dbUserRepo = await _userRoleRepo.GetByIdAsync(key);
            if (dbUserRepo == null)
                return BadRequest("User role is not found!");

            var result = await _userRoleRepo.DeleteAsync(dbUserRepo);

            return Ok(result);
        }
    }
}
