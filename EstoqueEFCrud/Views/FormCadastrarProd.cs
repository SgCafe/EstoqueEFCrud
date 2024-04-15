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
        private readonly IEstoqueService _serice;

        public FormCadastrarProd()
        {
            InitializeComponent();
            _serice = new EstoqueService();
            AtualizarCboxProd();
        }

        private async void AtualizarCboxProd()
        {
            var produtos = await _serice.TodasCategorias();
            CboxProd.DataSource = produtos;
            CboxProd.DisplayMember = "Nome";
            CboxProd.ValueMember = "IdCategoria";
        }

    }
}
