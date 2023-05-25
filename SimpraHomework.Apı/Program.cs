using FluentValidation.AspNetCore;
using Microsoft.EntityFrameworkCore;
using SimpraHomework.Apý.Middlewares;
using SimpraHomework.Shema.Mapping;
using SimpraHomeWork.Core.Repositories;
using SimpraHomeWork.Core.Service;
using SimpraHomeWork.Core.UnitOfWork;
using SimpraHomeWork.Repository;
using SimpraHomeWork.Repository.GenericRepository;
using SimpraHomeWork.Repository.Repositories;
using SimpraHomeWork.Repository.UnitOfWork;
using SimpraHomeWork.Service.FluentValidation;
using SimpraHomeWork.Service.Service;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers().AddFluentValidation(x => x.RegisterValidatorsFromAssemblyContaining<CategoryRequestValidator>());
// Add services to the container.

builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAutoMapper(typeof(MapProfile));

builder.Services.AddDbContext<AppDbContext>(
    x =>

        x.UseSqlServer(builder.Configuration.GetConnectionString("SqlConnection"), option =>
        {
            option.MigrationsAssembly(Assembly.GetAssembly(typeof(AppDbContext)).GetName().Name);
        }
        ));

builder.Services.AddScoped<IUnitofWork, UnitOfWork>();

builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
builder.Services.AddScoped<ICategoryService, CategoryService>();

builder.Services.AddScoped(typeof(IService<>), typeof(Service<>));
builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));

builder.Services.AddScoped<IProductRepository, ProductRepository>();
builder.Services.AddScoped<IProductService, ProductService>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCustomException();

app.UseAuthorization();

app.MapControllers();

app.Run();
