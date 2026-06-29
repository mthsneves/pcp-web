using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Pcp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pcp.Infrastructure.Data.Mappings
{
    public class ProdutoMapping : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.ToTable("Produtos");
            builder.HasKey(p => p.ProdutoId);

            builder.Property(p => p.Nome)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(p => p.Codigo)
                .IsRequired()
                .HasMaxLength(50);

            builder.HasIndex(p => p.Codigo)
                .IsUnique();

            builder.Property(p => p.UnidadeMedida)
                .IsRequired()
                .HasMaxLength(20);

            builder.Property(p => p.QuantidadeMinima)
                .HasPrecision(18, 4);

            builder.Property(p => p.Ativo)
                .IsRequired()
                .HasDefaultValue(true);

            builder.Property(p => p.DataCriacao)
                .IsRequired();

            builder.Property(p => p.Tipo)
                .IsRequired();
        }
    }
}
