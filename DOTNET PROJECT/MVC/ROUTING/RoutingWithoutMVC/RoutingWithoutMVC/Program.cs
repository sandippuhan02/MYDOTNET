var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
var app = builder.Build();

//pp.MapGet("/", () => "Hello World!");
app.UseRouting();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}"
    );
    app.MapControllerRoute(
    name: "Home",
    pattern: "{controller=Home}/{action=Page}/{id?}"
    );

app.MapControllerRoute(
    name: "UserIndex",
   pattern: "{Controller=User}/{action=Index}"
    );

app.Run();
