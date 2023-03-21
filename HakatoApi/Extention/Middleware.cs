using Data.IRepositories;
using Data.Repositories;
using HakatoApi.DBContext;
using Microsoft.EntityFrameworkCore;
using servise.Servises;
using servise.Servises.DoctorSer;
using servise.Servises.SicknessServis;

namespace HakatoApi.Extention
{
    public static class Middleware
    {
        public static void AppDbConTextes(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<AppDbContext>(option =>
                     option.UseNpgsql(configuration.GetConnectionString("DefaultConnection")));
        }
        public static void AddService(this IServiceCollection services)
        {
            services.AddTransient<IDoctorServis, DoctorServis>();
            services.AddTransient<IPatientServise, PatientServise>();
            services.AddTransient<ISicknessServise, SicknessServise>();
        }

        public static void AddRepositories(this IServiceCollection services)
        {
            services.AddTransient<IDoctorRepository, DoctorRepository>();
            services.AddTransient<IPatientRepositorie, PatientRepositorie>();
            services.AddTransient<ISicknessServise, SicknessServise>();
        }
    }
}
