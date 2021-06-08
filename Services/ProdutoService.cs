using IfoodMercado.Business.Intefaces;
using IfoodMercado.Business.Models;
using System;
using System.Collections;
using System.Threading.Tasks;

namespace IfoodMercado.Business.Services
{
    public class ProdutoService : IProdutoService
    {
        private readonly IProdutoRepository _produtoRepository;

        public ProdutoService(IProdutoRepository produtoRepository
                              ) : base()
        {
            _produtoRepository = produtoRepository;
        }
        public async Task<IEnumerable> Obter()
        {
            return await _produtoRepository.ObterTodos();
        }
        public async Task<Produto> ObterPorId(Guid id)
        {
            return await _produtoRepository.ObterPorId(id);
        }
        public async Task Adicionar(Produto produto)
        {           
            if (produto == null) return;

            await _produtoRepository.Adicionar(produto);
        }
        public async Task Atualizar(Produto produto)
        {
            if (produto == null) return;

            await _produtoRepository.Atualizar(produto);
        }
        public async Task Remover(Guid id)
        {
            await _produtoRepository.Remover(id);
        }
        public void Dispose()
        {
            _produtoRepository?.Dispose();
        }
    }
}
