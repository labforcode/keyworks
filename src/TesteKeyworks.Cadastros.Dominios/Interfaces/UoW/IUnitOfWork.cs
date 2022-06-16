namespace TesteKeyworks.Cadastros.Dominios.Interfaces.UoW
{
    public interface IUnitOfWork : IDisposable
    {
        bool Commit();
    }
}
