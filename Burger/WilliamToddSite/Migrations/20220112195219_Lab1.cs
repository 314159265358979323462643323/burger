using Microsoft.EntityFrameworkCore.Migrations;

namespace WilliamToddSite.Migrations
{
    public partial class Lab1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Page",
                table: "Forum",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Forum",
                keyColumn: "CommentId",
                keyValue: 1,
                column: "Text",
                value: "this is asample comment");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Page",
                table: "Forum",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);

            migrationBuilder.UpdateData(
                table: "Forum",
                keyColumn: "CommentId",
                keyValue: 1,
                column: "Text",
                value: "this is a sample comment");
        }
    }
}
