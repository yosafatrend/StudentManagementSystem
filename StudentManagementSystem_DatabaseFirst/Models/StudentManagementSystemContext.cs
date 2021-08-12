using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace StudentManagementSystem_DatabaseFirst.Models
{
    public partial class StudentManagementSystemContext : DbContext
    {
        public StudentManagementSystemContext()
        {
        }

        public StudentManagementSystemContext(DbContextOptions<StudentManagementSystemContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Address> Addresses { get; set; }
        public virtual DbSet<Diploma> Diplomas { get; set; }
        public virtual DbSet<Module> Modules { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<StudentModule> StudentModules { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=LAPTOP-GNAT0A1E;Database=StudentManagementSystem;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Address>(entity =>
            {
                entity.Property(e => e.StreetName).IsRequired();
            });

            modelBuilder.Entity<Diploma>(entity =>
            {
                entity.ToTable("Diploma");
            });

            modelBuilder.Entity<Student>(entity =>
            {
                entity.HasKey(e => e.AdminNo);

                entity.HasIndex(e => e.DiplomaId, "IX_Students_DiplomaId");

                entity.Property(e => e.ContactNumber).IsRequired();

                entity.Property(e => e.DiplomaId).IsRequired();

                entity.Property(e => e.Gender)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.Name).IsRequired();

                entity.HasOne(d => d.AdminNoNavigation)
                    .WithOne(p => p.Student)
                    .HasForeignKey<Student>(d => d.AdminNo);

                entity.HasOne(d => d.Diploma)
                    .WithMany(p => p.Students)
                    .HasForeignKey(d => d.DiplomaId);
            });

            modelBuilder.Entity<StudentModule>(entity =>
            {
                entity.HasKey(e => new { e.AdminNo, e.ModuleId });

                entity.HasIndex(e => e.ModuleId, "IX_StudentModules_ModuleId");

                entity.HasOne(d => d.AdminNoNavigation)
                    .WithMany(p => p.StudentModules)
                    .HasForeignKey(d => d.AdminNo);

                entity.HasOne(d => d.Module)
                    .WithMany(p => p.StudentModules)
                    .HasForeignKey(d => d.ModuleId);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
