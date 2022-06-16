using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace TesteKeyworks.Cadastros.Infra.CrossCutting
{
    public class InjecaoDependencia
    {
        public static void RegistrarInjecaoDependencia(IServiceCollection services, IConfiguration configuration)
        {
            InjecaoDbKeyworks.InjetarContexto(services, configuration);
            InjecaoRepositorios.InjetarRepositorios(services);
            InjecaoInfra.InjetarInfra(services);
        }
    }
}
