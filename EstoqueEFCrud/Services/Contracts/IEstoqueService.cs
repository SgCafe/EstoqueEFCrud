using EstoqueEFCrud.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstoqueEFCrud.Services.Contracts
{
    public interface IEstoqueService
    {
        Task <IList<ProdutoModel>> TodosProdutos ();
        Task<IList<CategoriaModel>> TodasCategorias();
        Task AdicionarCategoria(CategoriaModel categoria);
        Task EditarCategoria(CategoriaModel model);
        Task DeletarCategoria(int id);

        Task<IList<ProdutoModel>> TodosProdutos(int idCategoria);
        Task AdicionarProduto(ProdutoModel produto);
        Task EditarProduto(ProdutoModel produto);
        Task DeletarProduto(int id);

        Task<List<ProdutoModel>> BuscarProdutosPorNome(string nome);

    }
}
