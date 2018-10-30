﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Sf.ContractApi.Infrastructure;

namespace Sf.ContractApi.Infrastructure.Migrations
{
    [DbContext(typeof(ContractContext))]
    [Migration("20181025173912_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Sf.ContractApi.ApplicationCore.Entities.Contract", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("ContractDate");

                    b.Property<string>("ContractNo")
                        .IsRequired()
                        .HasMaxLength(25);

                    b.Property<string>("ContractOrganization");

                    b.Property<string>("ContractType")
                        .IsRequired()
                        .HasMaxLength(25);

                    b.HasKey("Id");

                    b.ToTable("Contract");
                });

            modelBuilder.Entity("Sf.ContractApi.ApplicationCore.Entities.ContractItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ContractId");

                    b.Property<int>("ItemId");

                    b.HasKey("Id");

                    b.HasIndex("ContractId");

                    b.ToTable("ContractItem");
                });

            modelBuilder.Entity("Sf.ContractApi.ApplicationCore.Entities.Item", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasMaxLength(300);

                    b.Property<decimal>("ListCost")
                        .HasColumnType("decimal(18,4)");

                    b.Property<string>("Sku")
                        .IsRequired()
                        .HasMaxLength(25);

                    b.HasKey("Id");

                    b.ToTable("Item");
                });

            modelBuilder.Entity("Sf.ContractApi.ApplicationCore.Entities.ContractItem", b =>
                {
                    b.HasOne("Sf.ContractApi.ApplicationCore.Entities.Contract")
                        .WithMany("ContractItems")
                        .HasForeignKey("ContractId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}