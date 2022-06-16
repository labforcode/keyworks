namespace TesteKeyworks.Cadastros.Dominios.Core.Comandos
{
    public abstract class Comando
    {
        /// <summary>
        /// Verifica se o comando é valido
        /// </summary>
        /// <returns></returns>
        public abstract bool EhValido();
    }
}
