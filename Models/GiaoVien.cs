using System.ComponentModel.DataAnnotations;

namespace QuanLiGhiDanhAPI.Models
{
    public class GiaoVien
    {
        [Key]
        public int Id { get; set; }
        public string HoTen { get; set; }
        public DateTime NgaySinh { get; set; }
        public string CMND { get; set; }
        public string DiaChi { get; set; }
        public string SDT { get; set; }
        public string HinhAnh { get; set; }
        public DateTime NgayHopTac { get; set; }
        public List<MonHoc> MonGiangDay { get; set; }
    }
}
