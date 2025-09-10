using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.ValueEntities;
using Infrastructure.Config;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Contexts
{
    public class ProgressContext : DbContext
    {
        public ProgressContext(DbContextOptions options) : base(options)
        {
        }

        protected ProgressContext()
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new SubmissionConfig());
            modelBuilder.ApplyConfiguration(new ProblemStatsConfig());
            modelBuilder.ApplyConfiguration(new UserProgressConfig());

            modelBuilder.Entity<Submission>().HasData(
                new Submission()
                {
                    Id = 1,
                    UserId = 2,
                    ProblemId = 1,
                    ProgrammingLanguage = "c sharp",
                    Point = 9,
                    SubmissionAt = DateTime.Now,
                },
                new Submission()
                {
                    Id = 2,
                    UserId = 1,
                    ProblemId = 1,
                    ProgrammingLanguage = "java",
                    Point = 8,
                    SubmissionAt = DateTime.Now,
                },
                new Submission()
                {
                    Id = 3,
                    UserId = 2,
                    ProblemId = 2,
                    ProgrammingLanguage = "python",
                    Point = 7,
                    SubmissionAt = DateTime.Now,
                },
                new Submission()
                {
                    Id = 4,
                    UserId = 1,
                    ProblemId = 1,
                    ProgrammingLanguage = "c++",
                    Point = 6,
                    SubmissionAt = DateTime.Now,
                },
                new Submission()
                {
                    Id = 5,
                    UserId = 2,
                    ProblemId = 1,
                    ProgrammingLanguage = "c++",
                    Point = 5,
                    SubmissionAt = DateTime.Now,
                }
            );
            modelBuilder.Entity<Submission>().OwnsOne(s => s.EvaluationCriteria).HasData(
                new  { SubmissionId = 1, Algorithm = "Correct & efficient", CleanCode = "Readable, basic C# conventions, could use comments" },
                new  { SubmissionId = 2, Algorithm = "Correct but could be optimized", CleanCode = "Generally clean, some inconsistent naming" },
                new  { SubmissionId = 3, Algorithm = "Minor flaws, edge cases", CleanCode = "Somewhat messy, poor indentation" },
                new  { SubmissionId = 4, Algorithm = "Inefficient, large inputs", CleanCode = "Difficult to read, poor variable names, no comments" },
                new  { SubmissionId = 5, Algorithm = "Incorrect, doesn't solve problem", CleanCode = "Very messy, unstructured, hard to follow" }
             );

            modelBuilder.Entity<ProblemStats>().HasData(
                new ProblemStats()
                {
                    Id = 1,
                    TotalSubmission = 4,
                    AvgPoint = 10
                },
                new ProblemStats()
                {
                    Id = 2,
                    TotalSubmission = 1,
                    AvgPoint = 7
                }          
            );

            modelBuilder.Entity<UserProgress>().HasData(
                new UserProgress()
                {
                    Id = 1,
                    EasySolved = 2,
                    MediumSolved = 0,
                    HardSolved = 0,
                    Rank = 900,
                    TotalSubmission = 2
                },
                new UserProgress()
                {
                    Id = 2,
                    EasySolved = 2,
                    MediumSolved = 1,
                    HardSolved = 0,
                    Rank = 700,
                    TotalSubmission = 3
                }
            );
        }

        public DbSet<ProblemStats> ProblemStats { get; set; }
        public DbSet<Submission> Submission { get; set; }
        public DbSet<UserProgress> UserProgress { get; set; }
    }
}
