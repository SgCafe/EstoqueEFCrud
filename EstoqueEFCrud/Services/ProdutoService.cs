using EstoqueEFCrud.Models;
using EstoqueEFCrud.Repository;
using EstoqueEFCrud.Repository.Contracts;
using EstoqueEFCrud.Services.Contracts;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EstoqueEFCrud.Services
{
    public class ProdutoService : IProdutoService
    {
        #region Properties

        private readonly IProdutoRepository _produtoRepository;

        #endregion Properties

        #region Constructors

        public ProdutoService()
        {
            _produtoRepository = new ProdutoRepository();
        }

        #endregion Constructors

        #region Methods

        public async Task<List<ProdutoModel>> TodosProdutos()
        {
            return await _produtoRepository.TodosProdutos();   
        }

        public async Task<List<ProdutoModel>> ObterTodosDaCategoria(int idCategoria)
        {
            return await _produtoRepository.ObterTodosDaCategoria(idCategoria);
        }

        public Task<ProdutoModel> Salvar(ProdutoModel produtoModel)
        {
            return produtoModel.IdProduto is 0
                ? Inserir(produtoModel)
                : Alterar(produtoModel);
        }

        public async Task<ProdutoModel> Inserir(ProdutoModel produtoModel)
        {
            return await _produtoRepository.Inserir(produtoModel);
        }

        public async Task<ProdutoModel> Alterar(ProdutoModel produtoModel)
        {
            return await _produtoRepository.Alterar(produtoModel);
        }

        public async Task<ProdutoModel> Deletar(int id)
        {
            return await _produtoRepository.Deletar(id);
        }

        public async Task<ProdutoModel> ObterPorId(int id)
        {
            return await _produtoRepository.ObterPorId(id);
        }

        public async Task<List<ProdutoModel>> BuscarProdutosPorNome(string nome)
        {
            return await _produtoRepository.BuscarProdutosPorNome(nome);
        }

        #endregion Methods
    }
}
