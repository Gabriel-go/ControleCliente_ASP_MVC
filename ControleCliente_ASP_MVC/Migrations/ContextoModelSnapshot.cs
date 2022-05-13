﻿// <auto-generated />
using ControleCliente_ASP_MVC.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ControleCliente_ASP_MVC.Migrations
{
    [DbContext(typeof(Contexto))]
    partial class ContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("ControleCliente_ASP_MVC.Models.Contato", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("Email");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("Nome");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("Telefone");

                    b.HasKey("Id");

                    b.ToTable("Usuario");
                });
#pragma warning restore 612, 618
        }
    }
}
