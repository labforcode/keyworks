using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TesteKeyworks.Cadastros.Infra.Dados.Contextos;

namespace TesteKeyworks.Cadastros.Infra.CrossCutting
{
    public class InjecaoDbKeyworks
    {
        public static void InjetarContexto(IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<DbKeyworks>(opt => opt.UseNpgsql(configuration.GetConnectionString("dbkeyworks")));
            services.AddScoped<DbKeyworks>();
        }
    }
}
