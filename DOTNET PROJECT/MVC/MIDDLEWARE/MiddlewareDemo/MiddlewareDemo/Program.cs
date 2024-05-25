using System.ComponentModel.Design.Serialization;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.Use(async (context, next) =>
{
    await context.Response.WriteAsync("\n1.MIddleware-1");
    await next(context);
    await context.Response.WriteAsync("\n2.End of MIddleware-2");

});
app.Use(async (context, next) =>
{
    await context.Response.WriteAsync("\n3.Misddleware-2 start");
    await next(context);
    await context.Response.WriteAsync("\n4.Misddleware-2 End");
});

app.Run(async (context) =>
{
    await context.Response.WriteAsync("\n5-middleware-3 starting");
    await context.Response.WriteAsync("\n6-middleware-4 End");
});

app.Run();
