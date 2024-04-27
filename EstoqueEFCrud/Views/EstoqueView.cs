using EstoqueEFCrud.Models;
using EstoqueEFCrud.Services;
using EstoqueEFCrud.Services.Contracts;
using EstoqueEFCrud.Util;
using System;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstoqueEFCrud.Views
{
    public partial class EstoqueView : Form
    {
        #region Properties

        private readonly IProdutoService _produtoService;
        private readonly ICategoriaService _categoriaService;

        #endregion Properties

        #region Constructors

        public EstoqueView()
        {
            InitializeComponent();

            _produtoService = new ProdutoService();
            _categoriaService = new CategoriaService();
        }

        #endregion Constructors

        #region Methods

        private async void FormLoad(object sender, EventArgs e)
        {
            try
            {
                DgvProdutos.AutoGenerateColumns = false;

                await AtualizarCboxCategorias();
                await AtualizarProdutos();
            }
            catch (Exception ex)
            {
                MessageBoxUtil.Erro(this, ex);
            }
        }

        private void DgvDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            BtEditarProd(null, null);
        }

        private async Task AtualizarCboxCategorias()
        {
            var categorias = await _categoriaService.ObterTodos();

            CboxListaPrincipal.DataSource = categorias;
            CboxListaPrincipal.DisplayMember = "Nome";
            CboxListaPrincipal.ValueMember = "IdCategoria";
        }

        private async Task AtualizarProdutos()
        {
            if (CboxListaPrincipal.Items.Count <= 0)
            {
                return;
            }

            Cursor = Cursors.WaitCursor;

            int idCategoria = (CboxListaPrincipal.SelectedItem as CategoriaModel).IdCategoria; //(int)CboxListaPrincipal.SelectedValue; 

            DgvProdutos.DataSource = await _produtoService.ObterTodosDaCategoria(idCategoria);
            Cursor = Cursors.Default;
        }

        private async void CboxFiltraProdutos(object sender, EventArgs e)
        {
            await AtualizarProdutos();
        }

        private async void KPSearchBoxq(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                Cursor = Cursors.WaitCursor;

                var produtoEncontrado = await _produtoService.BuscarProdutosPorNome(TxProcuraProd.Text);

                int idCategoriaSelecionada = (CboxListaPrincipal.SelectedItem as CategoriaModel).IdCategoria;
                var produtoFiltrado = produtoEncontrado
                    .Where(p => p.IdCategoria == idCategoriaSelecionada)
                    .ToList();

                DgvProdutos.DataSource = produtoFiltrado;

                Cursor = Cursors.Default;
            }
        }

        private async void BtProcurarProduto(object sender, EventArgs e)
        {
            var produtoEncontrado = await _produtoService.BuscarProdutosPorNome(TxProcuraProd.Text);
            int idCategoriaSelecionada = (CboxListaPrincipal.SelectedItem as CategoriaModel).IdCategoria;
            var produtoFiltrado = produtoEncontrado
                .Where(p => p.IdCategoria == idCategoriaSelecionada)
                .ToList();

            DgvProdutos.DataSource = produtoFiltrado;

        }

        private void AbrirRelatorio(object sender, EventArgs e)
        {
            using (var form = new FrmExibirRelatorio())
            {
                form.ShowDialog();
            }
        }

        private async void BtAdicionarCat(object sender, EventArgs e)
        {
            try
            {
                using (var form = new FormCadastrarCat())
                {
                    form.LblCat.Text = "Adicionar Categoria";
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        var categoria = new CategoriaModel { IdCategoria = 0, Nome = form.TxNomeCat.Text };
                        await _categoriaService.Salvar(categoria);

                        MessageBoxUtil.Sucesso(this);

                        await AtualizarCboxCategorias();

                        CboxListaPrincipal.Text = categoria.Nome;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBoxUtil.Erro(this, ex);
            }
        }

        private async void BtEditarCategoria(object sender, EventArgs e)
        {
            try
            {
                using (var form = new FormCadastrarCat())
                {
                    form.LblCat.Text = "Editar Categoria";
                    form.TxNomeCat.Text = CboxListaPrincipal.Text;

                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        var categoriaSelecionada = CboxListaPrincipal.SelectedItem as CategoriaModel;
                        categoriaSelecionada.Nome = form.TxNomeCat.Text;

                        await _categoriaService.Salvar(categoriaSelecionada);

                        MessageBoxUtil.Sucesso(this);

                        await AtualizarCboxCategorias();

                        CboxListaPrincipal.SelectedItem = categoriaSelecionada;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBoxUtil.Erro(this, ex);
            }
        }

        private async void BtDeletarCat(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Deseja deletar a categoria?", "Informação", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    var categoriaSelecionada = (CboxListaPrincipal.SelectedItem as CategoriaModel).IdCategoria;
                    await _categoriaService.Deletar(categoriaSelecionada);

                    MessageBoxUtil.Sucesso(this);

                    await AtualizarCboxCategorias();
                }
            }
            catch (Exception ex)
            {
                MessageBoxUtil.Erro(this, ex);
            }
        }

        private async void BtAdicionarProduto(object sender, EventArgs e)
        {
            try
            {
                using (var formProd = new FormCadastrarProd())
                {
                    formProd.LblProd.Text = "Adicionar Produto";
                    formProd.CboxProd.SelectedIndex = CboxListaPrincipal.SelectedIndex;
                    if (formProd.ShowDialog() == DialogResult.OK)
                    {
                        var produto = new ProdutoModel
                        {
                            IdProduto = 0,
                            Nome = formProd.TxNomeProd.Text,
                            Estoque = Convert.ToInt32(formProd.NudEstoque.Value),
                            IdCategoria = (formProd.CboxProd.SelectedItem as CategoriaModel).IdCategoria,
                            Preco = Convert.ToDouble(formProd.TxPreco.Text)
                        };

                        await _produtoService.Salvar(produto);

                        MessageBoxUtil.Sucesso(this);

                        CboxListaPrincipal.SelectedItem = produto;
                        await AtualizarProdutos();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBoxUtil.Erro(this, ex);
            }
        }

        private async void BtEditarProd(object sender, EventArgs e)
        {
            try
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

                            await _produtoService.Salvar(produtoAtualizado);
                            MessageBoxUtil.Sucesso(this);

                            await AtualizarCboxCategorias();
                            CboxListaPrincipal.SelectedIndex = formProd.CboxProd.SelectedIndex;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBoxUtil.Erro(this, ex);
            }
        }

        private async void BtDeletarProduto(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow linhaSelecionada = null;
                if (DgvProdutos.SelectedRows.Count > 0)
                {
                    linhaSelecionada = DgvProdutos.SelectedRows[0];
                    var produto = (linhaSelecionada.DataBoundItem as ProdutoModel).IdProduto;
                    if (MessageBox.Show($"Deseja deletar o produto?", "Informação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        await _produtoService.Deletar(produto);
                        MessageBoxUtil.Sucesso(this);

                        await AtualizarProdutos();

                        TxProcuraProd.Text = string.Empty;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBoxUtil.Erro(this, ex);
            }
        }

        #endregion Methods

    }
}
