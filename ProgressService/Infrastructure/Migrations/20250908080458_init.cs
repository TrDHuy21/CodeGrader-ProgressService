using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProblemStats",
                columns: table => new
                {
                    ProblemId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TotalSubmisstion = table.Column<int>(type: "int", nullable: false),
                    AvgPoint = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProblemStats", x => x.ProblemId);
                });

            migrationBuilder.CreateTable(
                name: "Submission",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ProblemId = table.Column<int>(type: "int", nullable: false),
                    Language = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Point = table.Column<int>(type: "int", nullable: false),
                    SubmisstionAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Algorithm = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CleanCode = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Submission", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserProgress",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TotalSubmisstion = table.Column<int>(type: "int", nullable: false),
                    EasySolved = table.Column<int>(type: "int", nullable: false),
                    MediumSolved = table.Column<int>(type: "int", nullable: false),
                    HardSolved = table.Column<int>(type: "int", nullable: false),
                    Rank = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserProgress", x => x.UserId);
                });

            migrationBuilder.InsertData(
                table: "ProblemStats",
                columns: new[] { "ProblemId", "AvgPoint", "TotalSubmisstion" },
                values: new object[] { 1, 9, 1 });

            migrationBuilder.InsertData(
                table: "Submission",
                columns: new[] { "Id", "Language", "Point", "ProblemId", "SubmisstionAt", "UserId", "Algorithm", "CleanCode" },
                values: new object[] { 1, "c sharp", 9, 1, new DateTime(2025, 9, 8, 15, 4, 57, 369, DateTimeKind.Local).AddTicks(7662), 2, "Algorithm is correct and efficient for the given task. No issues detected.", "Code is readable and follows basic C++ conventions. Could benefit from comments for clarity." });

            migrationBuilder.InsertData(
                table: "UserProgress",
                columns: new[] { "UserId", "EasySolved", "HardSolved", "MediumSolved", "Rank", "TotalSubmisstion" },
                values: new object[] { 1, 1, 0, 0, 900, 1 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProblemStats");

            migrationBuilder.DropTable(
                name: "Submission");

            migrationBuilder.DropTable(
                name: "UserProgress");
        }
    }
}
