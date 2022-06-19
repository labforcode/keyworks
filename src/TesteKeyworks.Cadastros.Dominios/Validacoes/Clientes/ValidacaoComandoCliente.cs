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
                        Notificacao.Notificar(notificacao);
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
                        Notificacao.Notificar(notificacao);
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
                        Notificacao.Notificar(notificacao);
                        context.AddFailure(notificacao);
                    }
                });
        }

        public void ValidarNomeResponsavel()
        {
            RuleFor(c => c.ResponsavelNome)
                .Custom((nome, context) =>
                {
                    if (string.IsNullOrEmpty(nome))
                    {
                        var notificacao = $"É necessário informar um nome para o Responsável.";
                        Notificacao.Notificar(notificacao);
                        context.AddFailure(notificacao);
                    }
                });
        }

        public void ValidarTelefoneResponsavel()
        {
            RuleFor(c => c.ResponsavelEmail)
                .Custom((email, context) =>
                {
                    if (string.IsNullOrEmpty(email))
                    {
                        var notificacao = $"É necessário informar um e-mail para o Responsável.";
                        Notificacao.Notificar(notificacao);
                        context.AddFailure(notificacao);
                    }
                });
        }

        public void ValidarTelefone()
        {
            RuleFor(c => c)
                .Custom((cliente, context) =>
                {
                    if (string.IsNullOrEmpty(cliente.DDI) || string.IsNullOrEmpty(cliente.DDD) || string.IsNullOrEmpty(cliente.Telefone))
                    {
                        var notificacao = $"O telefone deve conter DDI + DDD + Número.";
                        Notificacao.Notificar(notificacao);
                        context.AddFailure(notificacao);
                    }
                });
        }
    }
}
