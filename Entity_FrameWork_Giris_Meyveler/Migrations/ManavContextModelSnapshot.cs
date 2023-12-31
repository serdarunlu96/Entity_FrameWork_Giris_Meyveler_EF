﻿// <auto-generated />
using Entity_FrameWork_Giris_Meyveler.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Entity_FrameWork_Giris_Meyveler.Migrations
{
    [DbContext(typeof(ManavContext))]
    partial class ManavContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.18")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Entity_FrameWork_Giris_Meyveler.Data.Meyve", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Ad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Meyveler");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Ad = "Elma"
                        },
                        new
                        {
                            Id = 2,
                            Ad = "Armut"
                        },
                        new
                        {
                            Id = 3,
                            Ad = "Portakal"
                        },
                        new
                        {
                            Id = 4,
                            Ad = "Muz"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
