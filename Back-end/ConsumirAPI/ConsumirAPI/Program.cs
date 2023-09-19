using ConsumirAPI.AuthService;
using ConsumirAPI.Data;
using ConsumirAPI.DbService;
using ConsumirAPI.Service;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System.Reflection;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

// Cors
builder.Services.AddCors(options =>
{
    options.AddPolicy(name: "CulturaTours", builder =>
    {
        builder.WithOrigins("*");
        builder.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
    });
});

// Swagger Config
builder.Services.AddSwaggerGen(doc =>
{
    doc.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "CulturaTour API",
        Version = "v1",
    });

    var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
    var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
    doc.IncludeXmlComments(xmlPath);
});

builder.Services.AddDbContext<SegurityCulturaTourDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

// JWT Config
builder.Services.AddAuthentication(opt =>
{
    opt.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    opt.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
}).AddJwtBearer(options =>
{
    options.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuer = false,
        ValidateAudience = false,
        ValidateLifetime = true,
        ValidateIssuerSigningKey = true,

        IssuerSigningKey = new SymmetricSecurityKey(
            Encoding.UTF8.GetBytes("superSecretKey@345"))
    };
});


// DI Historical Events
builder.Services.AddScoped<IHistoricalEventsApiService, HistoricalEventsApiService>();
// DI Country
builder.Services.AddScoped<ICountryApiService, CountryApiService>();
// DI Holidays
builder.Services.AddScoped<IHolidaysApiService, HolidaysApiService>();

// DI Login Repository
builder.Services.AddScoped<ILoginRepository, LoginRepository>();
// DI Sign Up Repository
builder.Services.AddScoped<ISgnUpRepository, SgnUpRepository>();
// DI Unit of Work Repository
builder.Services.AddTransient<IUnitOfWork, UnitOfWork>();
// DI Encrypt Passwords
builder.Services.AddScoped<IPasswordEncrypt, PasswordEncrypt>();


var app = builder.Build();

app.UseCors("CulturaTours");

// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{

//}

app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
