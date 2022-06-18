using Microsoft.EntityFrameworkCore;
using TesteKeyworks.Cadastros.Dominios.Entidades.Clientes;
using TesteKeyworks.Cadastros.Dominios.Entidades.ClientesMateriais;
using TesteKeyworks.Cadastros.Dominios.Entidades.Materiais;
using TesteKeyworks.Cadastros.Infra.Dados.Maps.Clientes;
using TesteKeyworks.Cadastros.Infra.Dados.Maps.ClientesMateriais;
using TesteKeyworks.Cadastros.Infra.Dados.Maps.Materiais;

namespace TesteKeyworks.Cadastros.Infra.Dados.Contextos
{
    public class DbKeyworks : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Material> Materiais { get; set; }
        public DbSet<ClienteMaterial> ClientesMateriais { get; set; }

        public DbKeyworks(DbContextOptions<DbKeyworks> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);

            builder.HasDefaultSchema("public");

            builder.ApplyConfiguration(new ClienteMap());
            builder.ApplyConfiguration(new MaterialMap());
            builder.ApplyConfiguration(new ClienteMaterialMap());
        }
    }
}
