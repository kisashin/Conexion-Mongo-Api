using Conexion_Mongo_Api.Models;
using Conexion_Mongo_Api.Services;

var builder = WebApplication.CreateBuilder(args);

// Configura EstudiantesDBSettings
builder.Services.Configure<EstudiantesDBSettings>(
    builder.Configuration.GetSection("EstudiantesDBSettings"));

// Registra el servicio
builder.Services.AddSingleton<EstudianteService>();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
