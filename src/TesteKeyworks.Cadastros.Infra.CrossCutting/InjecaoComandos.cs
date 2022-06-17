using Microsoft.Extensions.DependencyInjection;
using TesteKeyworks.Cadastros.Dominios.Comandos.Clientes;
using TesteKeyworks.Cadastros.Dominios.Comandos.Clientes.Acoes;
using TesteKeyworks.Cadastros.Dominios.Comandos.Materiais;
using TesteKeyworks.Cadastros.Dominios.Comandos.Materiais.Acoes;
using TesteKeyworks.Cadastros.Dominios.Core.Interfaces.Requisicoes;

namespace TesteKeyworks.Cadastros.Infra.CrossCutting
{
    public class InjecaoComandos
    {
        public static void InjetarComandos(IServiceCollection services)
        {
            services.AddScoped<IRequisicaoHandler<ComandoAtualizacaoCliente>, ComandoHandlerCliente>();
            services.AddScoped<IRequisicaoHandler<ComandoExclusaoCliente>, ComandoHandlerCliente>();
            services.AddScoped<IRequisicaoHandler<ComandoInsercaoCliente>, ComandoHandlerCliente>();

            services.AddScoped<IRequisicaoHandler<ComandoAtualizacaoMaterial>, ComandoHandlerMaterial>();
            services.AddScoped<IRequisicaoHandler<ComandoExclusaoMaterial>, ComandoHandlerMaterial>();
            services.AddScoped<IRequisicaoHandler<ComandoInsercaoMaterial>, ComandoHandlerMaterial>();
        }
    }
}
