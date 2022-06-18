using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TesteKeyworks.Cadastros.Dominios.Entidades.ClientesMateriais;

namespace TesteKeyworks.Cadastros.Infra.Dados.Maps.ClientesMateriais
{
    public class ClienteMaterialMap : IEntityTypeConfiguration<ClienteMaterial>
    {
        public void Configure(EntityTypeBuilder<ClienteMaterial> builder)
        {
            builder.ToTable("clientes_materiais");

            builder.HasNoKey();

            builder.Property(c => c.CodigoCliente)
                   .HasColumnName("codigo_cliente")
                   .IsRequired();

            builder.Property(c => c.CodigoMaterial)
                    .HasColumnName("codigo_material")
                   .IsRequired();
        }
    }
}
