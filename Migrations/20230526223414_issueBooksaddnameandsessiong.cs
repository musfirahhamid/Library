using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Library.Migrations
{
    public partial class issueBooksaddnameandsessiong : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FullName",
                table: "issueBooks");

            migrationBuilder.DropColumn(
                name: "RollNumber",
                table: "issueBooks");

            migrationBuilder.RenameColumn(
                name: "Session",
                table: "issueBooks",
                newName: "StudentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "StudentId",
                table: "issueBooks",
                newName: "Session");

            migrationBuilder.AddColumn<string>(
                name: "FullName",
                table: "issueBooks",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "RollNumber",
                table: "issueBooks",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
