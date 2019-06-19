using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PlannerApp.Migrations
{
    public partial class UpgradeTaskInfo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "TaskInfos",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "TaskInfos",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Date",
                table: "TaskInfos");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "TaskInfos");
        }
    }
}
