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
                    var listaCategorias = await context.Categorias.ToListAsync();
                    return listaCategorias;
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
                    var novaCategoria = new CategoriaModel { Nome = categoria.Nome };
                    context.Categorias.Add(novaCategoria);
                    await context.SaveChangesAsync();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task EditarCategoria(CategoriaModel categoria)
        {
            try
            {
                using (var context = new EstoqueContext())
                {
                    var categoriaSelecionada = new CategoriaModel { IdCategoria = categoria.IdCategoria, Nome = categoria.Nome, Produtos = categoria.Produtos };
                    context.Attach(categoriaSelecionada);
                    context.Entry(categoriaSelecionada).State = EntityState.Modified; ;
                    await context.SaveChangesAsync();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task DeletarCategoria(int id)
        {
            try
            {
                using (var context = new EstoqueContext())
                {
                    var categoria = new CategoriaModel { IdCategoria = id };
                    context.Attach(categoria);
                    context.Entry(categoria).State = EntityState.Deleted;
                    //context.Remove(categoria);
                    await context.SaveChangesAsync();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion Produtos

        #region Produtos

        public async Task<List<ProdutoModel>> TodosProdutos(int idCategoria)
        {
            try
            {
                using (var context = new EstoqueContext())
                {
                    var listaProdutos = await context.Produtos
                    .Where(x => x.IdCategoria == idCategoria)
                    .Include(x => x.Categoria)
                    .ToListAsync();
                    return listaProdutos;
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
                using(var context = new EstoqueContext())
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
                using(var context = new EstoqueContext())
                {
                    var editarProduto = produto;
                    context.Attach(editarProduto);
                    context.Entry(editarProduto).State = EntityState.Modified;
                    await context.SaveChangesAsync();
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
                using(var context = new EstoqueContext())
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
