using EstoqueEFCrud.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EstoqueEFCrud.Services.Contracts
{
    public interface IProdutoService
    {
        Task<List<ProdutoModel>> TodosProdutos();
        Task<List<ProdutoModel>> ObterTodosDaCategoria(int idCategoria);
        Task<ProdutoModel> Salvar(ProdutoModel produtoModel);
        Task<ProdutoModel> Inserir(ProdutoModel produtoModel);
        Task<ProdutoModel> Alterar(ProdutoModel produtoModel);
        Task<ProdutoModel> Deletar(int id);
        Task<ProdutoModel> ObterPorId(int id);
        Task<List<ProdutoModel>> BuscarProdutosPorNome(string nome);
    }
}
