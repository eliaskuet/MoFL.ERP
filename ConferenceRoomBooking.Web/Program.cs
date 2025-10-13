// Ensure the following NuGet package is installed in your project:  
// Microsoft.EntityFrameworkCore.SqlServer  
// Microsoft.AspNetCore.Identity.EntityFrameworkCore  

using BusinessAL.DbContext;
using BusinessAL.Repositories.BaseRepositories;
using DataAL.Models;
using HGO.ASPNetCore.FileManager;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.FileProviders;
using System.Data.SqlClient;
// Removed the problematic using directive as it is unnecessary.  
// The 'UseSqlServer' method is part of the Microsoft.EntityFrameworkCore namespace.  

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddHttpContextAccessor();

// Add services to the container.  
builder.Services.AddControllersWithViews();

// HGO.AspNetCore.FileManager -------
builder.Services.AddHgoFileManager();
builder.Services.AddDbContext<RepositoryContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"),
        sqlServerOptionsAction: sqlOptions =>
        {
            sqlOptions.EnableRetryOnFailure(
                maxRetryCount: 5, // Number of retries
                maxRetryDelay: TimeSpan.FromSeconds(30), // Max delay between retries
                errorNumbersToAdd: null); // SQL error numbers to consider transient (null for default)
        });
    options.EnableSensitiveDataLogging();
});

builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<RepositoryContext>();
builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
// In Program.cs for .NET 6+
builder.Services.AddAuthentication(options =>
{
    options.DefaultScheme = CookieAuthenticationDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = CookieAuthenticationDefaults.AuthenticationScheme;
})
.AddCookie();
var app = builder.Build();
// Configure the HTTP request pipeline.  
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.  
    app.UseHsts();
}



app.UseHttpsRedirection();
app.UseRouting();
// Ensure UseAuthentication and UseAuthorization are called in the middleware pipeline
app.UseAuthentication();
app.UseAuthorization();
app.MapStaticAssets();
// HGO.AspNetCore.FileManager -------
app.UseHgoFileManager();
//-----------------------------------
app.MapControllerRoute(
   name: "default",
   pattern: "{controller=Home}/{action=Index}/{id?}")
   .WithStaticAssets();

app.Run();
