using Microsoft.Extensions.DependencyInjection;
using TesteKeyworks.Cadastros.Servicos.Interfaces.Clientes;
using TesteKeyworks.Cadastros.Servicos.Interfaces.Materiais;
using TesteKeyworks.Cadastros.Servicos.Servicos.Clientes;
using TesteKeyworks.Cadastros.Servicos.Servicos.Materiais;

namespace TesteKeyworks.Cadastros.Infra.CrossCutting
{
    public class InjecaoServicos
    {
        public static void InjetarServicos(IServiceCollection services)
        {
            services.AddScoped<IClienteServico, ClienteServico>();
            services.AddScoped<IMaterialServico, MaterialServico>();
        }
    }
}
