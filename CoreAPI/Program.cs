using Microsoft.EntityFrameworkCore;
using CoreAPI.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
//設定回傳資料為xml格式
//1.
//builder.Services.AddControllers().AddXmlSerializerFormatters();
//2.Program.cs增加如下:
//[Produces("application/xml");


builder.Services.AddDbContext<ispanMsit145shibaContext>(
    options => options.UseSqlServer(
    builder.Configuration.GetConnectionString("prjConnection")
));


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
