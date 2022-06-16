using Dapper;
using Microsoft.Extensions.Configuration;
using TesteKeyworks.Cadastros.Dominios.Entidades.Materiais;
using TesteKeyworks.Cadastros.Dominios.Interfaces.Repositorios.Materiais;
using TesteKeyworks.Cadastros.Infra.Dados.Contextos;

namespace TesteKeyworks.Cadastros.Infra.Dados.Repositorios.Materiais
{
    public class MaterialRepositorio : BaseRepositorio<Material>, IMaterialRepositorio
    {
        private readonly string _query = @"SELECT m.codigo    AS Codigo,
                                                  m.descricao AS Descricao
                                           FROM materiais AS m ";

        public MaterialRepositorio(IConfiguration configuration, DbKeyworks context) : base(configuration, context)
        {
        }

        /// <inheritdoc/>
        public Task<Material> ObterMaterialAsync(int codigo)
        {
            try
            {
                var connection = Connection;
                var query = $@"{_query}
                                WHERE c.codigo = @value_codigo";

                return connection.QueryFirstOrDefaultAsync<Material>(query, new { value_codigo = codigo });
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        /// <inheritdoc/>
        public Task<IEnumerable<Material>> ObterMateriaisAsync()
        {
            try
            {
                var connection = Connection;
                return connection.QueryAsync<Material>(_query);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
