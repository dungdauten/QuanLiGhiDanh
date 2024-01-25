using QuanLiGhiDanhAPI.Models;
using QuanLiGhiDanhAPI.Models.Auth;

namespace QuanLiGhiDanhAPI.Repository.Interfaces
{
    public interface IUserRepository
    {
        Task<UserModel> GetUserById(int id);
        Task UpdateUser(UserModel user);
    }
}
