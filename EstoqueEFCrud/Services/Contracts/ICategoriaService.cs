using EstoqueEFCrud.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstoqueEFCrud.Services.Contracts
{
    public interface ICategoriaService
    {
        Task<List<CategoriaModel>> ObterTodos();
        Task<CategoriaModel> Salvar(CategoriaModel categoria);
        Task<CategoriaModel> Inserir(CategoriaModel categoria);
        Task<CategoriaModel> Alterar(CategoriaModel categoria);
        Task<CategoriaModel> Deletar(int id);
        Task<CategoriaModel> ObterPorId(int id);
    }
}
