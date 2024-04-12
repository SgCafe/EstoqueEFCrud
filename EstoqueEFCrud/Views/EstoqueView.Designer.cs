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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.TbPrincipal = new System.Windows.Forms.TabControl();
            this.tabPageLista = new System.Windows.Forms.TabPage();
            this.BtnDeletarCat = new System.Windows.Forms.Button();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.BtnEditarCat = new System.Windows.Forms.Button();
            this.BtnAdicionarCat = new System.Windows.Forms.Button();
            this.BtnDeletarProduto = new System.Windows.Forms.Button();
            this.BtnEditarProduto = new System.Windows.Forms.Button();
            this.BtnAdicionarProduto = new System.Windows.Forms.Button();
            this.dvgProdutos = new System.Windows.Forms.DataGridView();
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
            this.TbPrincipal.SuspendLayout();
            this.tabPageLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(798, 60);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Inter", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(27, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Estoque";
            // 
            // TbPrincipal
            // 
            this.TbPrincipal.Controls.Add(this.tabPageLista);
            this.TbPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TbPrincipal.Location = new System.Drawing.Point(0, 60);
            this.TbPrincipal.Multiline = true;
            this.TbPrincipal.Name = "TbPrincipal";
            this.TbPrincipal.SelectedIndex = 0;
            this.TbPrincipal.Size = new System.Drawing.Size(798, 390);
            this.TbPrincipal.TabIndex = 1;
            // 
            // tabPageLista
            // 
            this.tabPageLista.Controls.Add(this.BtnDeletarCat);
            this.tabPageLista.Controls.Add(this.BtnEditarCat);
            this.tabPageLista.Controls.Add(this.BtnAdicionarCat);
            this.tabPageLista.Controls.Add(this.BtnDeletarProduto);
            this.tabPageLista.Controls.Add(this.BtnEditarProduto);
            this.tabPageLista.Controls.Add(this.BtnAdicionarProduto);
            this.tabPageLista.Controls.Add(this.dvgProdutos);
            this.tabPageLista.Controls.Add(this.BtnProcurar);
            this.tabPageLista.Controls.Add(this.CboxListaPrincipal);
            this.tabPageLista.Controls.Add(this.TxProcuraProd);
            this.tabPageLista.Controls.Add(this.label3);
            this.tabPageLista.Controls.Add(this.label2);
            this.tabPageLista.Font = new System.Drawing.Font("Inter", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageLista.Location = new System.Drawing.Point(4, 22);
            this.tabPageLista.Name = "tabPageLista";
            this.tabPageLista.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageLista.Size = new System.Drawing.Size(790, 364);
            this.tabPageLista.TabIndex = 0;
            this.tabPageLista.Text = "Produtos";
            this.tabPageLista.UseVisualStyleBackColor = true;
            // 
            // BtnDeletarCat
            // 
            this.BtnDeletarCat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDeletarCat.ImageIndex = 2;
            this.BtnDeletarCat.ImageList = this.imageList;
            this.BtnDeletarCat.Location = new System.Drawing.Point(341, 37);
            this.BtnDeletarCat.Name = "BtnDeletarCat";
            this.BtnDeletarCat.Size = new System.Drawing.Size(40, 22);
            this.BtnDeletarCat.TabIndex = 8;
            this.BtnDeletarCat.UseVisualStyleBackColor = true;
            this.BtnDeletarCat.Click += new System.EventHandler(this.BtDeletarCat);
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "add.png");
            this.imageList.Images.SetKeyName(1, "edit.png");
            this.imageList.Images.SetKeyName(2, "delete.png");
            // 
            // BtnEditarCat
            // 
            this.BtnEditarCat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEditarCat.ImageIndex = 1;
            this.BtnEditarCat.ImageList = this.imageList;
            this.BtnEditarCat.Location = new System.Drawing.Point(291, 37);
            this.BtnEditarCat.Name = "BtnEditarCat";
            this.BtnEditarCat.Size = new System.Drawing.Size(40, 22);
            this.BtnEditarCat.TabIndex = 7;
            this.BtnEditarCat.UseVisualStyleBackColor = true;
            this.BtnEditarCat.Click += new System.EventHandler(this.BtEditarCategoria);
            // 
            // BtnAdicionarCat
            // 
            this.BtnAdicionarCat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAdicionarCat.ImageIndex = 0;
            this.BtnAdicionarCat.ImageList = this.imageList;
            this.BtnAdicionarCat.Location = new System.Drawing.Point(241, 37);
            this.BtnAdicionarCat.Name = "BtnAdicionarCat";
            this.BtnAdicionarCat.Size = new System.Drawing.Size(40, 22);
            this.BtnAdicionarCat.TabIndex = 6;
            this.BtnAdicionarCat.UseVisualStyleBackColor = true;
            // 
            // BtnDeletarProduto
            // 
            this.BtnDeletarProduto.BackColor = System.Drawing.Color.White;
            this.BtnDeletarProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDeletarProduto.Location = new System.Drawing.Point(673, 197);
            this.BtnDeletarProduto.Name = "BtnDeletarProduto";
            this.BtnDeletarProduto.Size = new System.Drawing.Size(85, 23);
            this.BtnDeletarProduto.TabIndex = 5;
            this.BtnDeletarProduto.Text = "Deletar";
            this.BtnDeletarProduto.UseVisualStyleBackColor = false;
            this.BtnDeletarProduto.Click += new System.EventHandler(this.BtDeletarProduto);
            // 
            // BtnEditarProduto
            // 
            this.BtnEditarProduto.BackColor = System.Drawing.Color.White;
            this.BtnEditarProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEditarProduto.Location = new System.Drawing.Point(673, 166);
            this.BtnEditarProduto.Name = "BtnEditarProduto";
            this.BtnEditarProduto.Size = new System.Drawing.Size(85, 23);
            this.BtnEditarProduto.TabIndex = 4;
            this.BtnEditarProduto.Text = "Editar";
            this.BtnEditarProduto.UseVisualStyleBackColor = false;
            this.BtnEditarProduto.Click += new System.EventHandler(this.BtEditarProdAsync);
            // 
            // BtnAdicionarProduto
            // 
            this.BtnAdicionarProduto.BackColor = System.Drawing.Color.White;
            this.BtnAdicionarProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAdicionarProduto.Location = new System.Drawing.Point(673, 135);
            this.BtnAdicionarProduto.Name = "BtnAdicionarProduto";
            this.BtnAdicionarProduto.Size = new System.Drawing.Size(85, 23);
            this.BtnAdicionarProduto.TabIndex = 3;
            this.BtnAdicionarProduto.Text = "Adicionar";
            this.BtnAdicionarProduto.UseVisualStyleBackColor = false;
            this.BtnAdicionarProduto.Click += new System.EventHandler(this.BtAdicionarProduto);
            // 
            // dvgProdutos
            // 
            this.dvgProdutos.AllowUserToAddRows = false;
            this.dvgProdutos.AllowUserToDeleteRows = false;
            this.dvgProdutos.AllowUserToResizeColumns = false;
            this.dvgProdutos.AllowUserToResizeRows = false;
            this.dvgProdutos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dvgProdutos.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dvgProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmCodigo,
            this.clmNome,
            this.clmPreco,
            this.clmEstoque});
            this.dvgProdutos.Location = new System.Drawing.Point(27, 135);
            this.dvgProdutos.Name = "dvgProdutos";
            this.dvgProdutos.ReadOnly = true;
            this.dvgProdutos.RowHeadersVisible = false;
            this.dvgProdutos.RowHeadersWidth = 51;
            this.dvgProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvgProdutos.Size = new System.Drawing.Size(636, 216);
            this.dvgProdutos.TabIndex = 5;
            this.dvgProdutos.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgDoubleClick);
            // 
            // clmCodigo
            // 
            this.clmCodigo.DataPropertyName = "IdProduto";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.Format = "D4";
            this.clmCodigo.DefaultCellStyle = dataGridViewCellStyle7;
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
            this.clmNome.Name = "clmNome";
            this.clmNome.ReadOnly = true;
            this.clmNome.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clmNome.Width = 150;
            // 
            // clmPreco
            // 
            this.clmPreco.DataPropertyName = "Preco";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.Format = "C2";
            this.clmPreco.DefaultCellStyle = dataGridViewCellStyle8;
            this.clmPreco.HeaderText = "Preço";
            this.clmPreco.MinimumWidth = 6;
            this.clmPreco.Name = "clmPreco";
            this.clmPreco.ReadOnly = true;
            this.clmPreco.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // clmEstoque
            // 
            this.clmEstoque.DataPropertyName = "Estoque";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.Format = "D4";
            this.clmEstoque.DefaultCellStyle = dataGridViewCellStyle9;
            this.clmEstoque.HeaderText = "Estoque";
            this.clmEstoque.Name = "clmEstoque";
            this.clmEstoque.ReadOnly = true;
            this.clmEstoque.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // BtnProcurar
            // 
            this.BtnProcurar.BackColor = System.Drawing.Color.White;
            this.BtnProcurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnProcurar.Font = new System.Drawing.Font("Inter", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnProcurar.Location = new System.Drawing.Point(509, 103);
            this.BtnProcurar.Name = "BtnProcurar";
            this.BtnProcurar.Size = new System.Drawing.Size(85, 23);
            this.BtnProcurar.TabIndex = 2;
            this.BtnProcurar.Text = "Procurar";
            this.BtnProcurar.UseVisualStyleBackColor = false;
            // 
            // CboxListaPrincipal
            // 
            this.CboxListaPrincipal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboxListaPrincipal.FormattingEnabled = true;
            this.CboxListaPrincipal.Location = new System.Drawing.Point(27, 37);
            this.CboxListaPrincipal.Name = "CboxListaPrincipal";
            this.CboxListaPrincipal.Size = new System.Drawing.Size(200, 22);
            this.CboxListaPrincipal.Sorted = true;
            this.CboxListaPrincipal.TabIndex = 0;
            this.CboxListaPrincipal.SelectedIndexChanged += new System.EventHandler(this.CboxFiltraProdutos);
            // 
            // TxProcuraProd
            // 
            this.TxProcuraProd.Location = new System.Drawing.Point(27, 104);
            this.TxProcuraProd.MaxLength = 99999;
            this.TxProcuraProd.Name = "TxProcuraProd";
            this.TxProcuraProd.Size = new System.Drawing.Size(469, 21);
            this.TxProcuraProd.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(267, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Procure um produto da categoria:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Selecione uma categoria:";
            // 
            // EstoqueView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 450);
            this.Controls.Add(this.TbPrincipal);
            this.Controls.Add(this.panel1);
            this.Name = "EstoqueView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controle de Estoque";
            this.Load += new System.EventHandler(this.FormLoad);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.TbPrincipal.ResumeLayout(false);
            this.tabPageLista.ResumeLayout(false);
            this.tabPageLista.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgProdutos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxProcuraProd;
        private System.Windows.Forms.Button BtnProcurar;
        private System.Windows.Forms.DataGridView dvgProdutos;
        private System.Windows.Forms.Button BtnDeletarProduto;
        private System.Windows.Forms.Button BtnEditarProduto;
        private System.Windows.Forms.Button BtnAdicionarProduto;
        private System.Windows.Forms.Button BtnDeletarCat;
        private System.Windows.Forms.Button BtnEditarCat;
        private System.Windows.Forms.ImageList imageList;
        public System.Windows.Forms.Button BtnAdicionarCat;
        public System.Windows.Forms.TabControl TbPrincipal;
        public System.Windows.Forms.TabPage tabPageLista;
        public System.Windows.Forms.ComboBox CboxListaPrincipal;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPreco;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmEstoque;
    }
}