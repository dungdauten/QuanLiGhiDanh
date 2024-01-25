using System.ComponentModel.DataAnnotations;

namespace QuanLiGhiDanhAPI.Models.Auth
{
    public class DangNhapModel
    {
        [Required, EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Matkhau { get; set; }
    }
}
