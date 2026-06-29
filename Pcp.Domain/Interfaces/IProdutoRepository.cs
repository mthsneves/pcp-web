using Pcp.Domain.Entities;

namespace Pcp.Domain.Interfaces
{
    public  interface IProdutoRepository
    {
        Task<IEnumerable<Produto>> ObterTodosAsync();
        Task<Produto?> ObterPorIdAsync(int id);
        Task AdicionarAsync(Produto produto);
        Task AtualizarAsync(Produto produto);
        Task DesativarAsync(int id);
    }
}
