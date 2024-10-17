using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
namespace Models
{
    public class Eemployeess
    {
        [Key]
        public int EID { get; set; }
        public string Name { get; set; } = string.Empty;
        public int DID { get; set; }
    }

    public class EemployeessLeave
    {
        [Key]
        public int LeaveID { get; set; }
        public int EemployeID { get; set; }
        public int NumOfDays { get; set; }
    }

    public class EemployeessContext : DbContext
    {
        public DbSet<Eemployeess> Eemployeess { get; set; }
        public DbSet<EemployeessLeave> EemployeessLeaves { get; set; }
        public string Dbpath { get; }

        public EemployeessContext()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            Dbpath = System.IO.Path.Join(path, "LeaveManagement4.db");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
      => options.UseSqlite($"Data Source={Dbpath}");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Eemployeess>().HasKey(k => k.EID);

            modelBuilder.Entity<EemployeessLeave>().HasKey(k => k.LeaveID);

        }
    }
}
