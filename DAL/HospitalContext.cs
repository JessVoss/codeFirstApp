using codeFirstApp.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace codeFirstApp.DAL
{
    public class HospitalContext : DbContext
    {
        public HospitalContext() : base("HospitalContext")
        {
        }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Encounter> Encounters { get; set; }
        public DbSet<Employee>Employees { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}