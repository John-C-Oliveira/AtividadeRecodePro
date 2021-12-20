﻿// <auto-generated />
using System;
using AgenciaSemStress.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AgenciaSemStress.Migrations
{
    [DbContext(typeof(MVCContext))]
    [Migration("20211214201717_[testecontroller]")]
    partial class testecontroller
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("AgenciaSemStress.Models.AnunciosModel", b =>
                {
                    b.Property<int>("AnuncioID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AnuncioID"), 1L, 1);

                    b.Property<DateTime>("DataCadastroAnuncio")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataRetorno")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataSaida")
                        .HasColumnType("datetime2");

                    b.Property<int>("FKDestinoID")
                        .HasColumnType("int");

                    b.Property<string>("NomeAnuncio")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("TipoAnuncio")
                        .HasColumnType("bit");

                    b.Property<float>("ValorAnuncio")
                        .HasColumnType("real");

                    b.HasKey("AnuncioID");

                    b.ToTable("Anuncios");
                });

            modelBuilder.Entity("AgenciaSemStress.Models.ClientesModel", b =>
                {
                    b.Property<int>("ClienteID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ClienteID"), 1L, 1);

                    b.Property<string>("CidadeCliente")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("CpfCliente")
                        .IsRequired()
                        .HasMaxLength(14)
                        .HasColumnType("nvarchar(14)");

                    b.Property<DateTime>("DataCadastroCliente")
                        .HasColumnType("datetime2");

                    b.Property<string>("EmailCliente")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("IMGCliente")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LogradouroCliente")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<DateTime>("NascimentoCliente")
                        .HasColumnType("datetime2");

                    b.Property<string>("NomeCliente")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("TelefoneCliente")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("UFCliente")
                        .IsRequired()
                        .HasMaxLength(3)
                        .HasColumnType("nvarchar(3)");

                    b.HasKey("ClienteID");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("AgenciaSemStress.Models.DestinosModel", b =>
                {
                    b.Property<int>("DestinoID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DestinoID"), 1L, 1);

                    b.Property<DateTime>("DataCadastroDestino")
                        .HasColumnType("datetime2");

                    b.Property<string>("EnderecoDestino")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("IMGDestino")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomeDestino")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("PaisDestino")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<int>("QtdadePessoa")
                        .HasColumnType("int");

                    b.Property<string>("UFDestino")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DestinoID");

                    b.ToTable("Destinos");
                });

            modelBuilder.Entity("AgenciaSemStress.Models.ReservasModel", b =>
                {
                    b.Property<int>("ReservaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ReservaID"), 1L, 1);

                    b.Property<DateTime>("DataCadastroReserva")
                        .HasColumnType("datetime2");

                    b.Property<int>("FKAnuncioID")
                        .HasColumnType("int");

                    b.Property<int>("FKClienteID")
                        .HasColumnType("int");

                    b.Property<int>("FKDestinoID")
                        .HasColumnType("int");

                    b.HasKey("ReservaID");

                    b.ToTable("Reservas");
                });
#pragma warning restore 612, 618
        }
    }
}
