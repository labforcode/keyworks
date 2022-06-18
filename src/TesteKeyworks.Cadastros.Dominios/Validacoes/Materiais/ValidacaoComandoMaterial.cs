using FluentValidation;
using TesteKeyworks.Cadastros.Dominios.Comandos.Materiais;
using TesteKeyworks.Cadastros.Dominios.Core.Notificacoes;

namespace TesteKeyworks.Cadastros.Dominios.Validacoes.Materiais
{
    public class ValidacaoComandoMaterial<T> : AbstractValidator<T> where T : ComandoMaterial
    {
        public void ValidarCodigo()
        {
            RuleFor(c => c.Codigo)
                .Custom((codigo, context) =>
                {
                    if (codigo <= 0)
                    {
                        var notificacao = $"";
                        Notificacao.RegistrarNotificacao(notificacao);
                        context.AddFailure(notificacao);
                    }
                });
        }

        public void ValidarDescricao()
        {
            RuleFor(c => c.Descricao)
                .Custom((descricao, context) =>
                {
                    if (string.IsNullOrEmpty(descricao))
                    {
                        var notificacao = $"";
                        Notificacao.RegistrarNotificacao(notificacao);
                        context.AddFailure(notificacao);
                    }
                });
        }
    }
}
