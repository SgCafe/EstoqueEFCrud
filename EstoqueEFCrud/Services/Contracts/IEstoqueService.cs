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
        Task AdicionarCategoria(CategoriaModel categoria);
        Task<IList<CategoriaModel>> TodasCategorias();
    }
}
