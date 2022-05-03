using Microsoft.EntityFrameworkCore;
using ServerDAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerDAL.Context
{
    public class DataLibrary: DbContext
    {
        public DataLibrary()
        {
            Database.EnsureCreated();
        }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<PeopleInfo> PeopleInfos { get; set; }
        public DbSet<Disease> Diseases { get; set; }
        public DbSet<Analysis> Analyses { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"DataSource=DoctorProjectDB.db");
        }
    }
}
