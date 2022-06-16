using Microsoft.Extensions.DependencyInjection;
using TesteKeyworks.Cadastros.Dominios.Interfaces.Repositorios.Clientes;
using TesteKeyworks.Cadastros.Dominios.Interfaces.Repositorios.Materiais;
using TesteKeyworks.Cadastros.Infra.Dados.Repositorios.Clientes;
using TesteKeyworks.Cadastros.Infra.Dados.Repositorios.Materiais;

namespace TesteKeyworks.Cadastros.Infra.CrossCutting
{
    public class InjecaoRepositorios
    {
        public static void InjetarRepositorios(IServiceCollection services)
        {
            services.AddScoped<IClienteRepositorio, ClienteRepositorio>();
            services.AddScoped<IMaterialRepositorio, MaterialRepositorio>();
        }
    }
}
