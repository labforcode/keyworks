using TesteKeyworks.Cadastros.Dominios.Comandos.Materiais.Acoes;

namespace TesteKeyworks.Cadastros.Dominios.Comandos.Materiais
{
    public interface IComandoHandlerMaterial
    {
        /// <summary>
        /// Atualização de registro
        /// </summary>
        /// <param name="comando"></param>
        void Handler(ComandoAtualizacaoMaterial comando);

        /// <summary>
        /// Exclusão de registro
        /// </summary>
        /// <param name="comando"></param>
        void Handler(ComandoExclusaoMaterial comando);

        /// <summary>
        /// Inserção de registro
        /// </summary>
        /// <param name="comando"></param>
        void Handler(ComandoInsercaoMaterial comando);
    }
}
