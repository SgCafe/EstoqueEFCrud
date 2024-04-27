using EstoqueEFCrud.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EstoqueEFCrud.Repository.Contracts
{
    public interface ICategoriaRepository
    {
        Task<List<CategoriaModel>> ObterTodos();
        Task<CategoriaModel> Inserir(CategoriaModel categoria);
        Task<CategoriaModel> Alterar(CategoriaModel categoria);
        Task<CategoriaModel> Deletar(int id);
        Task<CategoriaModel> ObterPorId(int id);
    }
}
