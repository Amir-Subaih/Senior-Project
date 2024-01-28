using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Senior_Project.Core;
using Senior_Project.Data;

var builder = WebApplication.CreateBuilder(args);// Create a builder for the app

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();// For database errors

builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<ApplicationDbContext>();// For Identity
builder.Services.AddRazorPages();// For Razor Pages
builder.Services.AddSingleton<IDataHelper<User>, UserEntity>();// For the UserEntity class

var app = builder.Build();// Build the app

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();// For migrations
}
else
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();// For HTTPS
}

app.UseHttpsRedirection();// Redirects HTTP requests to HTTPS
app.UseStaticFiles();// For the wwwroot folder

app.UseRouting();// For routing requests to controllers

app.UseAuthorization();// For authorization

app.MapRazorPages();// For Razor Pages

app.Run();// For the default page
