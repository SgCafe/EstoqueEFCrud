﻿using EstoqueEFCrud.Models;
using EstoqueEFCrud.Relatorios;
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
    public partial class FrmExibirRelatorio : Form
    {
        #region Fields

        private readonly IProdutoService _produtoService;

        #endregion Fields

        #region Constructors

        public FrmExibirRelatorio()
        {
            InitializeComponent();
            _produtoService = new ProdutoService();
        }

        #endregion Constructors

        #region Methods

        private async void FrmExibirRelatorio_Load(object sender, EventArgs e)
        {
            var produtos = await _produtoService.TodosProdutos();

            RelatorioProdutos rlProdutos = new RelatorioProdutos();

            rlProdutos.Database.Tables["EstoqueEFCrud_Models_ProdutoModel"].SetDataSource(produtos);

            crvReport.ReportSource = null;
            crvReport.ReportSource = rlProdutos;

        }

        #endregion Methods

    }
}
