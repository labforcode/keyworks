using Microsoft.Extensions.DependencyInjection;
using TesteKeyworks.Cadastros.Servicos.Interfaces.Clientes;
using TesteKeyworks.Cadastros.Servicos.Servicos.Clientes;

namespace TesteKeyworks.Cadastros.Infra.CrossCutting
{
    public class InjecaoServicos
    {
        public static void InjetarServicos(IServiceCollection services)
        {
            services.AddScoped<IClienteServico, ClienteServico>();
        }
    }
}
