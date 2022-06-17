using TesteKeyworks.Cadastros.Dominios.Comandos.Clientes.Acoes;
using TesteKeyworks.Cadastros.Dominios.Core.Interfaces.Requisicoes;

namespace TesteKeyworks.Cadastros.Dominios.Comandos.Clientes
{
    public class ComandoHandlerCliente : IRequisicaoHandler<ComandoAtualizacaoCliente>,
                                         IRequisicaoHandler<ComandoExclusaoCliente>,
                                         IRequisicaoHandler<ComandoInsercaoCliente>

    {
        public Task<bool> Handler(ComandoAtualizacaoCliente comando)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Handler(ComandoExclusaoCliente comando)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Handler(ComandoInsercaoCliente comando)
        {
            throw new NotImplementedException();
        }
    }
}
