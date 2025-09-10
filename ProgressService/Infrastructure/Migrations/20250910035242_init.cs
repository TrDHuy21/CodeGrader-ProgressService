using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

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
                    Id = table.Column<int>(type: "int", nullable: false),
                    TotalSubmission = table.Column<int>(type: "int", nullable: false),
                    AvgPoint = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProblemStats", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Submission",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ProblemId = table.Column<int>(type: "int", nullable: false),
                    ProgrammingLanguage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Point = table.Column<int>(type: "int", nullable: false),
                    SubmissionAt = table.Column<DateTime>(type: "datetime2", nullable: false),
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
                    Id = table.Column<int>(type: "int", nullable: false),
                    TotalSubmission = table.Column<int>(type: "int", nullable: false),
                    EasySolved = table.Column<int>(type: "int", nullable: false),
                    MediumSolved = table.Column<int>(type: "int", nullable: false),
                    HardSolved = table.Column<int>(type: "int", nullable: false),
                    Rank = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserProgress", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "ProblemStats",
                columns: new[] { "Id", "AvgPoint", "TotalSubmission" },
                values: new object[,]
                {
                    { 1, 10, 4 },
                    { 2, 7, 1 }
                });

            migrationBuilder.InsertData(
                table: "Submission",
                columns: new[] { "Id", "Point", "ProblemId", "ProgrammingLanguage", "SubmissionAt", "UserId", "Algorithm", "CleanCode" },
                values: new object[,]
                {
                    { 1, 9, 1, "c sharp", new DateTime(2025, 9, 10, 10, 52, 40, 861, DateTimeKind.Local).AddTicks(582), 2, "Correct & efficient", "Readable, basic C# conventions, could use comments" },
                    { 2, 8, 1, "java", new DateTime(2025, 9, 10, 10, 52, 40, 861, DateTimeKind.Local).AddTicks(595), 1, "Correct but could be optimized", "Generally clean, some inconsistent naming" },
                    { 3, 7, 2, "python", new DateTime(2025, 9, 10, 10, 52, 40, 861, DateTimeKind.Local).AddTicks(637), 2, "Minor flaws, edge cases", "Somewhat messy, poor indentation" },
                    { 4, 6, 1, "c++", new DateTime(2025, 9, 10, 10, 52, 40, 861, DateTimeKind.Local).AddTicks(638), 1, "Inefficient, large inputs", "Difficult to read, poor variable names, no comments" },
                    { 5, 5, 1, "c++", new DateTime(2025, 9, 10, 10, 52, 40, 861, DateTimeKind.Local).AddTicks(639), 2, "Incorrect, doesn't solve problem", "Very messy, unstructured, hard to follow" }
                });

            migrationBuilder.InsertData(
                table: "UserProgress",
                columns: new[] { "Id", "EasySolved", "HardSolved", "MediumSolved", "Rank", "TotalSubmission" },
                values: new object[,]
                {
                    { 1, 2, 0, 0, 900, 2 },
                    { 2, 2, 0, 1, 700, 3 }
                });
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
