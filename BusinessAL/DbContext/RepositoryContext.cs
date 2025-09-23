using DataAL.Models;
using DataAL.SeedData;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessAL.DbContext
{
    public class RepositoryContext : IdentityDbContext<ApplicationUser>
    {
        public RepositoryContext(DbContextOptions<RepositoryContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            RepositoryContextInitializer.RunSeedDataOnModelCreating(builder);
            base.OnModelCreating(builder);
        }

        #region Common
        public DbSet<Office> Office { get; set; }
        public DbSet<Section> Section { get; set; }
        public DbSet<Nationality> Nationality { get; set; }
        public DbSet<Country> Country { get; set; }
        public DbSet<State> State { get; set; }
        public DbSet<City> City { get; set; }
        public DbSet<Locality> Locality { get; set; }
        public DbSet<BloodGroup> BloodGroup { get; set; }
        public DbSet<Gender> Gender { get; set; }
        public DbSet<Religion> Religion { get; set; }
        public DbSet<MaritalStatus> MaritalStatus { get; set; }
        public DbSet<Designation> Designation { get; set; }
        public DbSet<SalaryGrade> SalaryGrade { get; set; }
        public DbSet<DivisionOrClass> DivisionOrClass { get; set; }
        public DbSet<Language> Language { get; set; }
        public DbSet<Degree> Degree { get; set; }

        public DbSet<PersonalInformation> PersonalInformation { get; set; }

        #endregion
    }
}
