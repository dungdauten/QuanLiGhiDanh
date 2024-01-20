namespace QuanLiGhiDanhAPI.Models
{
    public class LopHoc
    {
        public int Id { get; set; }
        public MonHoc MonHoc { get; set; }
        public DateTime NgayHoc { get; set; }
        public string GioHoc { get; set; }
        public decimal HocPhi { get; set; }
        public string PhongHoc {  get; set; }
        
        public GiaoVien GiaoVienChuNhiem { get; set; }
    }
}
