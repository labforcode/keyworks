using Microsoft.EntityFrameworkCore;
using TesteKeyworks.Cadastros.Dominios.Entidades.Clientes;
using TesteKeyworks.Cadastros.Infra.Dados.Maps.Clientes;

namespace TesteKeyworks.Cadastros.Infra.Dados.Contextos
{
    public class DbKeyworks : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }

        public DbKeyworks(DbContextOptions<DbKeyworks> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);

            builder.HasDefaultSchema("public");

            builder.ApplyConfiguration(new ClienteMap());
        }
    }
}
