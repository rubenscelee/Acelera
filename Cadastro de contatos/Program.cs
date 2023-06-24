using Cadastro_de_contatos.Data;
using Cadastro_de_contatos.Repository;
using Microsoft.EntityFrameworkCore;
using System;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddScoped<IContatoRepository, ContatoRepository>();

string postgresConnection = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContextPool<AppDBContext>(options =>
   options.UseNpgsql(postgresConnection)
);

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

app.UseCors(x => x.AllowAnyHeader()
                .AllowAnyMethod()
                .AllowAnyOrigin());

app.Run();
