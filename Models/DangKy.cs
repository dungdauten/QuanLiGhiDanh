namespace QuanLiGhiDanhAPI.Models
{
    public class DangKy
    {
        public int Id { get; set; }
        public HocVien HocVien { get; set; }
        public KhoaHoc KhoaHoc { get; set; }
        public DateTime ThoiGianDangKy { get; set; }
        public bool TinhTrangThanhToan { get; set; }
    }
}
