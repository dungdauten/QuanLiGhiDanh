using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace QuanLiGhiDanhAPI.Models.Auth
{
    public class UserModel:IdentityUser
    {
        [Key]
        public int IdUser { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string Email { get; set; }
    }
}
