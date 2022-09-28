using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Module4Que19.CountryDB
{
    public partial class CountryContext : DbContext
    {
        public CountryContext()
        {
        }

        public CountryContext(DbContextOptions<CountryContext> options)
            : base(options)
        {
        }

        public virtual DbSet<CityTable> CityTables { get; set; }
        public virtual DbSet<CountryTable> CountryTables { get; set; }
        public virtual DbSet<StateTable> StateTables { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
//            if (!optionsBuilder.IsConfigured)
//            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
//                optionsBuilder.UseSqlServer("Server=LAPTOP-N0SPIGBI\\SQLEXPRESS;Database=Country;Integrated Security=True");
//            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<CityTable>(entity =>
            {
                entity.HasKey(e => e.CityId);

                entity.ToTable("CityTable");

                entity.Property(e => e.CityId).HasColumnName("city_id");

                entity.Property(e => e.CityName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("city_name");

                entity.Property(e => e.CountryId).HasColumnName("country_id");

                entity.Property(e => e.StateId).HasColumnName("state_id");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.CityTables)
                    .HasForeignKey(d => d.CountryId)
                    .HasConstraintName("FK_CityTable_CountryTable");

                entity.HasOne(d => d.State)
                    .WithMany(p => p.CityTables)
                    .HasForeignKey(d => d.StateId)
                    .HasConstraintName("FK_CityTable_StateTable");
            });

            modelBuilder.Entity<CountryTable>(entity =>
            {
                entity.HasKey(e => e.CountryId);

                entity.ToTable("CountryTable");

                entity.Property(e => e.CountryId).HasColumnName("country_id");

                entity.Property(e => e.CountryName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("country_name");
            });

            modelBuilder.Entity<StateTable>(entity =>
            {
                entity.HasKey(e => e.StateId);

                entity.ToTable("StateTable");

                entity.Property(e => e.StateId).HasColumnName("state_id");

                entity.Property(e => e.CountryId).HasColumnName("country_id");

                entity.Property(e => e.StateName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("state_name");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.StateTables)
                    .HasForeignKey(d => d.CountryId)
                    .HasConstraintName("FK_StateTable_StateTable");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
