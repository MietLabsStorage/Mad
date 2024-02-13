using Mad.Database.Models;
using Mad.Shared;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Mad.Database
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Note> Notes { get; set; }

        public DatabaseContext()
        {
            SQLitePCL.Batteries_V2.Init();
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string dbPath = Path.Combine(Paths.Db ?? Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), $"{Paths.AppName}.db3");
            optionsBuilder.UseSqlite($"Filename={dbPath}");
        }
    }
}