using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System.Configuration;
using WebAula.Infra.Database;

namespace WebAula
{
    public static class AddEfExtension
    {
        public static void AddEfCore(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<AppDbContext>(options =>
               options.UseMySql(configuration["ConnectionStrings:Aula"].ToString(), new MySqlServerVersion(new Version(8, 0, 23)))
               
            ); 
        }
    }
}
