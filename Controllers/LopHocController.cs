using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using QuanLiGhiDanhAPI.Models;
using QuanLiGhiDanhAPI.Repository;

namespace QuanLiGhiDanhAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LopHocController : ControllerBase
    {
        private readonly DataContext _datacontext;

        public LopHocController(DataContext datacontext) 
        {
            _datacontext = datacontext;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<LopHoc>>> GetAllLopHoc()
        {
            var lopHocList = await _datacontext.LopHoc.ToListAsync();
            return Ok(lopHocList);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<LopHoc>> GetLopHocById(int id)
        {
            var lopHoc = await _datacontext.LopHoc.FindAsync(id);
            if (lopHoc == null)
            {
                return NotFound();
            }
            return Ok(lopHoc);
        }

        [HttpPost]
        public async Task<ActionResult<LopHoc>> CreateLopHoc(LopHoc lopHoc)
        {
            _datacontext.LopHoc.Add(lopHoc);
            await _datacontext.SaveChangesAsync();
            return CreatedAtAction(nameof(GetLopHocById), new { id = lopHoc.Id }, lopHoc);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateLopHoc(int id, LopHoc lopHoc)
        {
            if (id != lopHoc.Id)
            {
                return BadRequest();
            }

            _datacontext.Entry(lopHoc).State = EntityState.Modified;

            try
            {
                await _datacontext.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LopHocExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteLopHoc(int id)
        {
            var lopHoc = await _datacontext.LopHoc.FindAsync(id);
            if (lopHoc == null)
            {
                return NotFound();
            }

            _datacontext.LopHoc.Remove(lopHoc);
            await _datacontext.SaveChangesAsync();

            return NoContent();
        }

        private bool LopHocExists(int id)
        {
            return _datacontext.LopHoc.Any(e => e.Id == id);
        }
    }
}