using Microsoft.AspNetCore.Mvc;
using Org.BouncyCastle.Crypto.Generators;
using QuanLiGhiDanhAPI.Models.Auth;
using QuanLiGhiDanhAPI.Repository.Interfaces;

namespace QuanLiGhiDanhAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _userRepository;
        DangNhapModel DangNhapModel { get; set; }
        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateUser(int id, [FromBody] CapNhatUser userUpdateModel)
        {
            var user = await _userRepository.GetUserById(id);

            if (user == null)
            {
                return NotFound();
            }

            // Cập nhật thông tin người dùng
            user.UserName = userUpdateModel.Hoten;
            user.Email = userUpdateModel.Email;
           

            // Cài lại mật khẩu người dùng
            string newPassword = userUpdateModel.Matkhaumoi;
            if (!string.IsNullOrEmpty(newPassword))
            {
                string hashedPassword = HashPassword(newPassword);
                DangNhapModel.Matkhau = hashedPassword;
            }

            // Lưu lại các thay đổi vào cơ sở dữ liệu
            await _userRepository.UpdateUser(user);

            return Ok();
        }

        // Hàm băm mật khẩu
    private string HashPassword(string password)
    {
        // Thực hiện mã hóa mật khẩu ở đây, ví dụ sử dụng bcrypt:
        string hashedPassword = BCrypt.Net.BCrypt.HashPassword(password);
        return hashedPassword;
    }
    }
}
