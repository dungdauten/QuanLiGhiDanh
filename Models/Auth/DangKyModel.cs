using System.ComponentModel.DataAnnotations;

namespace QuanLiGhiDanhAPI.Models.Auth
{
    public class DangKyModel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string HoTen { get; set; }
        [Required]
        public string NgaySinh { get; set; }
        [Required]
        public string GioiTinh { get; set; }
        [Required]
        public string SoDienThoai { get; set; }
        [Required]
        public string HinhAnh { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Matkhau { get; set; }
        [Required]
        public string Xacnhanmatkhau { get; set; }
    }
}
