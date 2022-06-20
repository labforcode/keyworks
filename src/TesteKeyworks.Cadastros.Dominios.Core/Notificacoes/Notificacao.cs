namespace TesteKeyworks.Cadastros.Dominios.Core.Notificacoes
{
    public class Notificacao
    {
        private static List<string> _notificacoes { get; set; }

        public static void Notificar(string mensagem)
        {
            _notificacoes = new List<string> { mensagem };
        }

        public static string ObterNotificacao()
        {
            var notificacao = _notificacoes.FirstOrDefault();
            _notificacoes.Clear();
            return notificacao;
        }

        public static bool VerificarSeHaNotificacao()
        {
            return _notificacoes.Any();
        }
    }
}
