using Microsoft.EntityFrameworkCore;
using QuanLiGhiDanhAPI.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<DataContext>(opts => {
    opts.UseSqlServer(builder.Configuration.GetConnectionString("QuanLiConnection"));
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.UseDeveloperExceptionPage();
}
else
    app.UseExceptionHandler("/error");

app.UseHttpsRedirection();

app.UseAuthorization();
var context = app.Services.CreateScope().ServiceProvider.GetRequiredService<DataContext>();

app.MapControllers();

app.Run();
