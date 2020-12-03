﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using back_meet_room.Repository;

namespace back_meet_room.Migrations
{
    [DbContext(typeof(AgendamentoContext))]
    partial class AgendamentoContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("back_meet_room.Model.Agendamento", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Computador")
                        .HasColumnType("bit");

                    b.Property<DateTime>("DataReserva")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("HoraFim")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("HoraInicio")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Projetor")
                        .HasColumnType("bit");

                    b.Property<bool>("Video")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Agendamento");
                });

            modelBuilder.Entity("back_meet_room.Model.Sala", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("AgendamentoId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Computador")
                        .HasColumnType("bit");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<bool>("Projetor")
                        .HasColumnType("bit");

                    b.Property<int>("Quantidade")
                        .HasColumnType("int");

                    b.Property<bool>("VideoConferencia")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("AgendamentoId");

                    b.ToTable("Sala");
                });

            modelBuilder.Entity("back_meet_room.Model.Sala", b =>
                {
                    b.HasOne("back_meet_room.Model.Agendamento", "Agendamento")
                        .WithMany()
                        .HasForeignKey("AgendamentoId");

                    b.Navigation("Agendamento");
                });
#pragma warning restore 612, 618
        }
    }
}
