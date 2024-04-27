using EstoqueEFCrud.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EstoqueEFCrud.Repository.Contracts
{
    public interface IProdutoRepository
    {
        Task<List<ProdutoModel>> TodosProdutos();
        Task<List<ProdutoModel>> ObterTodosDaCategoria(int idCategoria);
        Task<ProdutoModel> Inserir(ProdutoModel produto);
        Task<ProdutoModel> Alterar(ProdutoModel produto);
        Task<ProdutoModel> Deletar(int id);
        Task<ProdutoModel> ObterPorId(int id);
        Task<List<ProdutoModel>> BuscarProdutosPorNome(string nome);
    }
}
