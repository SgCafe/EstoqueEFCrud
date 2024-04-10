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
            catch (Exception )
            {

                throw;
            }
        }

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

        #endregion Methods
    }
}
