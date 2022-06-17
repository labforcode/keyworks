using TesteKeyworks.Cadastros.Servicos.DTOs.Materiais;
using TesteKeyworks.Cadastros.Servicos.ViewModels.Materiais;

namespace TesteKeyworks.Cadastros.Servicos.Interfaces.Materiais
{
    public interface IMaterialServico : IDisposable
    {
        /// <summary>
        /// Adiciona um material
        /// </summary>
        /// <param name="material"></param>
        void Adicionar(MaterialDto material);

        /// <summary>
        /// Atualiza um material
        /// </summary>
        /// <param name="material"></param>
        void Atualizar(MaterialDto material);

        /// <summary>
        /// Exclui um material
        /// </summary>
        /// <param name="codigo"></param>
        void Excluir(int codigo);

        /// <summary>
        /// Retorna um material por seu ID
        /// </summary>
        /// <param name="codigo"></param>
        /// <returns></returns>
        Task<MaterialViewModel> ObterMaterial(int codigo);

        /// <summary>
        /// Retorna todos os materiais
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<MaterialViewModel>> ObterMateriais();
    }
}
