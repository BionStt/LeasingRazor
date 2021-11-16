using LeasingRazor.Persistence;
using LeasingRazor.Persistence.Context;

var builder = WebApplication.CreateBuilder(args);

//if you want the old style
//builder.Host.ConfigureWebHostDefaults(webBuilder =>
//{
//    webBuilder.UseStartup<Startup>();
//});

// Add services to the container.
builder.Services.AddLeasingRazor(builder.Configuration.GetConnectionString("LeasingRazorConnection"));
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

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
