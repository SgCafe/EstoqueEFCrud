using EstoqueEFCrud.Services;
using EstoqueEFCrud.Services.Contracts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstoqueEFCrud.Views
{
    public partial class FormCadastrarProd : Form
    {
        #region Properties

        private readonly ICategoriaService _categoriaService;

        #endregion Properties

        public FormCadastrarProd()
        {
            InitializeComponent();
            _categoriaService = new CategoriaService();
            AtualizarCboxProd();
        }

        private async void AtualizarCboxProd()
        {
            var produtos = await _categoriaService.ObterTodos();
            CboxProd.DataSource = produtos;
            CboxProd.DisplayMember = "Nome";
            CboxProd.ValueMember = "IdCategoria";
        }

        private void txBoxKP(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != ',' && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
