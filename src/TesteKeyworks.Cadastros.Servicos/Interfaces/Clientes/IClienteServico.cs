using TesteKeyworks.Cadastros.Servicos.DTOs.Clientes;
using TesteKeyworks.Cadastros.Servicos.ViewModels.Clientes;

namespace TesteKeyworks.Cadastros.Servicos.Interfaces.Clientes
{
    public interface IClienteServico : IDisposable
    {
        /// <summary>
        /// Adiciona um cliente
        /// </summary>
        /// <param name="cliente"></param>
        void Adicionar(ClienteDto cliente);

        /// <summary>
        /// Atualiza um cliente
        /// </summary>
        /// <param name="cliente"></param>
        void Atualizar(ClienteDto cliente);

        /// <summary>
        /// Exclui um cliente
        /// </summary>
        /// <param name="codigo"></param>
        void Excluir(int codigo);

        /// <summary>
        /// Retorna um cliente por seu ID
        /// </summary>
        /// <param name="codigo"></param>
        /// <returns></returns>
        Task<ClienteViewModel> ObterCliente(int codigo);

        /// <summary>
        /// Retorna todos os clientes
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<ClienteViewModel>> ObterClientes();
    }
}
