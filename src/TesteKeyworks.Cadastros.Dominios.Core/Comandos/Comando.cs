using FluentValidation.Results;

namespace TesteKeyworks.Cadastros.Dominios.Core.Comandos
{
    public abstract class Comando
    {
        public ValidationResult ValidationResult { get; set; }

        /// <summary>
        /// Verifica se o comando é valido
        /// </summary>
        /// <returns></returns>
        public abstract bool EhValido();
    }
}
