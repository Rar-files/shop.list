﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using ShopListApi.Data;

#nullable disable

namespace ShopListApi.Migrations
{
    [DbContext(typeof(ShopListDBContext))]
    [Migration("20220213231704_InitialMigrate")]
    partial class InitialMigrate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("ShopListApi.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .HasColumnType("text")
                        .HasColumnName("description");

                    b.Property<string>("Name")
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.HasKey("Id")
                        .HasName("pk_category");

                    b.ToTable("category", (string)null);
                });

            modelBuilder.Entity("ShopListApi.Models.Member", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("FirstName")
                        .HasColumnType("text")
                        .HasColumnName("first_name");

                    b.Property<string>("LastName")
                        .HasColumnType("text")
                        .HasColumnName("last_name");

                    b.HasKey("Id")
                        .HasName("pk_member");

                    b.ToTable("member", (string)null);
                });

            modelBuilder.Entity("ShopListApi.Models.Product", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ID"));

                    b.Property<string>("Description")
                        .HasColumnType("text")
                        .HasColumnName("description");

                    b.Property<string>("Grams")
                        .HasColumnType("text")
                        .HasColumnName("grams");

                    b.Property<string>("ImageURL")
                        .HasColumnType("text")
                        .HasColumnName("image_url");

                    b.Property<string>("Name")
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.Property<int?>("ProductID")
                        .HasColumnType("integer")
                        .HasColumnName("product_id");

                    b.HasKey("ID")
                        .HasName("pk_product");

                    b.HasIndex("ProductID")
                        .HasDatabaseName("ix_product_product_id");

                    b.ToTable("product", (string)null);
                });

            modelBuilder.Entity("ShopListApi.Models.QuantitieType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("HowManyGrams")
                        .HasColumnType("integer")
                        .HasColumnName("how_many_grams");

                    b.Property<string>("Name")
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.Property<int?>("ProductID")
                        .HasColumnType("integer")
                        .HasColumnName("product_id");

                    b.Property<string>("ShortCut")
                        .HasColumnType("text")
                        .HasColumnName("short_cut");

                    b.HasKey("Id")
                        .HasName("pk_quantitie_type");

                    b.HasIndex("ProductID")
                        .HasDatabaseName("ix_quantitie_type_product_id");

                    b.ToTable("quantitie_type", (string)null);
                });

            modelBuilder.Entity("ShopListApi.Models.Product", b =>
                {
                    b.HasOne("ShopListApi.Models.Product", null)
                        .WithMany("Categories")
                        .HasForeignKey("ProductID")
                        .HasConstraintName("fk_product_product_product_id");
                });

            modelBuilder.Entity("ShopListApi.Models.QuantitieType", b =>
                {
                    b.HasOne("ShopListApi.Models.Product", null)
                        .WithMany("QuantitieTypes")
                        .HasForeignKey("ProductID")
                        .HasConstraintName("fk_quantitie_type_product_product_id");
                });

            modelBuilder.Entity("ShopListApi.Models.Product", b =>
                {
                    b.Navigation("Categories");

                    b.Navigation("QuantitieTypes");
                });
#pragma warning restore 612, 618
        }
    }
}
