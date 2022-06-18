﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using TesteKeyworks.Cadastros.Infra.Dados.Contextos;

#nullable disable

namespace TesteKeyworks.Cadastros.Infra.Dados.Migrations
{
    [DbContext(typeof(DbKeyworks))]
    [Migration("20220618165031_development")]
    partial class development
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("public")
                .HasAnnotation("ProductVersion", "6.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("TesteKeyworks.Cadastros.Dominios.Entidades.Clientes.Cliente", b =>
                {
                    b.Property<int>("Codigo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("codigo");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Codigo"));

                    b.Property<bool>("Ativo")
                        .HasColumnType("boolean")
                        .HasColumnName("ativo");

                    b.Property<string>("Cnpj")
                        .IsRequired()
                        .HasColumnType("varchar(14)")
                        .HasColumnName("cnpj");

                    b.Property<int>("CodigoMaterial")
                        .HasColumnType("integer")
                        .HasColumnName("codigo_material");

                    b.Property<int>("PlantaId")
                        .HasColumnType("integer")
                        .HasColumnName("planta_id");

                    b.Property<string>("RazaoSocial")
                        .IsRequired()
                        .HasColumnType("varchar(140)")
                        .HasColumnName("razao_social");

                    b.Property<int>("TipoCliente")
                        .HasColumnType("integer")
                        .HasColumnName("tipo_cliente");

                    b.HasKey("Codigo");

                    b.ToTable("clientes", "public");
                });

            modelBuilder.Entity("TesteKeyworks.Cadastros.Dominios.Entidades.Clientes.Cliente", b =>
                {
                    b.OwnsOne("TesteKeyworks.Cadastros.Dominios.ValueObjects.Responsaveis.Responsavel", "Responsavel", b1 =>
                        {
                            b1.Property<int>("ClienteCodigo")
                                .HasColumnType("integer");

                            b1.Property<string>("Email")
                                .IsRequired()
                                .HasColumnType("varchar(80)")
                                .HasColumnName("responsavel_email");

                            b1.Property<string>("Nome")
                                .IsRequired()
                                .HasColumnType("varchar(140)")
                                .HasColumnName("responsavel_nome");

                            b1.HasKey("ClienteCodigo");

                            b1.ToTable("clientes", "public");

                            b1.WithOwner()
                                .HasForeignKey("ClienteCodigo");
                        });

                    b.OwnsOne("TesteKeyworks.Cadastros.Dominios.ValueObjects.Telefones.Telefone", "Telefone", b1 =>
                        {
                            b1.Property<int>("ClienteCodigo")
                                .HasColumnType("integer");

                            b1.Property<string>("DDD")
                                .IsRequired()
                                .HasColumnType("varchar(3)")
                                .HasColumnName("telefone_ddd");

                            b1.Property<string>("DDI")
                                .IsRequired()
                                .HasColumnType("varchar(2)")
                                .HasColumnName("telefone_ddi");

                            b1.Property<string>("Numero")
                                .IsRequired()
                                .HasColumnType("varchar(10)")
                                .HasColumnName("telefone_numero");

                            b1.HasKey("ClienteCodigo");

                            b1.ToTable("clientes", "public");

                            b1.WithOwner()
                                .HasForeignKey("ClienteCodigo");
                        });

                    b.Navigation("Responsavel")
                        .IsRequired();

                    b.Navigation("Telefone")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}