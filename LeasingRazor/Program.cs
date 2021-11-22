using LeasingRazor.Persistence;
using LeasingRazor.Persistence.Context;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using LeasingRazor.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Authorization;
using NToastNotify;
using LeasingRazor.Models;
using Microsoft.Extensions.DependencyInjection.Extensions;
using LeasingRazor.Infrastructure;
using System.Globalization;
using LeasingRazor.Domain;

var builder = WebApplication.CreateBuilder(args);

//if you want the old style
//builder.Host.ConfigureWebHostDefaults(webBuilder =>
//{
//    webBuilder.UseStartup<Startup>();
//});

// Add services to the container.
builder.Services.AddLeasingRazor(builder.Configuration.GetConnectionString("LeasingRazorConnection"));

//builder.Services.AddDbContext<LeasingRazorContext>(options =>
//    options.UseSqlServer(builder.Configuration.GetConnectionString("LeasingRazorConnection")));

//builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
//    .AddEntityFrameworkStores<LeasingRazorContext>();

builder.Services.AddMvc(o =>
{
    //Add Authentication to all Controllers by default.
    var policy = new AuthorizationPolicyBuilder()
        .RequireAuthenticatedUser()
        .Build();
    o.Filters.Add(new AuthorizeFilter(policy));
}).AddNToastNotifyNoty(new NotyOptions
{
    Layout = "bottomRight",
    ProgressBar = true,
    Timeout = 5000,
    Theme = "metroui"
}); ;

builder.Services.AddRazorPages().AddViewLocalization().AddDataAnnotationsLocalization();

builder.Services.TryAddSingleton<IHttpContextAccessor, HttpContextAccessor>();
builder.Services.Configure<SMTPSettings>(builder.Configuration.GetSection("SMTPSettings"));
builder.Services.Configure<ApplicationSettings>(builder.Configuration.GetSection("ApplicationSettings"));
builder.Services.AddScoped<IEmailService, EmailService>();
builder.Services.AddRazorPages();



builder.WebHost.UseWebRoot(
Path.Combine(Directory.GetCurrentDirectory(),"wwwroot"));

var app = builder.Build();

using(var scope = app.Services.CreateScope())
{
    var servicess = scope.ServiceProvider;
    try
    {
        var LeasingRazorContext = servicess.GetRequiredService<LeasingRazorDbContext>();
        DbInitializer.Initialize(LeasingRazorContext).Wait();

       
        var userManager = servicess.GetRequiredService<UserManager<ApplicationUser>>();
        var roleManager = servicess.GetRequiredService<RoleManager<IdentityRole>>();
        await IdentitySeed.SeedRolesAsync(userManager, roleManager);
        await IdentitySeed.SeedSuperAdminAsync(userManager, roleManager);
    }
    catch (Exception ex) 
    {
        var logger = servicess.GetRequiredService<ILogger<Program>>();

        logger.LogError(ex, "An error occurred while seeding the database.");
        logger.LogError(ex.StackTrace, "An error occurred while seeding the database.");
        logger.LogError(ex.InnerException, "An error occurred while seeding the database.");

    }
}

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}




app.UseNToastNotify();

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();

app.MapRazorPages();

app.Run();
