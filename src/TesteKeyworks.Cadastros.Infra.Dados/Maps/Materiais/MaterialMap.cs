using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TesteKeyworks.Cadastros.Dominios.Entidades.Materiais;

namespace TesteKeyworks.Cadastros.Infra.Dados.Maps.Materiais
{
    public class MaterialMap : IEntityTypeConfiguration<Material>
    {
        public void Configure(EntityTypeBuilder<Material> builder)
        {
            builder.ToTable("materiais");
            builder.HasKey(c => c.Codigo);

            builder.Property(c => c.Codigo)
                   .HasColumnName("codigo")
                   .IsRequired();

            builder.Property(c => c.Descricao)
                   .HasColumnName("descricao")
                   .HasColumnType("varchar(120)")
                   .IsRequired();
        }
    }
}
