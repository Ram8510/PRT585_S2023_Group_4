using _3BusinessLogicLayer.Interfaces;
using _3BusinessLogicLayer.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace _3BusinessLogicLayer.Ioc
{
    public static class Init
    {
        public static void InitializeDependencies(IServiceCollection services, IConfiguration configuration)
        {
                      
            // Services
            services.AddScoped<IPersonService, PersonService>();
            services.AddScoped<IStudentService, StudentService>();
            services.AddScoped<IEmployeeService, EmployeeService>();
            services.AddScoped<ISongService, SongService>();
            services.AddScoped<IBookService, BookService>();
            services.AddScoped<IInstrumentService, InstrumentService>();
            services.AddScoped<IProfessorService, ProfessorService>();
            services.AddScoped<IBuildingService, BuildingService>();
            services.AddScoped<IBorrowService, BorrowService>();
            services.AddScoped<IClubService, ClubService>();  

            services.AddScoped<ISecurityService, SecurityService>();
            //services.AddScoped<ICategoryService, CategoryService>();

        }
    }
}
