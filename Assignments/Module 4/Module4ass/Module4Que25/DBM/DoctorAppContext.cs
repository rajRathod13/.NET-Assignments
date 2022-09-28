using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Module4Que25.DBM
{
    public partial class DoctorAppContext : DbContext
    {
        public DoctorAppContext()
        {
        }

        public DoctorAppContext(DbContextOptions<DoctorAppContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AdminTable> AdminTables { get; set; }
        public virtual DbSet<CityTable> CityTables { get; set; }
        public virtual DbSet<DoctorTable> DoctorTables { get; set; }
        public virtual DbSet<HospitalTable> HospitalTables { get; set; }
        public virtual DbSet<PatientTable> PatientTables { get; set; }
        public virtual DbSet<StateTable> StateTables { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
//            if (!optionsBuilder.IsConfigured)
//            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
//                optionsBuilder.UseSqlServer("Server=LAPTOP-N0SPIGBI\\SQLEXPRESS;Database=DoctorApp;Integrated Security=True");
//            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<AdminTable>(entity =>
            {
                entity.HasKey(e => e.AdminId);

                entity.ToTable("AdminTable");

                entity.Property(e => e.AdminId).HasColumnName("admin_id");

                entity.Property(e => e.AdminFname)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("admin_fname");

                entity.Property(e => e.AdminLname)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("admin_lname");

                entity.Property(e => e.AdminMail)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("admin_mail");

                entity.Property(e => e.AdminPass)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("admin_pass");
            });

            modelBuilder.Entity<CityTable>(entity =>
            {
                entity.HasKey(e => e.CityId);

                entity.ToTable("CityTable");

                entity.Property(e => e.CityId).HasColumnName("city_id");

                entity.Property(e => e.CityName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("city_name");

                entity.Property(e => e.StateId).HasColumnName("state_id");

                entity.HasOne(d => d.State)
                    .WithMany(p => p.CityTables)
                    .HasForeignKey(d => d.StateId)
                    .HasConstraintName("FK_CityTable_CityTable");
            });

            modelBuilder.Entity<DoctorTable>(entity =>
            {
                entity.HasKey(e => e.DoctorId);

                entity.ToTable("DoctorTable");

                entity.Property(e => e.DoctorId).HasColumnName("doctor_id");

                entity.Property(e => e.DoctorContact)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("doctor_contact");

                entity.Property(e => e.DoctorDegree)
                    .IsRequired()
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("doctor_degree");

                entity.Property(e => e.DoctorFname)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("doctor_fname");

                entity.Property(e => e.DoctorLname)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("doctor_lname");

                entity.Property(e => e.DoctorMail)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("doctor_mail");

                entity.Property(e => e.DoctorPass)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("doctor_pass");

                entity.Property(e => e.DoctorProfileimg)
                    .IsUnicode(false)
                    .HasColumnName("doctor_profileimg");

                entity.Property(e => e.DoctorSpeciality)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("doctor_speciality");

                entity.Property(e => e.HospitalId).HasColumnName("hospital_id");

                entity.HasOne(d => d.Hospital)
                    .WithMany(p => p.DoctorTables)
                    .HasForeignKey(d => d.HospitalId)
                    .HasConstraintName("FK_DoctorTable_HospitalTable");
            });

            modelBuilder.Entity<HospitalTable>(entity =>
            {
                entity.HasKey(e => e.HospitalId);

                entity.ToTable("HospitalTable");

                entity.Property(e => e.HospitalId).HasColumnName("hospital_id");

                entity.Property(e => e.CityId).HasColumnName("city_id");

                entity.Property(e => e.HospitalAdd)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("hospital_add");

                entity.Property(e => e.HospitalContact)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("hospital_contact");

                entity.Property(e => e.HospitalMail)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("hospital_mail");

                entity.Property(e => e.HospitalName)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("hospital_name");

                entity.Property(e => e.HospitalPass)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("hospital_pass");

                entity.Property(e => e.HospitalProfileimg)
                    .IsUnicode(false)
                    .HasColumnName("hospital_profileimg");

                entity.Property(e => e.StateId).HasColumnName("state_id");

                entity.HasOne(d => d.City)
                    .WithMany(p => p.HospitalTables)
                    .HasForeignKey(d => d.CityId)
                    .HasConstraintName("FK_HospitalTable_CityTable");

                entity.HasOne(d => d.State)
                    .WithMany(p => p.HospitalTables)
                    .HasForeignKey(d => d.StateId)
                    .HasConstraintName("FK_HospitalTable_StateTable");
            });

            modelBuilder.Entity<PatientTable>(entity =>
            {
                entity.HasKey(e => e.PatientId);

                entity.ToTable("PatientTable");

                entity.Property(e => e.PatientId).HasColumnName("patient_id");

                entity.Property(e => e.CityId).HasColumnName("city_id");

                entity.Property(e => e.PatientAdd)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("patient_add");

                entity.Property(e => e.PatientContact)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("patient_contact");

                entity.Property(e => e.PatientDob)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("patient_dob");

                entity.Property(e => e.PatientFname)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("patient_fname");

                entity.Property(e => e.PatientLname)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("patient_lname");

                entity.Property(e => e.PatientMail)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("patient_mail");

                entity.Property(e => e.PatientPass)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("patient_pass");

                entity.Property(e => e.StateId).HasColumnName("state_id");

                entity.HasOne(d => d.City)
                    .WithMany(p => p.PatientTables)
                    .HasForeignKey(d => d.CityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PatientTable_CityTable");

                entity.HasOne(d => d.State)
                    .WithMany(p => p.PatientTables)
                    .HasForeignKey(d => d.StateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PatientTable_StateTable");
            });

            modelBuilder.Entity<StateTable>(entity =>
            {
                entity.HasKey(e => e.StateId);

                entity.ToTable("StateTable");

                entity.Property(e => e.StateId).HasColumnName("state_id");

                entity.Property(e => e.StateName)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("state_name");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
