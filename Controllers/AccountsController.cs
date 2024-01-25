using Microsoft.AspNetCore.Mvc;
using QuanLiGhiDanhAPI.Models.Auth;
using QuanLiGhiDanhAPI.Repository.Interfaces;

namespace QuanLiGhiDanhAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AccountsController : ControllerBase
    {
        private readonly IAccountRepository accountRepo;

        public AccountsController(IAccountRepository repo)
        {
            accountRepo = repo;
        }

        [HttpPost("SignUp")]
        public async Task<IActionResult> SignUp(DangKyModel model)
        {
            var result = await accountRepo.SignUpAsync(model);

            if (result.Succeeded)
                return Ok(result.Succeeded);
            return StatusCode(500);
        }
        [HttpPost("SignIn")]
        public async Task<IActionResult> SignIn(DangNhapModel model)
        {
            var result = await accountRepo.SignInAsync(model);
            
            if (string.IsNullOrEmpty(result))
                return Unauthorized();
            return Ok(result);
        }
    }
}
