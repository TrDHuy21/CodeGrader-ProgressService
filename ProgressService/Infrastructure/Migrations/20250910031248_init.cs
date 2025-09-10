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
<<<<<<<< HEAD:ProgressService/Infrastructure/Migrations/20250909192826_init.cs
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
========
                    Id = table.Column<int>(type: "int", nullable: false),
>>>>>>>> implementProcessService:ProgressService/Infrastructure/Migrations/20250910031248_init.cs
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
<<<<<<<< HEAD:ProgressService/Infrastructure/Migrations/20250909192826_init.cs
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
========
                    Id = table.Column<int>(type: "int", nullable: false),
>>>>>>>> implementProcessService:ProgressService/Infrastructure/Migrations/20250910031248_init.cs
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
                values: new object[] { 1, 9, 1 });

            migrationBuilder.InsertData(
                table: "Submission",
                columns: new[] { "Id", "Point", "ProblemId", "ProgrammingLanguage", "SubmissionAt", "UserId", "Algorithm", "CleanCode" },
<<<<<<<< HEAD:ProgressService/Infrastructure/Migrations/20250909192826_init.cs
                values: new object[] { 1, 9, 1, "c sharp", new DateTime(2025, 9, 10, 2, 28, 25, 375, DateTimeKind.Local).AddTicks(7899), 2, "Algorithm is correct and efficient for the given task. No issues detected.", "Code is readable and follows basic C++ conventions. Could benefit from comments for clarity." });
========
                values: new object[] { 1, 9, 1, "c sharp", new DateTime(2025, 9, 10, 10, 12, 47, 538, DateTimeKind.Local).AddTicks(5051), 2, "Algorithm is correct and efficient for the given task. No issues detected.", "Code is readable and follows basic C++ conventions. Could benefit from comments for clarity." });
>>>>>>>> implementProcessService:ProgressService/Infrastructure/Migrations/20250910031248_init.cs

            migrationBuilder.InsertData(
                table: "UserProgress",
                columns: new[] { "Id", "EasySolved", "HardSolved", "MediumSolved", "Rank", "TotalSubmission" },
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
