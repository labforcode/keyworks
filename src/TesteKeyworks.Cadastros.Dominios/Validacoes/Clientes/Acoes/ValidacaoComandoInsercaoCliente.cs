using TesteKeyworks.Cadastros.Dominios.Comandos.Clientes.Acoes;

namespace TesteKeyworks.Cadastros.Dominios.Validacoes.Clientes.Acoes
{
    public class ValidacaoComandoInsercaoCliente : ValidacaoComandoCliente<ComandoInsercaoCliente>
    {
        public ValidacaoComandoInsercaoCliente()
        {
            ValidarCnpj();
            ValidarRazaoSocial();
            ValidarNomeResponsavel();
            ValidarTelefoneResponsavel();
            ValidarTelefone();
        }
    }
}
