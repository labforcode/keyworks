using TesteKeyworks.Cadastros.Dominios.Entidades.Materiais;

namespace TesteKeyworks.Cadastros.Dominios.Interfaces.Repositorios.Materiais
{
    public interface IMaterialRepositorio
    {
        /// <summary>
        /// Retorna um material por seu código
        /// </summary>
        /// <param name="codigo"></param>
        /// <returns></returns>
        Task<Material> ObterMaterialAsync(int codigo);

        /// <summary>
        /// Retorna uma lista de materiais
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<Material>> ObterMateriaisAsync();
    }
}
