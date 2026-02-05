using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuanLy_CuaHang_Son.Migrations
{
    /// <inheritdoc />
    public partial class AddNgaySinh_HinhThucLamViec_GioiTinh_ToNhanVien : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "GioiTinh",
                table: "NhanVien",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "HinhThucLamViec",
                table: "NhanVien",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "NgaySinh",
                table: "NhanVien",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GioiTinh",
                table: "NhanVien");

            migrationBuilder.DropColumn(
                name: "HinhThucLamViec",
                table: "NhanVien");

            migrationBuilder.DropColumn(
                name: "NgaySinh",
                table: "NhanVien");
        }
    }
}
