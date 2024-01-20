namespace QuanLiGhiDanhAPI.Models
{
    public class NhomMonHoc
    {
        public int Id { get; set; }
        public string TênNhóm { get; set; }
        public List<MonHoc> DanhSachMonHoc { get; set; }
    }
}
