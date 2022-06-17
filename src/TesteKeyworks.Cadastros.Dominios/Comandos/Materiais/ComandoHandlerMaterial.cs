using TesteKeyworks.Cadastros.Dominios.Comandos.Materiais.Acoes;
using TesteKeyworks.Cadastros.Dominios.Core.Interfaces.Requisicoes;

namespace TesteKeyworks.Cadastros.Dominios.Comandos.Materiais
{
    public class ComandoHandlerMaterial : IRequisicaoHandler<ComandoAtualizacaoMaterial>,
                                          IRequisicaoHandler<ComandoExclusaoMaterial>,
                                          IRequisicaoHandler<ComandoInsercaoMaterial>

    {
        public Task<bool> Handler(ComandoAtualizacaoMaterial comando)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Handler(ComandoExclusaoMaterial comando)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Handler(ComandoInsercaoMaterial comando)
        {
            throw new NotImplementedException();
        }
    }
}
