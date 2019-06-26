using Microsoft.EntityFrameworkCore.Migrations;

namespace PlannerApp.Migrations
{
    public partial class addUserIdToTasks : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "TaskInfos",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserId",
                table: "TaskInfos");
        }
    }
}
