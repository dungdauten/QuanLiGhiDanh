using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace QuanLiGhiDanhAPI.Models
{
    public class HocVien
    {
        [Key]
        public int Id {  get; set; }
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
    }
}
