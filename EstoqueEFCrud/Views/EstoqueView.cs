using EstoqueEFCrud.Models;
using EstoqueEFCrud.Repository;
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
    public partial class EstoqueView : Form
    {
        #region Fields

        private readonly IEstoqueService _service;

        #endregion Fields

        #region Constructors

        public EstoqueView()
        {
            InitializeComponent();
            _service = new EstoqueService();
            TbPrincipal.TabPages.Remove(tabPageCategoria);
            TbPrincipal.TabPages.Remove(tabPageAddProd);
            _ = AtualizarCboxCategorias();
        }

        #endregion Constructors

        #region Methods

        private async Task AtualizarCboxCategorias()
        {
            var categorias = await _service.TodasCategorias();
            CboxSelecionaCat.DataSource = categorias;
            CboxSelecionaCat.DisplayMember = "Nome";
            CboxSelecionaCat.ValueMember = "IdCategoria";
        }

        private void TbRemoveAdd(TabPage tabControl)
        {
            TbPrincipal.TabPages.Clear();
            TbPrincipal.TabPages.Add(tabControl);
        }

        private void BtAdicionarCat(object sender, EventArgs e)
        {
            TbRemoveAdd(tabPageCategoria);
            tabPageCategoria.Text = "Adicionar Categoria";
        }

        private async void Btn_SalvarCat_Click(object sender, EventArgs e)
        {
            if (BtnSalvarCat.DialogResult == DialogResult.OK)
            {
                var categoria = new CategoriaModel { Nome = TxNomeCat.Text };
                await _service.AdicionarCategoria(categoria);
                await AtualizarCboxCategorias();
                MessageBox.Show("Categoria adicionada com sucesso.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxNomeCat.Text = string.Empty;
                TbRemoveAdd(tabPageProduto);
            }
        }

        #endregion Methods
    }
}
