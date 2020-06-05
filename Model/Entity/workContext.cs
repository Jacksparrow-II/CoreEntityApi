using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CoreEntityApi.Model.Entity
{
    public partial class workContext : DbContext
    {
        public workContext()
        {
        }

        public workContext(DbContextOptions<workContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Department> Department { get; set; }
        public virtual DbSet<Designation> Designation { get; set; }
        public virtual DbSet<Employes> Employes { get; set; }
        public virtual DbSet<Student> Student { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=work;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>(entity =>
            {
                entity.Property(e => e.DepartmentName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Designation>(entity =>
            {
                entity.Property(e => e.DesignationName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Employes>(entity =>
            {
                entity.ToTable("employes");

                entity.Property(e => e.Dob)
                    .HasColumnName("DOB")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Gender)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                //entity.HasOne(d => d.DepartmentNavigation)
                //    .WithMany(p => p.Employes)
                //    .HasForeignKey(d => d.Department)
                //    .HasConstraintName("FK__employes__Depart__756D6ECB");

                //entity.HasOne(d => d.DesignationNavigation)
                //    .WithMany(p => p.Employes)
                //    .HasForeignKey(d => d.Designation)
                //    .HasConstraintName("FK__employes__Design__76619304");
            });

            modelBuilder.Entity<Student>(entity =>
            {
                entity.HasKey(e => e.Sid)
                    .HasName("PK__student__DDDFDD36C28151A1");

                entity.ToTable("student");

                entity.Property(e => e.Sid).HasColumnName("sid");

                entity.Property(e => e.Address)
                    .HasColumnName("address")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Cource)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Dob)
                    .HasColumnName("dob")
                    .HasColumnType("date");

                entity.Property(e => e.Marks)
                    .HasColumnName("marks")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.Sname)
                    .HasColumnName("sname")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
