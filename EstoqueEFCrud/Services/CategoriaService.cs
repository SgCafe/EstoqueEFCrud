using EstoqueEFCrud.Models;
using EstoqueEFCrud.Repository;
using EstoqueEFCrud.Repository.Contracts;
using EstoqueEFCrud.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstoqueEFCrud.Services
{
    public class CategoriaService : ICategoriaService
    {
        #region Properties

        private readonly ICategoriaRepository _categoriaRepository;

        #endregion Properties

        #region Constructors

        public CategoriaService()
        {
            _categoriaRepository = new CategoriaRepository();
        }

        #endregion Constructors

        #region Methods

        public async Task<List<CategoriaModel>> ObterTodos()
        {
            return await _categoriaRepository.ObterTodos();
        }

        public Task<CategoriaModel> Salvar(CategoriaModel categoriaModel)
        {
            return categoriaModel.IdCategoria is 0
                ? Inserir(categoriaModel)
                : Alterar(categoriaModel);
        }

        public async Task<CategoriaModel> Inserir(CategoriaModel categoriaModel)
        {
            return await _categoriaRepository.Inserir(categoriaModel);
        }

        public async Task<CategoriaModel> Alterar(CategoriaModel categoriaModel)
        {
            return await _categoriaRepository.Alterar(categoriaModel);
        }

        public async Task<CategoriaModel> Deletar(int id)
        {
            return await _categoriaRepository.Deletar(id);
        }

        public async Task<CategoriaModel> ObterPorId(int id)
        {
            return await _categoriaRepository.ObterPorId(id);
        }

        #endregion Methods
    }
}
