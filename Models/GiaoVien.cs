namespace QuanLiGhiDanhAPI.Models
{
    public class GiaoVien
    {
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
