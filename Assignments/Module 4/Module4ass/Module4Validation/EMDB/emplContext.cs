using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Module4Validation.EMDB
{
    public partial class emplContext : DbContext
    {
        public emplContext()
        {
        }

        public emplContext(DbContextOptions<emplContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Emdtable> Emdtables { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
//            if (!optionsBuilder.IsConfigured)
//            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
//                optionsBuilder.UseSqlServer("Server=LAPTOP-N0SPIGBI\\SQLEXPRESS;Database=empl;Integrated Security=True");
//            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Emdtable>(entity =>
            {
                entity.HasKey(e => e.EmpId);

                entity.ToTable("EMDTable");

                entity.Property(e => e.EmpId).HasColumnName("emp_id");

                entity.Property(e => e.EmpAge)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("emp_age");

                entity.Property(e => e.EmpContact)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("emp_contact");

                entity.Property(e => e.EmpMail)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("emp_mail");

                entity.Property(e => e.EmpName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("emp_name");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
