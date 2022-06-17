using FluentValidation;
using TesteKeyworks.Cadastros.Dominios.Comandos.Clientes;

namespace TesteKeyworks.Cadastros.Dominios.Validacoes.Clientes
{
    public class ValidacaoComandoCliente<T> : AbstractValidator<T> where T : ComandoCliente
    {
    }
}
