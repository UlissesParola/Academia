﻿// <auto-generated />
using System;
using Academia.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Academia.Migrations
{
    [DbContext(typeof(AcademiaDbContext))]
    partial class AcademiaDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.1-servicing-10028");

            modelBuilder.Entity("Academia.Contato", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Email");

                    b.Property<string>("Telefone1");

                    b.Property<string>("Telefone2");

                    b.HasKey("Id");

                    b.ToTable("Contatos");
                });

            modelBuilder.Entity("Academia.Model.Aluno", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("ContatoId");

                    b.Property<string>("Cpf");

                    b.Property<DateTime>("DataNascimento");

                    b.Property<int?>("MatriculaId");

                    b.Property<string>("Nome");

                    b.Property<bool>("Sexo");

                    b.HasKey("Id");

                    b.HasIndex("ContatoId");

                    b.HasIndex("MatriculaId");

                    b.ToTable("Alunos");
                });

            modelBuilder.Entity("Academia.Model.Cheque", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Banco");

                    b.Property<DateTime>("DataVencimento");

                    b.Property<string>("Numero");

                    b.Property<float>("Valor");

                    b.HasKey("Id");

                    b.ToTable("Cheques");
                });

            modelBuilder.Entity("Academia.Model.Matricula", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Adimplente");

                    b.Property<DateTime>("DataMatricula");

                    b.Property<DateTime>("DataVencimento");

                    b.Property<int?>("MensalidadesId");

                    b.Property<int?>("PagamentoId");

                    b.Property<int?>("PlanoDescontoId");

                    b.Property<int?>("PlanoFrequenciaId");

                    b.HasKey("Id");

                    b.HasIndex("MensalidadesId");

                    b.HasIndex("PagamentoId");

                    b.HasIndex("PlanoDescontoId");

                    b.HasIndex("PlanoFrequenciaId");

                    b.ToTable("Matriculas");
                });

            modelBuilder.Entity("Academia.Model.Mensalidade", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("MesReferencia");

                    b.Property<int?>("PagamentoId");

                    b.HasKey("Id");

                    b.HasIndex("PagamentoId");

                    b.ToTable("Mensalidades");
                });

            modelBuilder.Entity("Academia.Model.Pagamento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Data");

                    b.Property<string>("FormaDePagamento");

                    b.Property<float>("Valor");

                    b.HasKey("Id");

                    b.ToTable("Pagamentos");
                });

            modelBuilder.Entity("Academia.Model.PlanoDesconto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<float>("Desconto");

                    b.Property<string>("Nome");

                    b.HasKey("Id");

                    b.ToTable("PlanosDesconto");
                });

            modelBuilder.Entity("Academia.Model.PlanoFrequencia", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nome");

                    b.HasKey("Id");

                    b.ToTable("PlanosFrequencia");
                });

            modelBuilder.Entity("Academia.Model.Visitante", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ContatoId");

                    b.Property<DateTime>("DataVisita");

                    b.Property<string>("Informacoes");

                    b.Property<string>("Nome")
                        .IsRequired();

                    b.Property<DateTime>("ProximoContato");

                    b.HasKey("Id");

                    b.HasIndex("ContatoId");

                    b.ToTable("Visitantes");
                });

            modelBuilder.Entity("Academia.Model.Aluno", b =>
                {
                    b.HasOne("Academia.Contato", "Contato")
                        .WithMany()
                        .HasForeignKey("ContatoId");

                    b.HasOne("Academia.Model.Matricula", "Matricula")
                        .WithMany()
                        .HasForeignKey("MatriculaId");
                });

            modelBuilder.Entity("Academia.Model.Matricula", b =>
                {
                    b.HasOne("Academia.Model.Mensalidade", "Mensalidades")
                        .WithMany()
                        .HasForeignKey("MensalidadesId");

                    b.HasOne("Academia.Model.Pagamento", "Pagamento")
                        .WithMany()
                        .HasForeignKey("PagamentoId");

                    b.HasOne("Academia.Model.PlanoDesconto", "PlanoDesconto")
                        .WithMany()
                        .HasForeignKey("PlanoDescontoId");

                    b.HasOne("Academia.Model.PlanoFrequencia", "PlanoFrequencia")
                        .WithMany()
                        .HasForeignKey("PlanoFrequenciaId");
                });

            modelBuilder.Entity("Academia.Model.Mensalidade", b =>
                {
                    b.HasOne("Academia.Model.Pagamento", "Pagamento")
                        .WithMany()
                        .HasForeignKey("PagamentoId");
                });

            modelBuilder.Entity("Academia.Model.Visitante", b =>
                {
                    b.HasOne("Academia.Contato", "Contato")
                        .WithMany()
                        .HasForeignKey("ContatoId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
