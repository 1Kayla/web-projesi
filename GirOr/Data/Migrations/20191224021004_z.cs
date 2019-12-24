using Microsoft.EntityFrameworkCore.Migrations;

namespace GirOr.Data.Migrations
{
    public partial class z : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "girisimAdi",
                table: "TestClass",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "girisimYil",
                table: "TestClass",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "isim",
                table: "TestClass",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "soyisim",
                table: "TestClass",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "girisimAdi",
                table: "TestClass");

            migrationBuilder.DropColumn(
                name: "girisimYil",
                table: "TestClass");

            migrationBuilder.DropColumn(
                name: "isim",
                table: "TestClass");

            migrationBuilder.DropColumn(
                name: "soyisim",
                table: "TestClass");
        }
    }
}
