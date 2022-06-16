namespace TesteKeyworks.Cadastros.Dominios.Core.Notificacoes
{
    public class Notificacao
    {
        private static List<string> _notificacoes { get; set; }

        public static void RegistrarNotificacao(string mensagem)
        {
            _notificacoes = new List<string> { mensagem };
        }

        public static string ObterNotificacao()
        {
            return _notificacoes.FirstOrDefault();
        }

        public static bool VerificarSeHaNotificacao()
        {
            return _notificacoes.Any();
        }
    }
}
