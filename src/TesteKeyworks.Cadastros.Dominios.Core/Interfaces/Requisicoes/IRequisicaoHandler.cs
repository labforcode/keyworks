namespace TesteKeyworks.Cadastros.Dominios.Core.Interfaces.Requisicoes
{
    public interface IRequisicaoHandler<T> where T : class
    {
        /// <summary>
        /// Executor do comando
        /// </summary>
        /// <param name="comando"></param>
        /// <returns></returns>
        Task<bool> Handler(T comando);
    }
}
