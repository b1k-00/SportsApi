using SportAPI.Persistence;
using System.Data.SQLite;
using Microsoft.EntityFrameworkCore.Sqlite;
using Microsoft.EntityFrameworkCore;
using SportAPI.Application.Persistence;
using SportAPI.Domain;
using SportAPI.Application.Interface;
using SportAPI.Application;
using SportAPI.Persistence.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddHttpContextAccessor();

builder.Services.AddDbContext<SportsDbContext>(options =>
                options.UseSqlite(@"Data Source=C:\\Users\\brenn\\source\\repos\\SportAPI\\Sport.db")); //11-12

builder.Services.AddScoped<ITeamApp, TeamApp>();
builder.Services.AddScoped<IGenericRepository<Team>, TeamRepository>();

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
