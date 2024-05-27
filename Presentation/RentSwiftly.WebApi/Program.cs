using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using RentSwiftly.Application.Features.CQRS.Handlers.AboutHandlers;
using RentSwiftly.Application.Features.CQRS.Handlers.BannerHandlers;
using RentSwiftly.Application.Features.CQRS.Handlers.BrandHandlers;
using RentSwiftly.Application.Features.CQRS.Handlers.CarHandlers;
using RentSwiftly.Application.Features.CQRS.Handlers.CategoryHandlers;
using RentSwiftly.Application.Features.CQRS.Handlers.ContactHandlers;
using RentSwiftly.Application.Features.RepositoryPattern;
using RentSwiftly.Application.Interfaces;
using RentSwiftly.Application.Interfaces.BlogInterfaces;
using RentSwiftly.Application.Interfaces.CarDescriptionInterfaces;
using RentSwiftly.Application.Interfaces.CarFeatureInterfaces;
using RentSwiftly.Application.Interfaces.CarInterfaces;
using RentSwiftly.Application.Interfaces.CarPricingInterfaces;
using RentSwiftly.Application.Interfaces.RentACarInterfaces;
using RentSwiftly.Application.Interfaces.ReviewInterfaces;
using RentSwiftly.Application.Interfaces.StatisticsInterfaces;
using RentSwiftly.Application.Interfaces.TagCloudInterfaces;
using RentSwiftly.Application.Services;
using RentSwiftly.Domain.Entities;
using RentSwiftly.Persistence.Context;
using RentSwiftly.Persistence.Repositories;
using RentSwiftly.Persistence.Repositories.BlogRepositories;
using RentSwiftly.Persistence.Repositories.CarDescriptionRepositories;
using RentSwiftly.Persistence.Repositories.CarFeatureRepositories;
using RentSwiftly.Persistence.Repositories.CarPricingRepositories;
using RentSwiftly.Persistence.Repositories.CarRepositories;
using RentSwiftly.Persistence.Repositories.CommentRepositories;
using RentSwiftly.Persistence.Repositories.RentACarRepositories;
using RentSwiftly.Persistence.Repositories.ReviewRepositories;
using RentSwiftly.Persistence.Repositories.StatisticsRepositories;
using RentSwiftly.Persistence.Repositories.TagCloudRepositories;
using System.Reflection;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(opt =>
{
	opt.RequireHttpsMetadata = false;
	opt.TokenValidationParameters = new TokenValidationParameters
	{
		ValidAudience = "https://localhost",
		ValidIssuer = "https://localhost",
		ClockSkew = TimeSpan.Zero,
		IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("rentswiftlyrent1")),
		ValidateLifetime = true,
		ValidateIssuerSigningKey = true
	};
});

// Add services to the container.
builder.Services.AddScoped<RentSwiftlyContext>();
builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
builder.Services.AddScoped(typeof(ICarRepository), typeof(CarRepository));
builder.Services.AddScoped(typeof(IRentACarRepository), typeof(RentACarRepository));
builder.Services.AddScoped(typeof(IBlogRepository), typeof(BlogRepository));
builder.Services.AddScoped(typeof(ICarPricingRepository), typeof(CarPricingRepository));
builder.Services.AddScoped(typeof(ITagCloudRepository), typeof(TagCloudRepository));
builder.Services.AddScoped(typeof(IStatisticsRepository), typeof(StatisticsRepository));
builder.Services.AddScoped(typeof(IGenericRepository<Comment>), typeof(CommentRepository));
builder.Services.AddScoped(typeof(ICarFeatureRepository), typeof(CarFeatureRepository));
builder.Services.AddScoped(typeof(ICarDescriptionRepository), typeof(CarDescriptionRepository));
builder.Services.AddScoped(typeof(IReviewRepository), typeof(ReviewRepository));

builder.Services.AddScoped<GetAboutQueryHandler>();
builder.Services.AddScoped<GetAboutByIdQueryHandler>();
builder.Services.AddScoped<CreateAboutCommandHandler>();
builder.Services.AddScoped<DeleteAboutCommandHandler>();
builder.Services.AddScoped<UpdateAboutCommandHandler>();

builder.Services.AddScoped<GetBannerQueryHandler>();
builder.Services.AddScoped<GetBannerByIdQueryHandler>();
builder.Services.AddScoped<CreateBannerCommandHandler>();
builder.Services.AddScoped<DeleteBannerCommandHandler>();
builder.Services.AddScoped<UpdateBannerCommandHandler>();

builder.Services.AddScoped<GetBrandByIdQueryHandler>();
builder.Services.AddScoped<GetBrandQueryHandler>();
builder.Services.AddScoped<CreateBrandCommandHandler>();
builder.Services.AddScoped<DeleteBrandCommandHandler>();
builder.Services.AddScoped<UpdateBrandCommandHandler>();

builder.Services.AddScoped<GetCarByIdQueryHandler>();
builder.Services.AddScoped<GetCarQueryHandler>();
builder.Services.AddScoped<CreateCarCommandHandler>();
builder.Services.AddScoped<DeleteCarCommandHandler>();
builder.Services.AddScoped<UpdateCarCommandHandler>();
builder.Services.AddScoped<GetCarWithBrandQueryHandler>();
builder.Services.AddScoped<GetLast5CarsWithBrandQueryHandler>();

builder.Services.AddScoped<GetCategoryByIdQueryHandler>();
builder.Services.AddScoped<GetCategoryQueryHandler>();
builder.Services.AddScoped<CreateCategoryCommandHandler>();
builder.Services.AddScoped<DeleteCategoryCommandHandler>();
builder.Services.AddScoped<UpdateCategoryCommandHandler>();

builder.Services.AddScoped<GetContactByIdQueryHandler>();
builder.Services.AddScoped<GetContactQueryHandler>();
builder.Services.AddScoped<CreateContactCommandHandler>();
builder.Services.AddScoped<DeleteContactCommandHandler>();
builder.Services.AddScoped<UpdateContactCommandHandler>();

builder.Services.AddApplicationService(builder.Configuration);

builder.Services.AddControllers().AddFluentValidation(x =>
{
	x.RegisterValidatorsFromAssembly(Assembly.GetExecutingAssembly());
});


builder.Services.AddControllers();
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
