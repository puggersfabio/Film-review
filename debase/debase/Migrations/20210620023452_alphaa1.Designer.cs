﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using debase;

namespace debase.Migrations
{
    [DbContext(typeof(filmDB))]
    [Migration("20210620023452_alphaa1")]
    partial class alphaa1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("debase.defilms", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("categorie")
                        .HasColumnType("int");

                    b.Property<int>("cijfer")
                        .HasColumnType("int");

                    b.Property<string>("image_url")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("krtomschrijving")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("lengte")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("naam")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("place")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("rated")
                        .HasColumnType("int");

                    b.Property<string>("uitkomst")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("defilms");
                });
#pragma warning restore 612, 618
        }
    }
}
