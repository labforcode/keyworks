using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TesteKeyworks.Cadastros.Dominios.Entidades.ClientesMateriais;

namespace TesteKeyworks.Cadastros.Infra.Dados.Maps.CLientesMateriais
{
    public class ClienteMaterialMap : IEntityTypeConfiguration<ClienteMaterial>
    {
        public void Configure(EntityTypeBuilder<ClienteMaterial> builder)
        {
            builder.ToTable("clientes_materiais");
            builder.HasKey(c => new { c.CodigoCliente, c.CodigoMaterial });

            builder.Property(c => c.CodigoCliente)
                   .HasColumnName("codigo_cliete")
                   .IsRequired();

            builder.Property(c => c.CodigoMaterial)
                   .IsRequired();

            builder.HasOne(c => c.Cliente)
                   .WithMany(c => c.ClientesMateriais);

            builder.HasOne(c => c.Material)
                   .WithMany(c => c.ClientesMateriais);
        }
    }
}
