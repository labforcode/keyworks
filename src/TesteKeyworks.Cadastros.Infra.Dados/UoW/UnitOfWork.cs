using TesteKeyworks.Cadastros.Dominios.Interfaces.UoW;
using TesteKeyworks.Cadastros.Infra.Dados.Contextos;

namespace TesteKeyworks.Cadastros.Infra.Dados.UoW
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DbKeyworks _context;

        public UnitOfWork(DbKeyworks context)
        {
            _context = context;
        }

        public bool Commit()
        {
            return _context.SaveChanges() > 0;
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
