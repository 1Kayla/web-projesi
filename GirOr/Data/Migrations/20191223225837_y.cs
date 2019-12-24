using Microsoft.EntityFrameworkCore.Migrations;

namespace GirOr.Data.Migrations
{
    public partial class y : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "fkUser",
                table: "TestClass",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TestClass_fkUser",
                table: "TestClass",
                column: "fkUser");

            migrationBuilder.AddForeignKey(
                name: "FK_TestClass_AspNetUsers_fkUser",
                table: "TestClass",
                column: "fkUser",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TestClass_AspNetUsers_fkUser",
                table: "TestClass");

            migrationBuilder.DropIndex(
                name: "IX_TestClass_fkUser",
                table: "TestClass");

            migrationBuilder.DropColumn(
                name: "fkUser",
                table: "TestClass");
        }
    }
}
