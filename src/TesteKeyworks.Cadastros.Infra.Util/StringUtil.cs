using System.Text.RegularExpressions;

namespace TesteKeyworks.Cadastros.Infra.Util
{
    public class StringUtil
    {
        public static string RemoverEspaco(string texto)
        {
            if (string.IsNullOrEmpty(texto) == false)
            {
                texto = texto.Replace(" ", "");
            }

            return texto;
        }

        public static string DeixarApenasNumeros(string texto)
        {
            if (string.IsNullOrEmpty(texto) == false)
            {
                texto = Regex.Replace(texto, "[()-.]{1,}", "");
            }

            return texto;
        }
    }
}
