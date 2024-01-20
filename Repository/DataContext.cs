using QuanLiGhiDanhAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace QuanLiGhiDanhAPI.Repository
{
    public class DataContext:DbContext
    {
        public DbSet<GiaoVien> GiaoVien { get; set; }
        public DbSet<HocVien> HocVien { get; set; }
        public DbSet<DangKy> DangKy { get; set; }
        public DbSet<KhoaHoc> KhoaHoc { get; set; }
        public DbSet<MonHoc> MonHoc { get; set; }
        public DbSet<LopHoc> LopHoc { get; set; }
        public DbSet<NhomMonHoc> NhomMonHoc { get; set; }

        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
