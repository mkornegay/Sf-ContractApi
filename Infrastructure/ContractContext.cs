using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sf.ContractApi.ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sf.ContractApi.Infrastructure
{
    public class ContractContext : DbContext
    {
        public ContractContext(DbContextOptions<ContractContext> options)
            : base(options)
        {
          
        }

        public DbSet<Contract> Contracts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            modelBuilder.Entity<Contract>(ConfigureContracts);
            modelBuilder.Entity<Item>(ConfigureItems);
            modelBuilder.Entity<ContractItem>(ConfigureContractItems);
        }

        private void ConfigureContracts(EntityTypeBuilder<Contract> builder)
        {
            builder.ToTable("Contract");

            builder.Property(c => c.ContractNo)
                .HasMaxLength(25)
                .IsRequired();

            builder.Property(c => c.ContractType)
                .HasMaxLength(25)
                .IsRequired();

            builder.Property(c => c.ContractDate)
                .IsRequired();
        }

        private void ConfigureItems(EntityTypeBuilder<Item> builder)
        {
            builder.ToTable("Item");

            builder.Property(i => i.Sku)
                .HasMaxLength(25)
                .IsRequired();

            builder.Property(i => i.Description)
                .HasMaxLength(300);

            builder.Property(i => i.ListCost)
                .HasColumnType<decimal>("decimal(18,4)");
              
        }

        private void ConfigureContractItems(EntityTypeBuilder<ContractItem> builder)
        {
            builder.ToTable("ContractItem");

        }

    }
}
