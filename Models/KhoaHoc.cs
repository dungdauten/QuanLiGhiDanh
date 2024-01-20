namespace QuanLiGhiDanhAPI.Models
{
    public class KhoaHoc
    {
        public int Id { get; set; }
        public string TenKhoaHoc { get; set; }
        public DateTime NgayBatDau { get; set; }
        public DateTime NgayKetThuc { get; set; }
        public decimal HocPhi { get; set; }
        public List<GiaoVien> DanhSachGiaoVien { get; set; }
        public List<DangKy> DanhSachDangKy { get; set; }
    }
}
