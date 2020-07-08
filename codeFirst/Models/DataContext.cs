using Microsoft.EntityFrameworkCore;

namespace codeFirst.Models
{
    public class DataContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
                optionsBuilder.UseSqlServer(@"Server=DESKTOP-012MFIK\SQLEXPRESS;Database=codefirst;Trusted_Connection=True;MultipleActiveResultSets=true");
        }

        public virtual DbSet<Lop> Lop {get;set;}
        public virtual DbSet<SinhVien> SinhVien {get;set;}

        protected override void OnModelCreating(ModelBuilder builder){
            base.OnModelCreating(builder);
            var lop = new Lop(){
                IdLop = 1,
                NameLop = "16T3"
            };

            var sinhvien = new SinhVien(){
                Mssv = "102160135",
                Age = 22,
                NameSv= "Duy",
                IdLop = 1
            };

            builder.Entity<Lop>().HasData(lop);
            builder.Entity<SinhVien>().HasData(sinhvien);
        }
    }
}