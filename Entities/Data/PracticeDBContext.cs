using Microsoft.EntityFrameworkCore;

namespace Entities.Data.Models
{
    public partial class PracticeDBContext : DbContext
    {
        public PracticeDBContext()
        {
        }

        public PracticeDBContext(DbContextOptions<PracticeDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Person> Person { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=DESKTOP-9SADJTA;Database=PracticeDB;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Address)
                    .HasColumnName("address")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Bdate)
                    .HasColumnName("bdate")
                    .HasColumnType("date");

                entity.Property(e => e.Fname)
                    .HasColumnName("fname")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Lname)
                    .HasColumnName("lname")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
