using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace TesteKeyworks.Cadastros.Infra.CrossCutting
{
    public class InjecaoDependencia
    {
        public static void RegistrarInjecaoDependencia(IServiceCollection services, IConfiguration configuration)
        {
            InjecaoRepositorios.InjetarRepositorios(services);
        }
    }
}
