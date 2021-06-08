using IfoodMercado.Business.Models;
using System;
using System.Collections;
using System.Threading.Tasks;

namespace IfoodMercado.Business.Intefaces
{
    public interface IProdutoService : IDisposable
    {
        Task<IEnumerable> Obter();
        Task<Produto> ObterPorId(Guid id);
        Task Adicionar(Produto produto);
        Task Atualizar(Produto produto);
        Task Remover(Guid id);
    }
}
