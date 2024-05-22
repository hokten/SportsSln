var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews(); // MVC kabiliyeti kazandırıyor.

builder.Services.AddDbContext<StoreDbContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("MovieContext")));

var app = builder.Build();

app.UseStaticFiles();
app.MapDefaultControllerRoute();  //Homecontroller index methodu icin

app.Run();
