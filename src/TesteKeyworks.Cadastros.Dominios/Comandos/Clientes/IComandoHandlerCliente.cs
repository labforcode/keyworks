using TesteKeyworks.Cadastros.Dominios.Comandos.Clientes.Acoes;

namespace TesteKeyworks.Cadastros.Dominios.Comandos.Clientes
{
    public interface IComandoHandlerCliente
    {
        /// <summary>
        /// Atualização de registro
        /// </summary>
        /// <param name="comando"></param>
        /// <returns></returns>
        void Handler(ComandoAtualizacaoCliente comando);

        /// <summary>
        /// Exclusão de registro
        /// </summary>
        /// <param name="comando"></param>
        /// <returns></returns>
        void Handler(ComandoExclusaoCliente comando);

        /// <summary>
        /// Inserção de registro
        /// </summary>
        /// <param name="comando"></param>
        /// <returns></returns>
        void Handler(ComandoInsercaoCliente comando);
    }
}
