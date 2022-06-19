using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TesteKeyworks.Cadastros.Dominios.Entidades.Clientes;

namespace TesteKeyworks.Cadastros.Infra.Dados.Maps.Clientes
{
    public class ClienteMap : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.ToTable("clientes");
            builder.HasKey(c => c.Codigo);

            builder.Property(c => c.Codigo)
                   .HasColumnName("codigo")
                   .IsRequired();

            builder.Property(c => c.Cnpj)
                   .HasColumnName("cnpj")
                   .HasColumnType("varchar(14)")
                   .IsRequired();

            builder.Property(c => c.RazaoSocial)
                   .HasColumnName("razao_social")
                   .HasColumnType("varchar(140)")
                   .IsRequired();

            builder.Property(c => c.Ativo)
                   .HasColumnName("ativo")
                   .IsRequired();

            builder.Property(c => c.PlantaId)
                   .HasColumnName("planta_id")
                   .IsRequired();

            builder.Property(c => c.TipoCliente)
                   .HasColumnName("tipo_cliente")
                   .IsRequired();

            builder.Property(c => c.CodigoMaterial)
                   .HasColumnName("codigo_material")
                   .IsRequired();

            builder.Property(c => c.ResponsavelNome)
             .HasColumnName("responsavel_nome")
             .HasColumnType("varchar(140)")
             .IsRequired();

            builder.Property(c => c.ResponsavelEmail)
             .HasColumnName("responsavel_email")
             .HasColumnType("varchar(80)")
             .IsRequired();

            builder.Property(c => c.DDI)
                   .HasColumnName("ddi")
                   .HasColumnType("varchar(2)")
                   .IsRequired();

            builder.Property(c => c.DDD)
                   .HasColumnName("ddd")
                   .HasColumnType("varchar(3)")
                   .IsRequired();

            builder.Property(c => c.Telefone)
                   .HasColumnName("telefone")
                   .HasColumnType("varchar(10)")
                   .IsRequired();
        }
    }
}
