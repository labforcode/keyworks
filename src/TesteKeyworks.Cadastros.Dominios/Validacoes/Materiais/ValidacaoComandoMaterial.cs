using FluentValidation;
using TesteKeyworks.Cadastros.Dominios.Comandos.Materiais;

namespace TesteKeyworks.Cadastros.Dominios.Validacoes.Materiais
{
    public class ValidacaoComandoMaterial<T> : AbstractValidator<T> where T : ComandoMaterial
    {
        public void ValidarCodigo()
        {

        }

        public void ValidarDescricao()
        {

        }
    }
}
