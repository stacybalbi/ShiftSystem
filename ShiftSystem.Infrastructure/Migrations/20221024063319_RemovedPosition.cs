using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShiftSystem.Infrastructure.Migrations
{
    public partial class RemovedPosition : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Position",
                table: "QueuePerson");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Position",
                table: "QueuePerson",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
