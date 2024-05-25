using Microsoft.AspNetCore.Mvc;
using RazorSyntaxDemo.Controllers;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
var app = builder.Build();

//app.MapGet("/", () => "Hello World!");
app.UseRouting();

app.MapControllerRoute(
    name: "default",
    pattern: "{Controller=Dashboard}/{action=Index}/{id?}"
);

app.Run();
