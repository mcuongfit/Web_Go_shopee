using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NETCKTEAM30.Migrations
{
    public partial class Create : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GioiTinhs",
                columns: table => new
                {
                    GioiTinhID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TenGT = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GioiTinhs", x => x.GioiTinhID);
                });

            migrationBuilder.CreateTable(
                name: "LoaiNgDungs",
                columns: table => new
                {
                    LoaiNgDungID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TenLoai = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoaiNgDungs", x => x.LoaiNgDungID);
                });

            migrationBuilder.CreateTable(
                name: "Loais",
                columns: table => new
                {
                    LoaiID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TenLoai = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Loais", x => x.LoaiID);
                });

            migrationBuilder.CreateTable(
                name: "NhaCungCaps",
                columns: table => new
                {
                    NhaCungCapID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TenNhaCc = table.Column<string>(nullable: true),
                    DiaChi = table.Column<string>(nullable: true),
                    SDT = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    MoTa = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhaCungCaps", x => x.NhaCungCapID);
                });

            migrationBuilder.CreateTable(
                name: "ThanhToans",
                columns: table => new
                {
                    ThanhToanID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Ten = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ThanhToans", x => x.ThanhToanID);
                });

            migrationBuilder.CreateTable(
                name: "TrangThais",
                columns: table => new
                {
                    TrangThaiID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TenTrangThai = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrangThais", x => x.TrangThaiID);
                });

            migrationBuilder.CreateTable(
                name: "VanChuyens",
                columns: table => new
                {
                    VanChuyenID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Ten = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VanChuyens", x => x.VanChuyenID);
                });

            migrationBuilder.CreateTable(
                name: "NguoiDungs",
                columns: table => new
                {
                    NguoiDungID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    HoTen = table.Column<string>(nullable: true),
                    GioiTinhID = table.Column<int>(nullable: false),
                    NgaySinh = table.Column<DateTime>(nullable: false),
                    DiaChi = table.Column<string>(nullable: true),
                    SDT = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Hinh = table.Column<string>(nullable: true),
                    LoaiNgDungID = table.Column<int>(nullable: false),
                    TenDangNhap = table.Column<string>(nullable: true),
                    MatKhau = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NguoiDungs", x => x.NguoiDungID);
                    table.ForeignKey(
                        name: "FK_NguoiDungs_GioiTinhs_GioiTinhID",
                        column: x => x.GioiTinhID,
                        principalTable: "GioiTinhs",
                        principalColumn: "GioiTinhID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_NguoiDungs_LoaiNgDungs_LoaiNgDungID",
                        column: x => x.LoaiNgDungID,
                        principalTable: "LoaiNgDungs",
                        principalColumn: "LoaiNgDungID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HangHoas",
                columns: table => new
                {
                    HanghoaID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TenHh = table.Column<string>(nullable: true),
                    MaLoaiID = table.Column<int>(nullable: false),
                    DonGia = table.Column<double>(nullable: false),
                    Hinh = table.Column<string>(nullable: true),
                    NhaCungCapID = table.Column<int>(nullable: false),
                    NgayNhap = table.Column<DateTime>(nullable: false),
                    MoTa = table.Column<string>(nullable: true),
                    GiamGia = table.Column<double>(nullable: false),
                    LuotMua = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HangHoas", x => x.HanghoaID);
                    table.ForeignKey(
                        name: "FK_HangHoas_Loais_MaLoaiID",
                        column: x => x.MaLoaiID,
                        principalTable: "Loais",
                        principalColumn: "LoaiID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HangHoas_NhaCungCaps_NhaCungCapID",
                        column: x => x.NhaCungCapID,
                        principalTable: "NhaCungCaps",
                        principalColumn: "NhaCungCapID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "hoaDons",
                columns: table => new
                {
                    HoaDonID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NguoiDungID = table.Column<int>(nullable: false),
                    NgayDat = table.Column<DateTime>(nullable: false),
                    NgayNhan = table.Column<DateTime>(nullable: false),
                    HoTen = table.Column<string>(nullable: true),
                    DiaChi = table.Column<string>(nullable: true),
                    ThanhToanID = table.Column<int>(nullable: false),
                    VanChuyenID = table.Column<int>(nullable: false),
                    PhiVanChuyen = table.Column<double>(nullable: false),
                    TrangThaiID = table.Column<int>(nullable: false),
                    GhiChu = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_hoaDons", x => x.HoaDonID);
                    table.ForeignKey(
                        name: "FK_hoaDons_NguoiDungs_NguoiDungID",
                        column: x => x.NguoiDungID,
                        principalTable: "NguoiDungs",
                        principalColumn: "NguoiDungID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_hoaDons_ThanhToans_ThanhToanID",
                        column: x => x.ThanhToanID,
                        principalTable: "ThanhToans",
                        principalColumn: "ThanhToanID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_hoaDons_TrangThais_TrangThaiID",
                        column: x => x.TrangThaiID,
                        principalTable: "TrangThais",
                        principalColumn: "TrangThaiID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_hoaDons_VanChuyens_VanChuyenID",
                        column: x => x.VanChuyenID,
                        principalTable: "VanChuyens",
                        principalColumn: "VanChuyenID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BinhLuans",
                columns: table => new
                {
                    BinhLuanID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    HangHoaID = table.Column<int>(nullable: false),
                    NoiDung = table.Column<string>(nullable: true),
                    NguoiDungID = table.Column<int>(nullable: false),
                    NgayBl = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BinhLuans", x => x.BinhLuanID);
                    table.ForeignKey(
                        name: "FK_BinhLuans_HangHoas_HangHoaID",
                        column: x => x.HangHoaID,
                        principalTable: "HangHoas",
                        principalColumn: "HanghoaID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BinhLuans_NguoiDungs_NguoiDungID",
                        column: x => x.NguoiDungID,
                        principalTable: "NguoiDungs",
                        principalColumn: "NguoiDungID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Yeutthichs",
                columns: table => new
                {
                    YeuThichID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NguoiDungID = table.Column<int>(nullable: false),
                    HangHoaID = table.Column<int>(nullable: false),
                    NgayChon = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Yeutthichs", x => x.YeuThichID);
                    table.ForeignKey(
                        name: "FK_Yeutthichs_HangHoas_HangHoaID",
                        column: x => x.HangHoaID,
                        principalTable: "HangHoas",
                        principalColumn: "HanghoaID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Yeutthichs_NguoiDungs_NguoiDungID",
                        column: x => x.NguoiDungID,
                        principalTable: "NguoiDungs",
                        principalColumn: "NguoiDungID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "chiTietHds",
                columns: table => new
                {
                    ChiTietHdID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    HoaDonID = table.Column<int>(nullable: false),
                    HangHoaID = table.Column<int>(nullable: false),
                    DonGia = table.Column<double>(nullable: false),
                    SoLuong = table.Column<int>(nullable: false),
                    GiamGia = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_chiTietHds", x => x.ChiTietHdID);
                    table.ForeignKey(
                        name: "FK_chiTietHds_HangHoas_HangHoaID",
                        column: x => x.HangHoaID,
                        principalTable: "HangHoas",
                        principalColumn: "HanghoaID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_chiTietHds_hoaDons_HoaDonID",
                        column: x => x.HoaDonID,
                        principalTable: "hoaDons",
                        principalColumn: "HoaDonID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BinhLuans_HangHoaID",
                table: "BinhLuans",
                column: "HangHoaID");

            migrationBuilder.CreateIndex(
                name: "IX_BinhLuans_NguoiDungID",
                table: "BinhLuans",
                column: "NguoiDungID");

            migrationBuilder.CreateIndex(
                name: "IX_chiTietHds_HangHoaID",
                table: "chiTietHds",
                column: "HangHoaID");

            migrationBuilder.CreateIndex(
                name: "IX_chiTietHds_HoaDonID",
                table: "chiTietHds",
                column: "HoaDonID");

            migrationBuilder.CreateIndex(
                name: "IX_HangHoas_MaLoaiID",
                table: "HangHoas",
                column: "MaLoaiID");

            migrationBuilder.CreateIndex(
                name: "IX_HangHoas_NhaCungCapID",
                table: "HangHoas",
                column: "NhaCungCapID");

            migrationBuilder.CreateIndex(
                name: "IX_hoaDons_NguoiDungID",
                table: "hoaDons",
                column: "NguoiDungID");

            migrationBuilder.CreateIndex(
                name: "IX_hoaDons_ThanhToanID",
                table: "hoaDons",
                column: "ThanhToanID");

            migrationBuilder.CreateIndex(
                name: "IX_hoaDons_TrangThaiID",
                table: "hoaDons",
                column: "TrangThaiID");

            migrationBuilder.CreateIndex(
                name: "IX_hoaDons_VanChuyenID",
                table: "hoaDons",
                column: "VanChuyenID");

            migrationBuilder.CreateIndex(
                name: "IX_NguoiDungs_GioiTinhID",
                table: "NguoiDungs",
                column: "GioiTinhID");

            migrationBuilder.CreateIndex(
                name: "IX_NguoiDungs_LoaiNgDungID",
                table: "NguoiDungs",
                column: "LoaiNgDungID");

            migrationBuilder.CreateIndex(
                name: "IX_Yeutthichs_HangHoaID",
                table: "Yeutthichs",
                column: "HangHoaID");

            migrationBuilder.CreateIndex(
                name: "IX_Yeutthichs_NguoiDungID",
                table: "Yeutthichs",
                column: "NguoiDungID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BinhLuans");

            migrationBuilder.DropTable(
                name: "chiTietHds");

            migrationBuilder.DropTable(
                name: "Yeutthichs");

            migrationBuilder.DropTable(
                name: "hoaDons");

            migrationBuilder.DropTable(
                name: "HangHoas");

            migrationBuilder.DropTable(
                name: "NguoiDungs");

            migrationBuilder.DropTable(
                name: "ThanhToans");

            migrationBuilder.DropTable(
                name: "TrangThais");

            migrationBuilder.DropTable(
                name: "VanChuyens");

            migrationBuilder.DropTable(
                name: "Loais");

            migrationBuilder.DropTable(
                name: "NhaCungCaps");

            migrationBuilder.DropTable(
                name: "GioiTinhs");

            migrationBuilder.DropTable(
                name: "LoaiNgDungs");
        }
    }
}
