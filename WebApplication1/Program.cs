using CarBookingAPI;
using WebApplication1.Services;
using WebApplication1.Abstractions;
using WebApplication1.Controllers;
using WebApplication1.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");

builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    options.UseNpgsql(connectionString);
});

// Добавляем сервисы
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.Configure<EmailOptions>(builder.Configuration.GetSection("Mail"));
builder.Services.AddScoped<IEmailService, EmailService>();

// Настройка политики CORS
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", policy =>
    {
        policy.WithOrigins("http://Maksimov.somee.com", "http://212.233.90.38")
              .AllowAnyMethod()
              .WithHeaders("Content-Type")
              .AllowCredentials();
    });
});

// Указываем порт перед Build()
builder.WebHost.UseUrls("http://0.0.0.0:8080");

var app = builder.Build();

// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// Подключение CORS с конкретной политикой
app.UseCors("AllowAll");

app.UseAuthorization();

app.MapControllers();

app.Run();