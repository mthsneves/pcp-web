using Pcp.Domain.Enums;

namespace Pcp.Domain.Entities
{
    public class OrdemProducao
    {
        public int OrdemProducaoId { get; set; }
        public DateTime DataOP { get; set; } = DateTime.UtcNow;
        public StatusOrdem StatusOP { get; set; } = StatusOrdem.Planejada;
        public decimal Quantidade { get; set; }
        public int ProdutoId { get; set; }
        public Produto Produto { get; set; } = null!;
    }
}
  