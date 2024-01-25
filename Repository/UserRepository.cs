using Microsoft.EntityFrameworkCore;
using QuanLiGhiDanhAPI.Models.Auth;
using QuanLiGhiDanhAPI.Repository.Interfaces;

namespace QuanLiGhiDanhAPI.Repository
{
    public class UserRepository : IUserRepository
    {
        public UserModel User { get; set; }
        private readonly DataContext _dbContext; 

        public UserRepository(DataContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<UserModel> GetUserById(int id)
        {
            return await _dbContext.Users.FirstOrDefaultAsync(u => Convert.ToInt16(u.Id) == id);
        }

        public async Task UpdateUser(UserModel user)
        {
            _dbContext.Users.Update(user);
            await _dbContext.SaveChangesAsync();
        }
    }
}
