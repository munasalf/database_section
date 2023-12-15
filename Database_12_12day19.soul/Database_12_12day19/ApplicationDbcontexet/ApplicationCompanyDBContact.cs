using Database_12_12day19.Modeels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database_12_12day19.ApplicationDbcontexet
{
    internal class ApplicationCompanyDBContact : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-H0S7VNS\\MSSQLSERVER02;Initial catalog = CompanyProdect ;Integrated Security=True;");

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Project>().Property(x => x.projName).
                IsRequired().HasMaxLength(50);

            modelBuilder.Entity<EmployeeInformation>().Property(w => w.DepId). 
                IsRequired().HasMaxLength(50);

            modelBuilder.Entity<DepartmentEmp>().Property(z=> z.DepName).IsRequired().HasMaxLength(50);

        }
        public DbSet< EmployeeInformation > EmployeeInformations { get; set; }
        public DbSet<DepartmentEmp> DepartmentEmps { get; set; }
        public DbSet<Project> projects { get; set; }
    }
}                                                      