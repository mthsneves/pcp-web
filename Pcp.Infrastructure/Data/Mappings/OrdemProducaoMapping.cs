using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Pcp.Domain.Entities;
using Pcp.Domain.Enums;

namespace Pcp.Infrastructure.Data.Mappings
{
    public class OrdemProducaoMapping : IEntityTypeConfiguration<OrdemProducao>
    {
        public void Configure(EntityTypeBuilder<OrdemProducao> builder)
        {
            builder.ToTable("OrdensProducao");

            builder.HasKey(o => o.OrdemProducaoId);

            builder.Property(o => o.DataOP)
                .IsRequired();

            builder.Property(o => o.StatusOP)
                .IsRequired()
                .HasDefaultValue(StatusOrdem.Planejada);

            builder.Property(o => o.Quantidade)
                .IsRequired()
                .HasPrecision(18, 4);

            builder.HasOne(o => o.Produto)
                .WithMany()
                .HasForeignKey(o => o.ProdutoId)
                .OnDelete(DeleteBehavior.Restrict);

        }
    }
}
