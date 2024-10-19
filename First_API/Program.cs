
using First_API.Application;
using First_API.Application.Contracts;
using First_API.DataAccess;
using First_API.DataAccess.Contracts_DataAccess;
using First_API.DataAccess.Repositories;

namespace First_API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddScoped<IDepartmentServices, DepartmentServices>();
            builder.Services.AddScoped<IUnitOfWork, UOW>();
            builder.Services.AddScoped<IDepartmentRepository,DepartmentRepository>();

            builder.Services.AddScoped<IEmployeeServices,EmployeeServices>();
            builder.Services.AddScoped<IEmployeeRepository, EmployeeRepository>();

            builder.Services.AddDbContext<CustomDbContext>();   
           // Add services to the container.

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
        }
    }
}
