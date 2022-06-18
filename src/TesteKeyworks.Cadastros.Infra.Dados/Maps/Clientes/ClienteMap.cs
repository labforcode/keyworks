﻿using Microsoft.EntityFrameworkCore;
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

            builder.OwnsOne(c => c.Responsavel, r => 
            {
                r.Property(c => c.Nome)
                 .HasColumnName("responsavel_nome")
                 .HasColumnType("varchar(140)")
                 .IsRequired();

                r.Property(c => c.Email)
                 .HasColumnName("responsavel_email")
                 .HasColumnType("varchar(80)")
                 .IsRequired();
            });

            builder.OwnsOne(c => c.Telefone, t => 
            {
                t.Property(c => c.DDI)
                       .HasColumnName("telefone_ddi")
                       .HasColumnType("varchar(2)")
                       .IsRequired();

                t.Property(c => c.DDD)
                       .HasColumnName("telefone_ddd")
                       .HasColumnType("varchar(3)")
                       .IsRequired();

                t.Property(c => c.Numero)
                       .HasColumnName("telefone_numero")
                       .HasColumnType("varchar(10)")
                       .IsRequired();
            });
        }
    }
}
