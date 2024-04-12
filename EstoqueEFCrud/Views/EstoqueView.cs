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

        private void TbRemoveAdd(TabPage tabControl)
        {
            TbPrincipal.TabPages.Clear();
            TbPrincipal.TabPages.Add(tabControl);
        }

        private void dvgDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            BtEditarProdAsync(null, null);
        }

        private async Task AtualizarCboxCategorias()
        {
            var categorias = await _service.TodasCategorias();

            CboxListaPrincipal.DataSource = categorias;
            CboxListaPrincipal.DisplayMember = "Nome";
            CboxListaPrincipal.ValueMember = "IdCategoria";

            //CboxProd.DataSource = categorias;
            //CboxProd.DisplayMember = "Nome";
            //CboxProd.ValueMember = "IdCategoria";
            
        }

        private async Task AtualizarProdutos()
        {
            if (CboxListaPrincipal.Items.Count > 0)
            {
                this.Cursor = Cursors.WaitCursor;

                int idCategoria = (CboxListaPrincipal.SelectedItem as CategoriaModel).IdCategoria;

                dvgProdutos.DataSource = await _service.TodosProdutos(idCategoria);

                dvgProdutos.Columns["IdCategoria"].Visible = false;
                dvgProdutos.Columns["Categoria"].Visible = false;

                dvgProdutos.Columns["clmCodigo"].HeaderCell.Style.Alignment =
                    DataGridViewContentAlignment.MiddleCenter;
                dvgProdutos.Columns["clmPreco"].HeaderCell.Style.Alignment =
                    DataGridViewContentAlignment.MiddleCenter;
                dvgProdutos.Columns["clmEstoque"].HeaderCell.Style.Alignment =
                    DataGridViewContentAlignment.MiddleCenter;

                this.Cursor = Cursors.Default;
            }
        }

        private async void CboxFiltraProdutos(object sender, EventArgs e)
        {
            await AtualizarProdutos();
        }

        private void ItemSelecionadoProd(object sender, EventArgs e)
        {
            //if (CboxProd.SelectedItem != null)
            //{
            //    CategoriaModel categoriaSelecionada = CboxProd.SelectedItem as CategoriaModel;
            //    if (categoriaSelecionada != null)
            //    {
            //        MessageBox.Show($"Categoria Selecionada: ID = {categoriaSelecionada.IdCategoria}, Nome = {categoriaSelecionada.Nome}", "Categoria Atualizada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    }
            //}
        }

        #region Categoria

        private async void BtAdicionarCat(object sender, EventArgs e)
        {
            _modoOperacao = EModoOperacao.Adicionar;
            using (var formCat = new FormCadastrarCat())
            {
                formCat.LblCat.Text = "AdicionarCategoria";
                if (formCat.DialogResult == DialogResult.OK)
                {
                    var categoria = new CategoriaModel { Nome = formCat.TxNomeCat.Text };
                    await _service.AdicionarCategoria(categoria);

                    await AtualizarCboxCategorias();

                    CboxListaPrincipal.Text = categoria.Nome;

                    MessageBox.Show("Categoria adicionada com sucesso.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private async void BtEditarCategoria(object sender, EventArgs e)
        {
            using(var form = new FormCadastrarCat())
            {
                form.LblCat.Text = "EditarCategoria";
                form.TxNomeCat.Text = CboxListaPrincipal.Text;

                if (_modoOperacao == EModoOperacao.Editar)
                {
                    var categoriaSelecionada = CboxListaPrincipal.SelectedItem as CategoriaModel;
                    categoriaSelecionada.Nome = form.TxNomeCat.Text;

                    await _service.EditarCategoria(categoriaSelecionada);
                    await AtualizarCboxCategorias();

                    CboxListaPrincipal.SelectedItem = categoriaSelecionada;

                    MessageBox.Show("Categoria editada com sucesso.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                MessageBox.Show("Categoria deletada com sucesso.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        #endregion Categoria

        #region Produto

        private void BtAdicionarProduto(object sender, EventArgs e)
        {
            //TbRemoveAdd(tabPageAddProd);
            //LbProduto.Text = "Adicionar Produto";
            //CboxProd.SelectedIndex = CboxListaPrincipal.SelectedIndex;
            //_modoOperacao = EModoOperacao.Adicionar;
        }

        private async void BtEditarProdAsync(object sender, EventArgs e)
        {
            DataGridViewRow linhaSelecionada = null;

            if (dvgProdutos.SelectedRows.Count > 0)
            {
                linhaSelecionada = dvgProdutos.SelectedRows[0];
                var produto = linhaSelecionada.DataBoundItem as ProdutoModel;

                //LbProdId.Text = produto.IdProduto.ToString();
                //TxNomeProd.Text = produto.Nome;
                //TxPreco.Text = produto.Preco.ToString();
                //NudEstoque.Value = produto.Estoque;
                //CboxProd.SelectedValue = CboxProd.FindString(produto.Categoria.Nome);
                //TbRemoveAdd(tabPageAddProd);

                //TbRemoveAdd(tabPageAddProd);
                //LbProduto.Text = "Editar Produto";
                //_modoOperacao = EModoOperacao.Editar;
            }
        }

        private async void BtSalvarProd(object sender, EventArgs e)
        {
            if (_modoOperacao == EModoOperacao.Adicionar)
            {
                //var produto = new ProdutoModel
                //{
                //    Nome = TxNomeProd.Text,
                //    Estoque = Convert.ToInt32(NudEstoque.Value),
                //    IdCategoria = (CboxProd.SelectedItem as CategoriaModel).IdCategoria,
                //    Preco = Convert.ToDouble(TxPreco.Text)
                //};

                //await _service.AdicionarProduto(produto);

                //CboxListaPrincipal.SelectedItem = produto;

                MessageBox.Show("Produto adicionada com sucesso.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TbRemoveAdd(tabPageLista);
                await AtualizarProdutos();

            }
            else if (_modoOperacao == EModoOperacao.Editar)
            {

                //var produtoAtualizado = new ProdutoModel
                //{
                //    IdProduto = Convert.ToInt32(LbProdId.Text),
                //    Nome = TxNomeProd.Text,
                //    Estoque = Convert.ToInt32(NudEstoque.Value),
                //    IdCategoria = (CboxProd.SelectedItem as CategoriaModel).IdCategoria,
                //    Preco = Convert.ToDouble(TxPreco.Text)
                //};

                //await _service.EditarProduto(produtoAtualizado);
                //await AtualizarCboxCategorias();

                //CboxListaPrincipal.SelectedItem = produtoAtualizado;

                MessageBox.Show("Produto atualizado com sucesso.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TbRemoveAdd(tabPageLista);

            }
        }

        private async void BtDeletarProduto(object sender, EventArgs e)
        {
            DataGridViewRow linhaSelecionada = null;
            if (dvgProdutos.SelectedRows.Count > 0)
            {
                linhaSelecionada = dvgProdutos.SelectedRows[0];
                var produto = (linhaSelecionada.DataBoundItem as ProdutoModel).IdProduto;
                if (MessageBox.Show($"Deseja deletar o produto?", "Informação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    await _service.DeletarProduto(produto);
                    await AtualizarProdutos();
                }
            }
        }




        #endregion Produto

        #endregion Methods

    }
}
