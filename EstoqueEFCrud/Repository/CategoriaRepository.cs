using Dapper;
using EstoqueEFCrud.Models;
using EstoqueEFCrud.Repository.Contracts;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EstoqueEFCrud.Repository
{
    public class CategoriaRepository : ICategoriaRepository
    {

        #region Methods

        public async Task<List<CategoriaModel>> ObterTodos()
        {
            using (var context = new EstoqueContext())
            {
                var connection = context.Database.GetDbConnection();

                var query = @"SELECT * FROM Categorias";

                var listaCategorias = await connection.QueryAsync<CategoriaModel>(query);
                return listaCategorias.AsList();
            }
        }

        public async Task<CategoriaModel> Inserir(CategoriaModel categoria)
        {
            using (var context = new EstoqueContext())
            {
                context.Categorias.Add(categoria);
                await context.SaveChangesAsync();

                return categoria;
            }
        }

        public async Task<CategoriaModel> Alterar(CategoriaModel categoria)
        {
            using (var context = new EstoqueContext())
            {
                context.Categorias.Update(categoria);
                await context.SaveChangesAsync();

                return categoria;
            }
        }

        public async Task<CategoriaModel> Deletar(int id)
        {
            using (var context = new EstoqueContext())
            {
                var categoriaDeletar = await ObterPorId(id);

                context.Remove(categoriaDeletar);
                await context.SaveChangesAsync();

                return categoriaDeletar;
            }
        }

        public async Task<CategoriaModel> ObterPorId(int id)
        {
            using (var context = new EstoqueContext())
            {
                CategoriaModel categoria = await context.Categorias
                    .AsNoTracking()
                    .FirstOrDefaultAsync(c => c.IdCategoria == id);

                return categoria;
            }
        }

        #endregion Methods
    }
}
