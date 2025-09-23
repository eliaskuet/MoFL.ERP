using DataAL.Models;
using DataAL.SeedData;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessAL.DbContext
{
    public class RepositoryContextInitializer
    {
        public static void RunSeed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<RepositoryContext>();
                context.Database.EnsureCreated();

                try
                {
                    #region Master Seed

                    if (!context.BloodGroup.Any())
                    {
                        context.BloodGroup.AddRange(SeedData.BloodGroups);
                    }
                    if (!context.Gender.Any())
                    {
                        context.Gender.AddRange(SeedData.Genders);
                    }
                    if (!context.Religion.Any())
                    {
                        context.Religion.AddRange(SeedData.Religions);
                    }
                    if (!context.MaritalStatus.Any())
                    {
                        context.MaritalStatus.AddRange(SeedData.MaritalStatus);
                    }
                    if (!context.Country.Any())
                    {
                        context.Country.AddRange(SeedData.Countries);
                    }
                    if (!context.State.Any())
                    {
                        context.State.AddRange(SeedData.States);
                    }
                    if (!context.City.Any())
                    {
                        context.City.AddRange(SeedData.Cities);
                    }
                    if (!context.Office.Any())
                    {
                        context.Office.AddRange(SeedData.Offices);
                    }
                    //if (!context.Role.Any())
                    //{
                    //    context.Role.AddRange(SeedData.Roles);
                    //}
                    if (!context.Designation.Any())
                    {
                        context.Designation.AddRange(SeedData.Designations);
                    }
                    if (!context.Section.Any())
                    {
                        context.Section.AddRange(SeedData.Sections);
                    }
                    if (!context.SalaryGrade.Any())
                    {
                        context.SalaryGrade.AddRange(SeedData.SalaryGrades);
                    }
                    if (!context.DivisionOrClass.Any())
                    {
                        context.DivisionOrClass.AddRange(SeedData.DivisionOrClasss);
                    }
                    if (!context.Language.Any())
                    {
                        context.Language.AddRange(SeedData.Languages);
                    }
                    if (!context.Degree.Any())
                    {
                        context.Degree.AddRange(SeedData.Degrees);
                    }

                    #endregion

                    context.SaveChanges();

                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public static void RunSeedDataOnModelCreating(ModelBuilder builder)
        {
            builder.Entity<BloodGroup>().HasData(SeedData.BloodGroups);
            builder.Entity<Gender>().HasData(SeedData.Genders);
            builder.Entity<Religion>().HasData(SeedData.Religions);
            builder.Entity<MaritalStatus>().HasData(SeedData.MaritalStatus);
            builder.Entity<Country>().HasData(SeedData.Countries);
            builder.Entity<State>().HasData(SeedData.States);
            builder.Entity<City>().HasData(SeedData.Cities);
            builder.Entity<Office>().HasData(SeedData.Offices);
            builder.Entity<Designation>().HasData(SeedData.Designations);
            builder.Entity<Section>().HasData(SeedData.Sections);
            builder.Entity<SalaryGrade>().HasData(SeedData.SalaryGrades);
            builder.Entity<DivisionOrClass>().HasData(SeedData.DivisionOrClasss);
            builder.Entity<Language>().HasData(SeedData.Languages);
            builder.Entity<Degree>().HasData(SeedData.Degrees);
        }

        //public static async void SeedUserAndRoleAsync(IApplicationBuilder applicationBuilder)
        //{
        //    using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
        //    {
        //        // Roles
        //        var roleManager = serviceScope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();
        //        if (!await roleManager.RoleExistsAsync(UserRoles.Admin))
        //            await roleManager.CreateAsync(new IdentityRole(UserRoles.Admin));
        //        if (!await roleManager.RoleExistsAsync(UserRoles.User))
        //            await roleManager.CreateAsync(new IdentityRole(UserRoles.User));

        //    }
        //}
    }
}
