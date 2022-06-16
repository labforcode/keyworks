using TesteKeyworks.Cadastros.Dominios.Interfaces.Repositorios;

namespace TesteKeyworks.Cadastros.Infra.Dados.Repositorios
{
    public class BaseRepositorio<T> : IBaseRepositorio<T> where T : class
    {
        public void Add(T t)
        {
            throw new NotImplementedException();
        }

        public void Delete(T t)
        {
            throw new NotImplementedException();
        }

        public void Update(T t)
        {
            throw new NotImplementedException();
        }
    }
}
