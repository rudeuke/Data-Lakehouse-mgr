using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace application.Migrations
{
    public partial class FixNaming : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Contents",
                table: "Files",
                newName: "Content");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Content",
                table: "Files",
                newName: "Contents");
        }
    }
}
