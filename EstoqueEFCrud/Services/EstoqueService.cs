using EstoqueEFCrud.Models;
using EstoqueEFCrud.Repository;
using EstoqueEFCrud.Services.Contracts;
using EstoqueEFCrud.Views;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;

namespace EstoqueEFCrud.Services
{
    public class EstoqueService : IEstoqueService
    {

        #region Methods

        #region Categorias
        public async Task<IList<CategoriaModel>> TodasCategorias()
        {
            try
            {
                using (var context = new EstoqueContext())
                {
                    var connection = context.Database.GetDbConnection();
                    var listaCategorias = await connection.QueryAsync<CategoriaModel>("SELECT * FROM Categorias");
                    return listaCategorias.ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task AdicionarCategoria(CategoriaModel categoria)
        {
            try
            {
                using (var context = new EstoqueContext())
                {
                    var categoriaExiste = context.Categorias.Any(x => x.Nome == categoria.Nome);

                    if (!categoriaExiste)
                    {
                        var novaCategoria = new CategoriaModel { Nome = categoria.Nome };
                        context.Categorias.Add(novaCategoria);
                        await context.SaveChangesAsync();

                        MessageBox.Show("Categoria adicionada com sucesso.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("A Categoria já existe.", "Erro ao adicionar Categoria", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public async Task EditarCategoria(CategoriaModel categoria)
        {
            try
            {
                using (var context = new EstoqueContext())
                {
                    var categoriaExiste = context.Categorias.Any(x => x.Nome.Contains(categoria.Nome));

                    if (!categoriaExiste)
                    {
                        var categoriaSelecionada = new CategoriaModel { IdCategoria = categoria.IdCategoria, Nome = categoria.Nome, Produtos = categoria.Produtos };
                        context.Attach(categoriaSelecionada);
                        context.Entry(categoriaSelecionada).State = EntityState.Modified; ;
                        await context.SaveChangesAsync();

                        MessageBox.Show("Categoria atualizada com sucesso.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("A Categoria já existe.", "Erro ao adicionar Categoria", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public async Task DeletarCategoria(int id)
        {
            try
            {
                using (var context = new EstoqueContext())
                {
                    var contemProdutos = context.Produtos.Where(x => x.IdCategoria == id).Count();
                    if (contemProdutos == 0)
                    {
                        var categoria = new CategoriaModel { IdCategoria = id };
                        context.Attach(categoria);
                        context.Entry(categoria).State = EntityState.Deleted;
                        await context.SaveChangesAsync();

                        MessageBox.Show("Categoria deletada com sucesso.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Não é possível deletar a categoria, pois ela contem produtos adicionados.", "Erro ao deletar categoria", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion Categorias

        #region Produtos

        public async Task<IList<ProdutoModel>> TodosProdutos(int idCategoria)
        {
            try
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

                    return listaProdutos.ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task AdicionarProduto(ProdutoModel produto)
        {
            try
            {
                using (var context = new EstoqueContext())
                {
                    var produtoExiste = context.Produtos.Any(x => x.Nome == produto.Nome);

                    if (!produtoExiste)
                    {
                        var produtoAdicionado = new ProdutoModel
                        {
                            Nome = produto.Nome,
                            Estoque = produto.Estoque,
                            Preco = produto.Preco,
                            IdCategoria = produto.IdCategoria,
                        };
                        context.Produtos.Add(produtoAdicionado);
                        await context.SaveChangesAsync();

                        MessageBox.Show("Produto adicionado com sucesso.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("O produto já existe.", "Erro ao adicionar Produto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task EditarProduto(ProdutoModel produto)
        {
            try
            {
                using (var context = new EstoqueContext())
                {

                    var editarProduto = produto;
                    context.Attach(editarProduto);
                    context.Entry(editarProduto).State = EntityState.Modified;
                    await context.SaveChangesAsync();

                    MessageBox.Show("Produto atualizado com sucesso.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task DeletarProduto(int id)
        {
            try
            {
                using (var context = new EstoqueContext())
                {
                    var produtoDeletar = new ProdutoModel { IdProduto = id };
                    context.Attach(produtoDeletar);
                    context.Entry(produtoDeletar).State = EntityState.Deleted;
                    await context.SaveChangesAsync();

                    MessageBox.Show("Produto deletado com sucesso.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {

                throw;
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

        #endregion Produtos

        #endregion Methods
    }
}
