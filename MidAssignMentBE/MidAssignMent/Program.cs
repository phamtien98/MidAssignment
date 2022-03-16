
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using MidAssignMentBE.Interfaces;
using MidAssignMentBE.Models;
using MidAssignMentBE.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<ICategory, CategoryService>();
builder.Services.AddScoped<IBooK, BookService>();
builder.Services.AddCors();
builder.Services.AddDbContext<LibraryManagementContext>(options => options.UseSqlServer("name=ConnectionStrings:ProductConnection"));
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseHttpsRedirection();

app.UseCors(c => c.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin());
app.UseAuthorization();
app.MapControllers();

app.Run();
