using TesteKeyworks.Cadastros.Dominios.Entidades.Clientes;

namespace TesteKeyworks.Cadastros.Dominios.Interfaces.Repositorios.Clientes
{
    public interface IClienteRepositorio : IBaseRepositorio<Cliente>
    {
        /// <summary>
        /// Retorna um cliente por seu código
        /// </summary>
        /// <param name="codigo"></param>
        /// <returns></returns>
        Task<Cliente> ObterClienteAsync(int codigo);

        /// <summary>
        /// Retorna um cliente por seu código
        /// </summary>
        /// <param name="cnpj"></param>
        /// <returns></returns>
        Task<Cliente> ObterClienteAsync(string cnpj);

        /// <summary>
        /// Retorna uma lista de clientes
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<Cliente>> ObterClientesAsync();
    }
}
