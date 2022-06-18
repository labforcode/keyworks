using FluentValidation;
using TesteKeyworks.Cadastros.Dominios.Comandos.Clientes;
using TesteKeyworks.Cadastros.Dominios.Core.Notificacoes;

namespace TesteKeyworks.Cadastros.Dominios.Validacoes.Clientes
{
    public class ValidacaoComandoCliente<T> : AbstractValidator<T> where T : ComandoCliente
    {
        public void ValidarCodigo()
        {
            RuleFor(c => c.Codigo)
                .Custom((codigo, context) =>
                {
                    if (codigo <= 0)
                    {
                        var notificacao = @"Código do cliente não informado.";
                        Notificacao.RegistrarNotificacao(notificacao);
                        context.AddFailure(notificacao);
                    }
                });
        }

        public void ValidarCnpj()
        {
            RuleFor(c => c.Cnpj)
                .Custom((cnpj, context) =>
                {
                    if (string.IsNullOrEmpty(cnpj))
                    {
                        var notificacao = $"CNPJ inválido.";
                        Notificacao.RegistrarNotificacao(notificacao);
                        context.AddFailure(notificacao);
                    }
                });
        }

        public void ValidarRazaoSocial()
        {
            RuleFor(c => c.RazaoSocial)
                .Custom((razaoSocial, context) =>
                {
                    if (string.IsNullOrEmpty(razaoSocial))
                    {
                        var notificacao = $"Razão Social não preenchida.";
                        Notificacao.RegistrarNotificacao(notificacao);
                        context.AddFailure(notificacao);
                    }
                });
        }

        public void ValidarNomeResponsavel()
        {
            RuleFor(c => c.Responsavel.Nome)
                .Custom((nome, context) =>
                {
                    if (string.IsNullOrEmpty(nome))
                    {
                        var notificacao = $"É necessário informar um nome para o Responsável.";
                        Notificacao.RegistrarNotificacao(notificacao);
                        context.AddFailure(notificacao);
                    }
                });
        }

        public void ValidarTelefoneResponsavel()
        {
            RuleFor(c => c.Responsavel.Email)
                .Custom((email, context) =>
                {
                    if (string.IsNullOrEmpty(email))
                    {
                        var notificacao = $"É necessário informar um e-mail para o Responsável.";
                        Notificacao.RegistrarNotificacao(notificacao);
                        context.AddFailure(notificacao);
                    }
                });
        }

        public void ValidarTelefone()
        {
            RuleFor(c => c.Telefone)
                .Custom((telefone, context) =>
                {
                    if (string.IsNullOrEmpty(telefone.DDI) || string.IsNullOrEmpty(telefone.DDD) || string.IsNullOrEmpty(telefone.Numero))
                    {
                        var notificacao = $"O telefone deve conter DDI + DDD + Número.";
                        Notificacao.RegistrarNotificacao(notificacao);
                        context.AddFailure(notificacao);
                    }
                });
        }
    }
}
