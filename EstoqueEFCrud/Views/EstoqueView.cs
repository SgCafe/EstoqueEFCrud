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
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstoqueEFCrud.Views
{
    public partial class EstoqueView : Form
    {
        #region Fields

        private readonly IEstoqueService _service;
        private EModoOperacao _modoOperacao;

        #endregion Fields

        #region Constructors

        public EstoqueView()
        {
            InitializeComponent();
            _service = new EstoqueService();
        }

        #endregion Constructors

        #region Methods

        private async void FormLoad(object sender, EventArgs e)
        {
            await AtualizarCboxCategorias();
            await AtualizarProdutos();
        }

        private void DgvDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            BtEditarProd(null, null);
        }

        private async Task AtualizarCboxCategorias()
        {
            var categorias = await _service.TodasCategorias();

            CboxListaPrincipal.DataSource = categorias;
            CboxListaPrincipal.DisplayMember = "Nome";
            CboxListaPrincipal.ValueMember = "IdCategoria";

        }

        private async Task AtualizarProdutos()
        {
            if (CboxListaPrincipal.Items.Count > 0)
            {
                this.Cursor = Cursors.WaitCursor;

                int idCategoria = (CboxListaPrincipal.SelectedItem as CategoriaModel).IdCategoria;

                DgvProdutos.DataSource = await _service.TodosProdutos(idCategoria);

                DgvProdutos.Columns["IdCategoria"].Visible = false;
                DgvProdutos.Columns["Categoria"].Visible = false;

                DgvProdutos.Columns["clmCodigo"].HeaderCell.Style.Alignment =
                    DataGridViewContentAlignment.MiddleCenter;
                DgvProdutos.Columns["clmPreco"].HeaderCell.Style.Alignment =
                    DataGridViewContentAlignment.MiddleCenter;
                DgvProdutos.Columns["clmEstoque"].HeaderCell.Style.Alignment =
                    DataGridViewContentAlignment.MiddleCenter;

                this.Cursor = Cursors.Default;
            }
        }

        private async void CboxFiltraProdutos(object sender, EventArgs e)
        {
            await AtualizarProdutos();
        }

        private async void KPSearchBoxq(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                this.Cursor = Cursors.WaitCursor;

                var produtoEncontrado = await _service.BuscarProdutosPorNome(TxProcuraProd.Text);

                int idCategoriaSelecionada = (CboxListaPrincipal.SelectedItem as CategoriaModel).IdCategoria;
                var produtoFiltrado = produtoEncontrado
                    .Where(p => p.IdCategoria == idCategoriaSelecionada)
                    .ToList();

                DgvProdutos.DataSource = produtoFiltrado;
                DgvProdutos.Columns["IdCategoria"].Visible = false;
                DgvProdutos.Columns["Categoria"].Visible = false;

                this.Cursor = Cursors.Default;
            }
        }

        private async void BtProcurarProduto(object sender, EventArgs e)
        {

            var produtoEncontrado = await _service.BuscarProdutosPorNome(TxProcuraProd.Text);
            int idCategoriaSelecionada = (CboxListaPrincipal.SelectedItem as CategoriaModel).IdCategoria;
            var produtoFiltrado = produtoEncontrado
                .Where(p => p.IdCategoria == idCategoriaSelecionada)
                .ToList();

            DgvProdutos.DataSource = produtoFiltrado;
            DgvProdutos.Columns["IdCategoria"].Visible = false;
            DgvProdutos.Columns["Categoria"].Visible = false;
        }

        #region Categoria

        private async void BtAdicionarCat(object sender, EventArgs e)
        {
            using (var form = new FormCadastrarCat())
            {
                form.LblCat.Text = "Adicionar Categoria";
                if (form.ShowDialog() == DialogResult.OK)
                {
                    var categoria = new CategoriaModel { Nome = form.TxNomeCat.Text };
                    await _service.AdicionarCategoria(categoria);

                    await AtualizarCboxCategorias();

                    CboxListaPrincipal.Text = categoria.Nome;
                }
            }
        }

        private async void BtEditarCategoria(object sender, EventArgs e)
        {
            using(var form = new FormCadastrarCat())
            {
                form.LblCat.Text = "Editar Categoria";
                form.TxNomeCat.Text = CboxListaPrincipal.Text;

                if (form.ShowDialog() == DialogResult.OK)
                {
                    var categoriaSelecionada = CboxListaPrincipal.SelectedItem as CategoriaModel;
                    categoriaSelecionada.Nome = form.TxNomeCat.Text;

                    await _service.EditarCategoria(categoriaSelecionada);

                    await AtualizarCboxCategorias();

                    CboxListaPrincipal.SelectedItem = categoriaSelecionada;
                }
            }
        }

        private async void BtDeletarCat(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja deletar a categoria?", "Informação", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var categoriaSelecionada = (CboxListaPrincipal.SelectedItem as CategoriaModel).IdCategoria;
                await _service.DeletarCategoria(categoriaSelecionada);

                await AtualizarCboxCategorias();
            }
        }

        #endregion Categoria

        #region Produto

        private async void BtAdicionarProduto(object sender, EventArgs e)
        {
            using (var formProd = new FormCadastrarProd())
            {
                formProd.LblProd.Text = "Adicionar Produto";
                formProd.CboxProd.SelectedIndex = CboxListaPrincipal.SelectedIndex;
                if (formProd.ShowDialog() == DialogResult.OK)
                {
                    var produto = new ProdutoModel
                    {
                        Nome = formProd.TxNomeProd.Text,
                        Estoque = Convert.ToInt32(formProd.NudEstoque.Value),
                        IdCategoria = (formProd.CboxProd.SelectedItem as CategoriaModel).IdCategoria,
                        Preco = Convert.ToDouble(formProd.TxPreco.Text)
                    };

                    await _service.AdicionarProduto(produto);

                    CboxListaPrincipal.SelectedItem = produto;
                    await AtualizarProdutos();
                }
            }
        }

        private async void BtEditarProd(object sender, EventArgs e)
        {
            DataGridViewRow linhaSelecionada = null;

            if (DgvProdutos.SelectedRows.Count > 0)
            {
                linhaSelecionada = DgvProdutos.SelectedRows[0];
                var produto = linhaSelecionada.DataBoundItem as ProdutoModel;

                using (var formProd = new FormCadastrarProd())
                {
                    formProd.LblProd.Text = "Editar produto";
                    formProd.TxNomeProd.Text = produto.Nome;
                    formProd.TxPreco.Text = produto.Preco.ToString();
                    formProd.NudEstoque.Value = produto.Estoque;
                    formProd.CboxProd.SelectedIndex = formProd.CboxProd.FindString(produto.Categoria.Nome);

                    if (formProd.ShowDialog() == DialogResult.OK)
                    {
                        var produtoAtualizado = new ProdutoModel
                        {
                            IdProduto = produto.IdProduto,
                            Nome = formProd.TxNomeProd.Text,
                            Estoque = Convert.ToInt32(formProd.NudEstoque.Value),
                            IdCategoria = (formProd.CboxProd.SelectedItem as CategoriaModel).IdCategoria,
                            Preco = Convert.ToDouble(formProd.TxPreco.Text)
                        };

                        await _service.EditarProduto(produtoAtualizado);
                        CboxListaPrincipal.SelectedIndex = formProd.CboxProd.SelectedIndex;
                        await AtualizarCboxCategorias();
                    }
                }
            }
        }

        private async void BtDeletarProduto(object sender, EventArgs e)
        {
            DataGridViewRow linhaSelecionada = null;
            if (DgvProdutos.SelectedRows.Count > 0)
            {
                linhaSelecionada = DgvProdutos.SelectedRows[0];
                var produto = (linhaSelecionada.DataBoundItem as ProdutoModel).IdProduto;
                if (MessageBox.Show($"Deseja deletar o produto?", "Informação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    await _service.DeletarProduto(produto);
                    await AtualizarProdutos();

                    TxProcuraProd.Text = string.Empty;
                }
            }
        }

        #endregion Produto

        #endregion Methods

    }
}
