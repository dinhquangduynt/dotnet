using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace _4_4_2020.Models
{
    public partial class QLSVContext : DbContext
    {
        public QLSVContext()
        {
        }

        public QLSVContext(DbContextOptions<QLSVContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Lop> Lop { get; set; }
        public virtual DbSet<Sv> Sv { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=DESKTOP-012MFIK\\SQLEXPRESS;Database=QLSV;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Lop>(entity =>
            {
                entity.HasKey(e => e.IdLop);

                entity.Property(e => e.IdLop)
                    .HasColumnName("ID_Lop")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<Sv>(entity =>
            {
                entity.HasKey(e => e.Mssv);

                entity.ToTable("SV");

                entity.Property(e => e.Mssv).HasColumnName("MSSV");

                entity.Property(e => e.Birthday).HasColumnType("datetime");

                entity.Property(e => e.Dtb).HasColumnName("DTB");

                entity.Property(e => e.NameLop).IsRequired();

                entity.Property(e => e.NameSv).HasColumnName("NameSV");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
