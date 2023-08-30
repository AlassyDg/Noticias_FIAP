using Webapiaspnet.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;
using System;


var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("Webapiconnection");

//connection to local My SQL
/*builder.Services.AddDbContext<WebapiContext>(opts =>
    opts.UseMySql((connectionString), ServerVersion.AutoDetect(connectionString)));*/

//Connection using SQL Server
builder.Services.AddDbContext<WebapiContext>(opts =>
    opts.UseSqlServer(connectionString));

// Add services to the container.
builder.Services.AddControllers().AddNewtonsoftJson();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


var app = builder.Build();
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
