using TesteKeyworks.Cadastros.Dominios.Validacoes.Clientes.Acoes;

namespace TesteKeyworks.Cadastros.Dominios.Comandos.Clientes.Acoes
{
    public class ComandoExclusaoCliente : ComandoCliente
    {
        public ComandoExclusaoCliente(int codigo)
        {
            Codigo = codigo;
        }

        public override bool EhValido()
        {
            ValidationResult = new ValidacaoComandoExclusaoCliente().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
