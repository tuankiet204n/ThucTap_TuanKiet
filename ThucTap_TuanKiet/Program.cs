using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System.Text;
using ThucTap_TuanKiet.Controllers;
using ThucTap_TuanKiet.Data;
using ThucTap_TuanKiet.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

// Cấu hình Swagger để hỗ trợ Bearer token
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "API", Version = "v1" });
    c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        Name = "Authorization",
        Type = SecuritySchemeType.Http,
        Scheme = "Bearer",
        BearerFormat = "JWT",
        In = ParameterLocation.Header,
        Description = "Please enter 'Bearer' [space] and then your token"
    });

    c.AddSecurityRequirement(new OpenApiSecurityRequirement
    {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference
                {
                    Type = ReferenceType.SecurityScheme,
                    Id = "Bearer"
                }
            },
            new string[] {}
        }
    });
});

// Cấu hình JWT Authentication
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(options =>
{
    options.RequireHttpsMetadata = false;
    options.SaveToken = true;
    options.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuer = true,
        ValidateAudience = true,
        ValidAudience = builder.Configuration["Jwt:Audience"],
        ValidIssuer = builder.Configuration["Jwt:Issuer"],
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["Jwt:Key"])),
        ValidateLifetime = true, // Xác nhận token chưa hết hạn
        ClockSkew = TimeSpan.Zero // Đảm bảo thời gian chênh lệch nhỏ không gây lỗi
    };
});

// Đăng ký DbContext với SQL Server
builder.Services.AddDbContext<ApplicationDBContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DBConnection")));

// Đăng ký dịch vụ cho DI (Dependency Injection)
builder.Services.AddScoped<IAccount, AccountResponse>();
builder.Services.AddScoped<IArea, AreaResponse>();
builder.Services.AddScoped<IAccountAnswer, AccountAnswerResponse>();
builder.Services.AddScoped<IAccountNotification, AccountNotificationResponse>();
builder.Services.AddScoped<IAnswer, AnswerResponse>();
builder.Services.AddScoped<IArticleImage, ArticleImageResponse>();
builder.Services.AddScoped<IArticle, ArticleResponse>();
builder.Services.AddScoped<IAuthenticationSecurity, AuthenticationSecurityResponse>();
builder.Services.AddScoped<IDateVisit, DateVisitResponse>();
builder.Services.AddScoped<IDistributor, DistributorResponse>();
builder.Services.AddScoped<IJobImage, JobImageResponse>();
builder.Services.AddScoped<IJob, JobResponse>();
builder.Services.AddScoped<INotification, NotificationResponse>();
builder.Services.AddScoped<IPosition, PositionResponse>();
builder.Services.AddScoped<IQuestion, QuestionResponse>();
builder.Services.AddScoped<ISurveyArticle, SurveyArticleResponse>();
builder.Services.AddScoped<ISurveyRequest, SurveyRequestResponse>();
builder.Services.AddScoped<IVisitor, VisitorResponse>();
builder.Services.AddScoped<IVisitSchedule, VisitScheduleResponse>();


// Cấu hình CORS (nếu cần)
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAllOrigins",
        builder => builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseRouting();

// CORS Middleware
app.UseCors("AllowAllOrigins");

// Xác thực người dùng
app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
