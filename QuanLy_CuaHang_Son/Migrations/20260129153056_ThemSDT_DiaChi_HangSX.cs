using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuanLy_CuaHang_Son.Migrations
{
    /// <inheritdoc />
    public partial class ThemSDT_DiaChi_HangSX : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DiaChi",
                table: "HangSanXuat",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SoDienThoai",
                table: "HangSanXuat",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DiaChi",
                table: "HangSanXuat");

            migrationBuilder.DropColumn(
                name: "SoDienThoai",
                table: "HangSanXuat");
        }
    }
}
