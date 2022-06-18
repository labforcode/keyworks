using TesteKeyworks.Cadastros.Dominios.Comandos.Clientes.Acoes;

namespace TesteKeyworks.Cadastros.Dominios.Validacoes.Clientes.Acoes
{
    public class ValidacaoComandoExclusaoCliente : ValidacaoComandoCliente<ComandoExclusaoCliente>
    {
        public ValidacaoComandoExclusaoCliente()
        {
            ValidarCodigo();
        }
    }
}
