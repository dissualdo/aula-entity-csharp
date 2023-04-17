using Microsoft.AspNetCore.Cors.Infrastructure;
using WebAula.Domain.Repository;
using WebAula.Infra.Repository;

namespace WebAula
{
    public static class Injector
    {
        public static void Register(this IServiceCollection services)
        {
            #region .: Service :.
            services.AddTransient<IClienteRepository, ClienteRepository>();
            #endregion
        }
    }
}
