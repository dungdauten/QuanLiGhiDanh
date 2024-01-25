using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuanLiGhiDanhAPI.Migrations
{
    public partial class FirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HocVien",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HoTen = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NgaySinh = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DiaChi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SDTPhuHuynh = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HinhAnh = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HocVien", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "KhoaHoc",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenKhoaHoc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NgayBatDau = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NgayKetThuc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HocPhi = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhoaHoc", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NhomMonHoc",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TênNhóm = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhomMonHoc", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DangKy",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HocVienId = table.Column<int>(type: "int", nullable: false),
                    KhoaHocId = table.Column<int>(type: "int", nullable: false),
                    ThoiGianDangKy = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TinhTrangThanhToan = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DangKy", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DangKy_HocVien_HocVienId",
                        column: x => x.HocVienId,
                        principalTable: "HocVien",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DangKy_KhoaHoc_KhoaHocId",
                        column: x => x.KhoaHocId,
                        principalTable: "KhoaHoc",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GiaoVien",
                columns: table => new
                {
                    HoTen = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    NgaySinh = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CMND = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DiaChi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SDT = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HinhAnh = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NgayHopTac = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KhoaHocId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GiaoVien", x => x.HoTen);
                    table.ForeignKey(
                        name: "FK_GiaoVien_KhoaHoc_KhoaHocId",
                        column: x => x.KhoaHocId,
                        principalTable: "KhoaHoc",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "MonHoc",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenMonHoc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaMonHoc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GiaoVienHoTen = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    NhomMonHocId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MonHoc", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MonHoc_GiaoVien_GiaoVienHoTen",
                        column: x => x.GiaoVienHoTen,
                        principalTable: "GiaoVien",
                        principalColumn: "HoTen");
                    table.ForeignKey(
                        name: "FK_MonHoc_NhomMonHoc_NhomMonHocId",
                        column: x => x.NhomMonHocId,
                        principalTable: "NhomMonHoc",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "LopHoc",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MonHocId = table.Column<int>(type: "int", nullable: false),
                    NgayHoc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GioHoc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HocPhi = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PhongHoc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GiaoVienChuNhiemHoTen = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LopHoc", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LopHoc_GiaoVien_GiaoVienChuNhiemHoTen",
                        column: x => x.GiaoVienChuNhiemHoTen,
                        principalTable: "GiaoVien",
                        principalColumn: "HoTen");
                    table.ForeignKey(
                        name: "FK_LopHoc_MonHoc_MonHocId",
                        column: x => x.MonHocId,
                        principalTable: "MonHoc",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DangKy_HocVienId",
                table: "DangKy",
                column: "HocVienId");

            migrationBuilder.CreateIndex(
                name: "IX_DangKy_KhoaHocId",
                table: "DangKy",
                column: "KhoaHocId");

            migrationBuilder.CreateIndex(
                name: "IX_GiaoVien_KhoaHocId",
                table: "GiaoVien",
                column: "KhoaHocId");

            migrationBuilder.CreateIndex(
                name: "IX_LopHoc_GiaoVienChuNhiemHoTen",
                table: "LopHoc",
                column: "GiaoVienChuNhiemHoTen");

            migrationBuilder.CreateIndex(
                name: "IX_LopHoc_MonHocId",
                table: "LopHoc",
                column: "MonHocId");

            migrationBuilder.CreateIndex(
                name: "IX_MonHoc_GiaoVienHoTen",
                table: "MonHoc",
                column: "GiaoVienHoTen");

            migrationBuilder.CreateIndex(
                name: "IX_MonHoc_NhomMonHocId",
                table: "MonHoc",
                column: "NhomMonHocId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DangKy");

            migrationBuilder.DropTable(
                name: "LopHoc");

            migrationBuilder.DropTable(
                name: "HocVien");

            migrationBuilder.DropTable(
                name: "MonHoc");

            migrationBuilder.DropTable(
                name: "GiaoVien");

            migrationBuilder.DropTable(
                name: "NhomMonHoc");

            migrationBuilder.DropTable(
                name: "KhoaHoc");
        }
    }
}
