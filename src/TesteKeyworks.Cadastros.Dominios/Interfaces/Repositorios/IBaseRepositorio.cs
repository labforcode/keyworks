namespace TesteKeyworks.Cadastros.Dominios.Interfaces.Repositorios
{
    public interface IBaseRepositorio<T> where T : class
    {
        void Add(T t);

        void Update(T t);

        void Delete(T t);
    }
}
