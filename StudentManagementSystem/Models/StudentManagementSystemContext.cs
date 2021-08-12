using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace StudentManagementSystem.Models
{
    public class StudentManagementSystemContext : DbContext
    {
        public StudentManagementSystemContext
            (DbContextOptions<StudentManagementSystemContext> options)
            : base(options)
        { }

        public DbSet<Diploma> Diploma { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Module> Modules { get; set; }
        public DbSet<StudentModules> StudentModules { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Address>()
                .HasOne(i => i.Student)
                .WithOne(c => c.Address)
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Student>()
                .HasOne<Address>(s => s.Address)
                .WithOne(ad => ad.Student)
                .HasForeignKey<Address>(ad => ad.AdminNo);

            //modelBuilder.Entity<Address>()
            //   .Property(e => e.AddressId)
            //   .ValueGeneratedOnAddOrUpdate()
            //   .HasComputedColumnSql("[PreFix]+ RIGHT('0000000' + CAST(Id AS VARCHAR(7)), 7)");


            modelBuilder.Entity<StudentModules>()
                .HasKey(sm => new { sm.AdminNo, sm.ModuleId });

            modelBuilder.Entity<StudentModules>()
                .HasOne(s => s.Student)
                .WithMany(sm => sm.StudentModules)
                .HasForeignKey(s => s.AdminNo);

            modelBuilder.Entity<StudentModules>()
                .HasOne(m => m.Module)
                .WithMany(sm => sm.StudentModules)
                .HasForeignKey(m => m.ModuleId);

            modelBuilder.Entity<Diploma>().HasData(
         new Diploma
         {
             DiplomaId = "C36",
             Name = "Common ICT Programme"
         },
         new Diploma
         {
             DiplomaId = "C35",
             Name = "Business & Financial Technology"
         },
         new Diploma
         {
             DiplomaId = "C43",
             Name = "Business & Financial Technology"
         },
         new Diploma
         {
             DiplomaId = "C54",
             Name = "Cybersecurity & Digital Forensics "
         },
         new Diploma
         {
             DiplomaId = "C80",
             Name = "Infocomm & Security "
         },
         new Diploma
         {
             DiplomaId = "C85",
             Name = "Information Technology  "
         }
        );

            modelBuilder.Entity<Module>().HasData(
             new Module
             {
                 ModuleId = "IT1010",
                 Name = "Data Analysis & Visualisation"
             },
             new Module
             {
                 ModuleId = "IT1020",
                 Name = "Fundamentals of Innovation & Enterprise"
             },
             new Module
             {
                 ModuleId = "IT1030",
                 Name = "Infocomm Security"
             },
             new Module
             {
                 ModuleId = "IT1040",
                 Name = "Network Technology"
             },
             new Module
             {
                 ModuleId = "IT1050",
                 Name = "Web Development"
             },
             new Module
             {
                 ModuleId = "IT1060",
                 Name = "Programming Essentials"
             },
             new Module
             {
                 ModuleId = "ITX150",
                 Name = "App Development Project"
             }
            );

        }
    }
}
