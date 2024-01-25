using Microsoft.AspNetCore.Identity;
using QuanLiGhiDanhAPI.Models.Auth;

namespace QuanLiGhiDanhAPI.Repository.Interfaces
{
    public interface IAccountRepository
    {
        public Task<IdentityResult> SignUpAsync(DangKyModel model);
        public Task<string> SignInAsync(DangNhapModel model);
    }
}
