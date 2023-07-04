using Microsoft.EntityFrameworkCore;

namespace WebApplication7.Models
{
    public class BloggingContext : DbContext
    {
        public DbSet<Exam> Exam { get; set; }

        public DbSet<Material> Material { get; set; }

        public string DbPath { get; }


        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(@"Server=DESKTOP-SV5M2H9\SQLEXPRESS;Database=Application;Trusted_Connection=True;trustServerCertificate=true;");
        }
    }
}

