using Microsoft.Extensions.DependencyInjection;
using TesteKeyworks.Cadastros.Dominios.Interfaces.UoW;
using TesteKeyworks.Cadastros.Infra.Dados.UoW;

namespace TesteKeyworks.Cadastros.Infra.CrossCutting
{
    public class InjecaoInfra
    {
        public static void InjetarInfra(IServiceCollection services)
        {
            services.AddScoped<IUnitOfWork, UnitOfWork>();
        }
    }
}
