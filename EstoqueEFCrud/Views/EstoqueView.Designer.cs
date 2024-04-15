namespace EstoqueEFCrud.Views
{
    partial class EstoqueView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EstoqueView));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.BtnDeletarCat = new System.Windows.Forms.Button();
            this.BtnEditarCat = new System.Windows.Forms.Button();
            this.BtnAdicionarCat = new System.Windows.Forms.Button();
            this.BtnDeletarProduto = new System.Windows.Forms.Button();
            this.BtnEditarProduto = new System.Windows.Forms.Button();
            this.BtnAdicionarProduto = new System.Windows.Forms.Button();
            this.DgvProdutos = new System.Windows.Forms.DataGridView();
            this.clmCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPreco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmEstoque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnProcurar = new System.Windows.Forms.Button();
            this.CboxListaPrincipal = new System.Windows.Forms.ComboBox();
            this.TxProcuraProd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(653, 60);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(27, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Estoque";
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "add.png");
            this.imageList.Images.SetKeyName(1, "edit.png");
            this.imageList.Images.SetKeyName(2, "delete.png");
            // 
            // BtnDeletarCat
            // 
            this.BtnDeletarCat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDeletarCat.ImageIndex = 2;
            this.BtnDeletarCat.ImageList = this.imageList;
            this.BtnDeletarCat.Location = new System.Drawing.Point(342, 107);
            this.BtnDeletarCat.Name = "BtnDeletarCat";
            this.BtnDeletarCat.Size = new System.Drawing.Size(40, 22);
            this.BtnDeletarCat.TabIndex = 20;
            this.BtnDeletarCat.UseVisualStyleBackColor = true;
            this.BtnDeletarCat.Click += new System.EventHandler(this.BtDeletarCat);
            // 
            // BtnEditarCat
            // 
            this.BtnEditarCat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEditarCat.ImageIndex = 1;
            this.BtnEditarCat.ImageList = this.imageList;
            this.BtnEditarCat.Location = new System.Drawing.Point(292, 107);
            this.BtnEditarCat.Name = "BtnEditarCat";
            this.BtnEditarCat.Size = new System.Drawing.Size(40, 22);
            this.BtnEditarCat.TabIndex = 19;
            this.BtnEditarCat.UseVisualStyleBackColor = true;
            this.BtnEditarCat.Click += new System.EventHandler(this.BtEditarCategoria);
            // 
            // BtnAdicionarCat
            // 
            this.BtnAdicionarCat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAdicionarCat.ImageIndex = 0;
            this.BtnAdicionarCat.ImageList = this.imageList;
            this.BtnAdicionarCat.Location = new System.Drawing.Point(242, 107);
            this.BtnAdicionarCat.Name = "BtnAdicionarCat";
            this.BtnAdicionarCat.Size = new System.Drawing.Size(40, 22);
            this.BtnAdicionarCat.TabIndex = 18;
            this.BtnAdicionarCat.UseVisualStyleBackColor = true;
            this.BtnAdicionarCat.Click += new System.EventHandler(this.BtAdicionarCat);
            // 
            // BtnDeletarProduto
            // 
            this.BtnDeletarProduto.BackColor = System.Drawing.Color.White;
            this.BtnDeletarProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDeletarProduto.Location = new System.Drawing.Point(544, 266);
            this.BtnDeletarProduto.Name = "BtnDeletarProduto";
            this.BtnDeletarProduto.Size = new System.Drawing.Size(85, 23);
            this.BtnDeletarProduto.TabIndex = 16;
            this.BtnDeletarProduto.Text = "Deletar";
            this.BtnDeletarProduto.UseVisualStyleBackColor = false;
            this.BtnDeletarProduto.Click += new System.EventHandler(this.BtDeletarProduto);
            // 
            // BtnEditarProduto
            // 
            this.BtnEditarProduto.BackColor = System.Drawing.Color.White;
            this.BtnEditarProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEditarProduto.Location = new System.Drawing.Point(544, 236);
            this.BtnEditarProduto.Name = "BtnEditarProduto";
            this.BtnEditarProduto.Size = new System.Drawing.Size(85, 23);
            this.BtnEditarProduto.TabIndex = 15;
            this.BtnEditarProduto.Text = "Editar";
            this.BtnEditarProduto.UseVisualStyleBackColor = false;
            this.BtnEditarProduto.Click += new System.EventHandler(this.BtEditarProd);
            // 
            // BtnAdicionarProduto
            // 
            this.BtnAdicionarProduto.BackColor = System.Drawing.Color.White;
            this.BtnAdicionarProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAdicionarProduto.Location = new System.Drawing.Point(544, 205);
            this.BtnAdicionarProduto.Name = "BtnAdicionarProduto";
            this.BtnAdicionarProduto.Size = new System.Drawing.Size(85, 23);
            this.BtnAdicionarProduto.TabIndex = 14;
            this.BtnAdicionarProduto.Text = "Adicionar";
            this.BtnAdicionarProduto.UseVisualStyleBackColor = false;
            this.BtnAdicionarProduto.Click += new System.EventHandler(this.BtAdicionarProduto);
            // 
            // DgvProdutos
            // 
            this.DgvProdutos.AllowUserToAddRows = false;
            this.DgvProdutos.AllowUserToDeleteRows = false;
            this.DgvProdutos.AllowUserToResizeColumns = false;
            this.DgvProdutos.AllowUserToResizeRows = false;
            this.DgvProdutos.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.DgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmCodigo,
            this.clmNome,
            this.clmPreco,
            this.clmEstoque});
            this.DgvProdutos.Location = new System.Drawing.Point(28, 205);
            this.DgvProdutos.Name = "DgvProdutos";
            this.DgvProdutos.ReadOnly = true;
            this.DgvProdutos.RowHeadersVisible = false;
            this.DgvProdutos.RowHeadersWidth = 51;
            this.DgvProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvProdutos.Size = new System.Drawing.Size(503, 216);
            this.DgvProdutos.TabIndex = 17;
            this.DgvProdutos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvDoubleClick);
            // 
            // clmCodigo
            // 
            this.clmCodigo.DataPropertyName = "IdProduto";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Format = "D4";
            this.clmCodigo.DefaultCellStyle = dataGridViewCellStyle1;
            this.clmCodigo.HeaderText = "Código";
            this.clmCodigo.MinimumWidth = 6;
            this.clmCodigo.Name = "clmCodigo";
            this.clmCodigo.ReadOnly = true;
            this.clmCodigo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clmCodigo.Width = 70;
            // 
            // clmNome
            // 
            this.clmNome.DataPropertyName = "Nome";
            this.clmNome.HeaderText = "Nome do Produto";
            this.clmNome.MinimumWidth = 6;
            this.clmNome.Name = "clmNome";
            this.clmNome.ReadOnly = true;
            this.clmNome.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clmNome.Width = 180;
            // 
            // clmPreco
            // 
            this.clmPreco.DataPropertyName = "Preco";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Format = "C2";
            this.clmPreco.DefaultCellStyle = dataGridViewCellStyle2;
            this.clmPreco.HeaderText = "Preço";
            this.clmPreco.MinimumWidth = 6;
            this.clmPreco.Name = "clmPreco";
            this.clmPreco.ReadOnly = true;
            this.clmPreco.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clmPreco.Width = 125;
            // 
            // clmEstoque
            // 
            this.clmEstoque.DataPropertyName = "Estoque";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Format = "D4";
            this.clmEstoque.DefaultCellStyle = dataGridViewCellStyle3;
            this.clmEstoque.HeaderText = "Estoque";
            this.clmEstoque.MinimumWidth = 6;
            this.clmEstoque.Name = "clmEstoque";
            this.clmEstoque.ReadOnly = true;
            this.clmEstoque.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clmEstoque.Width = 125;
            // 
            // BtnProcurar
            // 
            this.BtnProcurar.BackColor = System.Drawing.Color.White;
            this.BtnProcurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnProcurar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnProcurar.Location = new System.Drawing.Point(510, 173);
            this.BtnProcurar.Name = "BtnProcurar";
            this.BtnProcurar.Size = new System.Drawing.Size(85, 23);
            this.BtnProcurar.TabIndex = 13;
            this.BtnProcurar.Text = "Procurar";
            this.BtnProcurar.UseVisualStyleBackColor = false;
            this.BtnProcurar.Click += new System.EventHandler(this.BtProcurarProduto);
            // 
            // CboxListaPrincipal
            // 
            this.CboxListaPrincipal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboxListaPrincipal.FormattingEnabled = true;
            this.CboxListaPrincipal.Location = new System.Drawing.Point(28, 107);
            this.CboxListaPrincipal.Name = "CboxListaPrincipal";
            this.CboxListaPrincipal.Size = new System.Drawing.Size(200, 21);
            this.CboxListaPrincipal.Sorted = true;
            this.CboxListaPrincipal.TabIndex = 9;
            this.CboxListaPrincipal.SelectedIndexChanged += new System.EventHandler(this.CboxFiltraProdutos);
            // 
            // TxProcuraProd
            // 
            this.TxProcuraProd.Location = new System.Drawing.Point(28, 174);
            this.TxProcuraProd.MaxLength = 99999;
            this.TxProcuraProd.Name = "TxProcuraProd";
            this.TxProcuraProd.Size = new System.Drawing.Size(469, 20);
            this.TxProcuraProd.TabIndex = 11;
            this.TxProcuraProd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KPSearchBoxq);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(245, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Procure um produto da categoria:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Selecione uma categoria:";
            // 
            // EstoqueView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 450);
            this.Controls.Add(this.BtnDeletarCat);
            this.Controls.Add(this.BtnEditarCat);
            this.Controls.Add(this.BtnAdicionarCat);
            this.Controls.Add(this.BtnDeletarProduto);
            this.Controls.Add(this.BtnEditarProduto);
            this.Controls.Add(this.BtnAdicionarProduto);
            this.Controls.Add(this.DgvProdutos);
            this.Controls.Add(this.BtnProcurar);
            this.Controls.Add(this.CboxListaPrincipal);
            this.Controls.Add(this.TxProcuraProd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "EstoqueView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controle de Estoque";
            this.Load += new System.EventHandler(this.FormLoad);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProdutos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.Button BtnDeletarCat;
        private System.Windows.Forms.Button BtnEditarCat;
        public System.Windows.Forms.Button BtnAdicionarCat;
        private System.Windows.Forms.Button BtnDeletarProduto;
        private System.Windows.Forms.Button BtnEditarProduto;
        private System.Windows.Forms.Button BtnAdicionarProduto;
        private System.Windows.Forms.DataGridView DgvProdutos;
        private System.Windows.Forms.Button BtnProcurar;
        public System.Windows.Forms.ComboBox CboxListaPrincipal;
        private System.Windows.Forms.TextBox TxProcuraProd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPreco;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmEstoque;
    }
}