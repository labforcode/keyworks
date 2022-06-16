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

            builder.Property(c => c.Responsavel.Nome)
                   .HasColumnName("responsavel_nome")
                  .HasColumnType("varchar(140)")
                   .IsRequired();

            builder.Property(c => c.Responsavel.Email)
                   .HasColumnName("responsavel_email")
                  .HasColumnType("varchar(80)")
                   .IsRequired();

            builder.Property(c => c.Telefone.DDI)
                   .HasColumnName("telefone_ddi")
                   .HasColumnType("varchar(2)")
                   .IsRequired();

            builder.Property(c => c.Telefone.DDD)
                   .HasColumnName("telefone_ddd")
                   .HasColumnType("varchar(3)")
                   .IsRequired();

            builder.Property(c => c.Telefone.Numero)
                   .HasColumnName("telefone_numero")
                   .HasColumnType("varchar(10)")
                   .IsRequired();

            builder.HasMany(c => c.Materiais)
                    .WithMany(c => c.Clientes)
                    .UsingEntity(c => c.ToTable("clientes_materiais"));
        }
    }
}
