var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews(); // MVC kabiliyeti kazandırıyor.



var app = builder.Build();

app.UseStaticFiles();
app.MapDefaultControllerRoute();  //Homecontroller index methodu icin

app.Run();
