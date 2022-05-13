using ControleCliente_ASP_MVC.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<Contexto>(
    options =>   
        options.UseMySql("server=localhost;initial catalog=CRUD_MVC_MYSQL_AULA;uid=root;",
        Microsoft.EntityFrameworkCore.ServerVersion.Parse("10.4.21-mysql"))
    );/*

builder.Services.AddDbContext<Contexto>
    (options => options.UseMySql(
        "server=localhost;initial catalog=CRUD_MVC_MYSQL_AULA;uid=root;pwd=1234",
        Microsoft.EntityFrameworkCore.ServerVersion.Parse("10.4.21-mysql")));*/

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
