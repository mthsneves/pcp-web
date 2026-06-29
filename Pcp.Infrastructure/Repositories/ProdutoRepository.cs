using Microsoft.EntityFrameworkCore;
using Pcp.Domain.Entities;
using Pcp.Domain.Interfaces;
using Pcp.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pcp.Infrastructure.Repositories
{
    public class ProdutoRepository : IProdutoRepository
    {

        private readonly AppDbContext _context;

        public ProdutoRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Produto>> ObterTodosAsync()
        {
            return await _context.Produtos
                .Where(p => p.Ativo)
                .ToListAsync();
        }
        public async Task<Produto?> ObterPorIdAsync(int id)
        {
            return await _context.Produtos.FirstOrDefaultAsync(p => p.ProdutoId == id);
        }

        public async Task AdicionarAsync(Produto produto)
        {
            await _context.Produtos.AddAsync(produto);
            await _context.SaveChangesAsync();
        }

        public async Task AtualizarAsync(Produto produto)
        {
            _context.Produtos.Update(produto);
            await _context.SaveChangesAsync();
        }

        public async Task DesativarAsync(int id)
        {
            var produto = await ObterPorIdAsync(id);
            if (produto != null)
            {
                produto.Ativo = false;
                await _context.SaveChangesAsync();
            }
        }
    }
}
