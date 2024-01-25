using Microsoft.EntityFrameworkCore;
using QuanLiGhiDanhAPI.Models;

namespace QuanLiGhiDanhAPI.Repository
{
    public class SeedingData
    {
        public static void SeedData(DataContext _context)
        {
            _context.Database.Migrate();
            if (!_context.HocVien.Any())
            {
                HocVien hocvien1 = new HocVien {Id = 1,HoTen="Nguyen Anh Dung", NgaySinh = "2004-06-16",GioiTinh="Nam",HinhAnh="noimg.jpg",SoDienThoai="0366502364"};
                HocVien hocvien2 = new HocVien { Id = 2, HoTen = "Trương Quốc Huy", NgaySinh = "2004-05-05", GioiTinh = "Nam", HinhAnh = "noimg.jpg", SoDienThoai = "0123456789" };
                HocVien hocvien3 = new HocVien { Id = 3, HoTen = "Võ Văn Tuấn Kiệt", NgaySinh = "2004-01-01", GioiTinh = "Nam",HinhAnh = "noimg.jpg", SoDienThoai = "0936418238" };
                HocVien hocvien4 = new HocVien { Id = 4, HoTen = "Nguyễn Minh Thiện", NgaySinh = "2004-08-12", GioiTinh = "Nam", HinhAnh = "noimg.jpg", SoDienThoai = "0912398417" };
            }

            _context.SaveChanges();
        }
    }
}
