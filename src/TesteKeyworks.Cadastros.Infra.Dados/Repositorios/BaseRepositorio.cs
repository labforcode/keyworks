using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Npgsql;
using System.Data;
using TesteKeyworks.Cadastros.Dominios.Interfaces.Repositorios;
using TesteKeyworks.Cadastros.Infra.Dados.Contextos;

namespace TesteKeyworks.Cadastros.Infra.Dados.Repositorios
{
    public class BaseRepositorio<T> : IBaseRepositorio<T> where T : class
    {
        protected DbKeyworks Context;
        private readonly DbSet<T> _dbSet;
        private readonly string _connectionStrings;

        public IDbConnection Connection => new NpgsqlConnection(_connectionStrings);

        public BaseRepositorio(IConfiguration configuration, DbKeyworks context)
        {
            Context = context;
            _dbSet = context.Set<T>();
            _connectionStrings = configuration.GetConnectionString("dbkeyworks");
        }

        public void Add(T t)
        {
            _dbSet.Add(t);
        }

        public void Update(T t)
        {
            _dbSet.Update(t);
        }

        public void Delete(T t)
        {
            _dbSet.Remove(t);
        }
    }
}
