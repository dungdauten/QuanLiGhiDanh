namespace QuanLiGhiDanhAPI.Models
{
    public class MonHoc
    {
        public int Id { get; set; }
        public string TenMonHoc { get; set; }
        public string MaMonHoc { get; set; }
        public List<GiaoVien> DanhSachGiaoVien { get; set; }

    }
}