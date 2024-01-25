using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using QuanLiGhiDanhAPI.Models;
using QuanLiGhiDanhAPI.Repository;

namespace QuanLiGhiDanhAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HocVienController : ControllerBase
    {
        private readonly DataContext _datacontext;

        public HocVienController(DataContext datacontext)
        {
            _datacontext = datacontext;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<HocVien>>> GetDsHocVien()
        {
            var danhsachhocvien = await _datacontext.HocVien.ToListAsync();
            return Ok(danhsachhocvien);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Edit(int id)
        {
            var hocvien = await _datacontext.HocVien.FirstOrDefaultAsync(s => s.Id == id);
            if (hocvien == null)
            {
                return NotFound();
            }
            return Ok(hocvien);
        }
        [HttpPut("edit/{id}")]
        public async Task<IActionResult> Edit(HocVien hocvien, int id)
        {
            if (id != hocvien.Id)
            {
                return BadRequest("Sai mã Id của học viên!");
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var hocvientontai = await _datacontext.HocVien.FindAsync(id);
            if (hocvien == null)
            {
                return NotFound("Không tìm thấy học viên!");
            }

            hocvientontai.HoTen = hocvien.HoTen;
            hocvientontai.NgaySinh = hocvien.NgaySinh;
            hocvientontai.GioiTinh = hocvien.GioiTinh;
            hocvientontai.SoDienThoai = hocvien.SoDienThoai;
            hocvientontai.HinhAnh = hocvien.HinhAnh;

            _datacontext.HocVien.Update(hocvientontai);
            await _datacontext.SaveChangesAsync();

            return Ok("Cập nhật thông tin học viên thành công");
        }
    }
}
