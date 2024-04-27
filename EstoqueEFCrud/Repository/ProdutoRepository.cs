using Dapper;
using EstoqueEFCrud.Models;
using EstoqueEFCrud.Repository.Contracts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EstoqueEFCrud.Repository
{
    public class ProdutoRepository : IProdutoRepository
    {
        #region Methods

        public async Task<List<ProdutoModel>> TodosProdutos()
        {
            using (var context = new EstoqueContext())
            {
                var listaProdutos = await context.Produtos.ToListAsync();
                return listaProdutos;
            }
        }

        public async Task<List<ProdutoModel>> ObterTodosDaCategoria(int idCategoria)
        {
            using (var context = new EstoqueContext())
            {
                var connection = context.Database.GetDbConnection();

                var query = @"
                SELECT p.*, c.IdCategoria, c.Nome
                FROM Produtos p INNER JOIN Categorias c
                ON p.IdCategoria = c.IdCategoria
                WHERE p.IdCategoria = @IdCategoria";

                var listaProdutos = await connection.QueryAsync<ProdutoModel, CategoriaModel, ProdutoModel>(
                    query,
                    (produto, categoria) =>
                    {
                        produto.Categoria = categoria;
                        return produto;
                    },
                    new { IdCategoria = idCategoria },
                    splitOn: "IdCategoria");

                return listaProdutos.AsList();
            }
        }

        public async Task<ProdutoModel> Inserir(ProdutoModel produto)
        {
            using (var context = new EstoqueContext())
            {
                context.Produtos.Add(produto);
                await context.SaveChangesAsync();

                return produto;
            }
        }

        public async Task<ProdutoModel> Alterar(ProdutoModel produto)
        {
            using (var context = new EstoqueContext())
            {
                context.Produtos.Update(produto);
                await context.SaveChangesAsync();

                return produto;
            }
        }

        public async Task<ProdutoModel> Deletar(int id)
        {
            using (var context = new EstoqueContext())
            {
                var produtoDeletar = await ObterPorId(id);

                context.Remove(produtoDeletar);
                await context.SaveChangesAsync();

                return produtoDeletar;
            }
        }

        public async Task<ProdutoModel> ObterPorId(int id)
        {
            using (var context = new EstoqueContext())
            {
                ProdutoModel produto = await context.Produtos
                    .AsNoTracking()
                    .FirstOrDefaultAsync(p => p.IdProduto == id);

                return produto;
            }
        }

        public async Task<List<ProdutoModel>> BuscarProdutosPorNome(string nome)
        {
            try
            {
                using (var context = new EstoqueContext())
                {
                    return await context.Produtos
                        .Where(x => x.Nome.Contains(nome))
                        .Include(c => c.Categoria)
                        .ToListAsync();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        #endregion Methods
    }
}
