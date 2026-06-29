using Pcp.Domain.Enums;

namespace Pcp.Domain.Entities
{
    public class Produto
    {
        public int ProdutoId { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string Codigo { get; set; } = string.Empty;
        public string UnidadeMedida { get; set; } = string.Empty;
        public decimal QuantidadeMinima { get; set; }
        public bool Ativo { get; set; } = true;
        public DateTime DataCriacao { get; set; } = DateTime.UtcNow;
        public TipoProduto Tipo { get; set; } = TipoProduto.ProdutoAcabado;

    }
}
