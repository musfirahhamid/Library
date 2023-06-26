using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Library.Migrations
{
    public partial class changedts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "RollNumber",
                table: "students",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(150)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RollNumber",
                table: "students",
                type: "varchar(150)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }
    }
}
