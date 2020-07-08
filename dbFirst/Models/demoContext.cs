using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace dbFirst.Models
{
    public partial class demoContext : DbContext
    {
        public demoContext()
        {
        }

        public demoContext(DbContextOptions<demoContext> options)
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
                optionsBuilder.UseSqlServer("Server=DESKTOP-012MFIK\\SQLEXPRESS;Database=demo;Trusted_Connection=True;");
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

                entity.Property(e => e.Mssv)
                    .HasColumnName("MSSV")
                    .ValueGeneratedNever();

                entity.Property(e => e.Birthday).HasColumnType("datetime");

                entity.Property(e => e.Dtb).HasColumnName("DTB");

                entity.Property(e => e.IdLop).HasColumnName("ID_Lop");

                entity.Property(e => e.NameSv).HasColumnName("NameSV");

                entity.HasOne(d => d.IdLopNavigation)
                    .WithMany(p => p.Sv)
                    .HasForeignKey(d => d.IdLop)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SV_Lop");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
