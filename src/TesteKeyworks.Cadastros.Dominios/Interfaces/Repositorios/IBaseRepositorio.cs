namespace TesteKeyworks.Cadastros.Dominios.Interfaces.Repositorios
{
    public interface IBaseRepositorio<T> where T : class
    {
        void Adicionar(T t);

        void Atualizar(T t);

        void Excluir(T t);
    }
}
