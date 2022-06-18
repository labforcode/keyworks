using Dapper;
using Microsoft.Extensions.Configuration;
using TesteKeyworks.Cadastros.Dominios.Entidades.Clientes;
using TesteKeyworks.Cadastros.Dominios.Interfaces.Repositorios.Clientes;
using TesteKeyworks.Cadastros.Infra.Dados.Contextos;

namespace TesteKeyworks.Cadastros.Infra.Dados.Repositorios.Clientes
{
    public class ClienteRepositorio : BaseRepositorio<Cliente>, IClienteRepositorio
    {
        private readonly string _query = @"SELECT c.codigo            AS Codigo,
                                                  c.cnpj              AS CNPJ,
                                                  c.razao_social      AS RazaoSocial,
                                                  c.ativo             AS Ativo,
                                                  c.planta_id         AS PlantaId,
                                                  c.tipo_cliente      AS TipoCliente,
                                                  c.responsavel_nome  AS ResponsavelNome,
                                                  c.responsavel_email AS ResponsavelEmail,
                                                  c.telefone_ddi      AS TelefoneDDI,
                                                  c.telefone_ddd      AS TelefoneDDD,
                                                  c.telefone_numero   AS TelefoneNumero
                                           FROM clientes AS c ";

        public ClienteRepositorio(IConfiguration configuration, DbKeyworks context) : base(configuration, context)
        {
        }

        /// <inheritdoc/>
        public Task<Cliente> ObterClienteAsync(int codigo)
        {
            try
            {
                var connection = Connection;
                var query = $@"{_query}
                                WHERE c.codigo = @value_codigo";

                return connection.QueryFirstOrDefaultAsync<Cliente>(query, new { value_codigo = codigo });
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        /// <inheritdoc/>
        public Task<Cliente> ObterClienteAsync(string cnpj)
        {
            try
            {
                var connection = Connection;
                var query = $@"{_query}
                                WHERE c.cnpj = @value_cnpj";

                return connection.QueryFirstOrDefaultAsync<Cliente>(query, new { value_cnpj = cnpj });
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        /// <inheritdoc/>
        public Task<IEnumerable<Cliente>> ObterClientesAsync()
        {
            try
            {
                var connection = Connection;
                return connection.QueryAsync<Cliente>(_query);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
