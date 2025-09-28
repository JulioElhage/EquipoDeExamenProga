using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using EquipoDeExamenProgra.Data;        // 👈 AGREGA ESTO
using Microsoft.EntityFrameworkCore; // 👈 AGREGA ESTO

// Alguien estubo aqui.

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddAuthorization();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();

builder.Services.AddDbContext<AppDbContext>(options => // DE ESTAR CON EL MISMO NOMBRE DE LA CARPETA DE DATA.
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


app.UseHttpsRedirection();
app.UseAuthorization();

app.MapControllers(); // <-- ¡ESTO ES OBLIGATORIO!

app.Run();