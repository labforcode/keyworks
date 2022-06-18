using Microsoft.Extensions.DependencyInjection;
using TesteKeyworks.Cadastros.Dominios.Comandos.Clientes;
using TesteKeyworks.Cadastros.Dominios.Comandos.Materiais;

namespace TesteKeyworks.Cadastros.Infra.CrossCutting
{
    public class InjecaoComandos
    {
        public static void InjetarComandos(IServiceCollection services)
        {
            services.AddScoped<IComandoHandlerCliente, ComandoHandlerCliente>();
            services.AddScoped<IComandoHandlerCliente, ComandoHandlerCliente>();
            services.AddScoped<IComandoHandlerCliente, ComandoHandlerCliente>();

            services.AddScoped<IComandoHandlerMaterial, ComandoHandlerMaterial>();
            services.AddScoped<IComandoHandlerMaterial, ComandoHandlerMaterial>();
            services.AddScoped<IComandoHandlerMaterial, ComandoHandlerMaterial>();
        }
    }
}
