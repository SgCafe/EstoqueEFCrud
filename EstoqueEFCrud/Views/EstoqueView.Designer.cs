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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.TbPrincipal = new System.Windows.Forms.TabControl();
            this.tabPageProduto = new System.Windows.Forms.TabPage();
            this.BtnDeletarCat = new System.Windows.Forms.Button();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.BtnEditarCat = new System.Windows.Forms.Button();
            this.BtnAdicionarCat = new System.Windows.Forms.Button();
            this.BtnDeletarProduto = new System.Windows.Forms.Button();
            this.BtnEditarProduto = new System.Windows.Forms.Button();
            this.BtnAdicionarProduto = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.BtnProcurar = new System.Windows.Forms.Button();
            this.CboxSelecionaCat = new System.Windows.Forms.ComboBox();
            this.TxProcuraProd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPageCategoria = new System.Windows.Forms.TabPage();
            this.BtnSalvarCat = new System.Windows.Forms.Button();
            this.BtnCancelarCat = new System.Windows.Forms.Button();
            this.TxNomeCat = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPageAddProd = new System.Windows.Forms.TabPage();
            this.BtSalvarProd = new System.Windows.Forms.Button();
            this.BtCancelarProd = new System.Windows.Forms.Button();
            this.NudEstoque = new System.Windows.Forms.NumericUpDown();
            this.CboxCategoriaProd = new System.Windows.Forms.ComboBox();
            this.TxNomeProd = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TxPreco = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.TbPrincipal.SuspendLayout();
            this.tabPageProduto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.tabPageCategoria.SuspendLayout();
            this.tabPageAddProd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudEstoque)).BeginInit();
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
            this.TbPrincipal.Controls.Add(this.tabPageProduto);
            this.TbPrincipal.Controls.Add(this.tabPageCategoria);
            this.TbPrincipal.Controls.Add(this.tabPageAddProd);
            this.TbPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TbPrincipal.Location = new System.Drawing.Point(0, 60);
            this.TbPrincipal.Multiline = true;
            this.TbPrincipal.Name = "TbPrincipal";
            this.TbPrincipal.SelectedIndex = 0;
            this.TbPrincipal.Size = new System.Drawing.Size(798, 390);
            this.TbPrincipal.TabIndex = 1;
            // 
            // tabPageProduto
            // 
            this.tabPageProduto.Controls.Add(this.BtnDeletarCat);
            this.tabPageProduto.Controls.Add(this.BtnEditarCat);
            this.tabPageProduto.Controls.Add(this.BtnAdicionarCat);
            this.tabPageProduto.Controls.Add(this.BtnDeletarProduto);
            this.tabPageProduto.Controls.Add(this.BtnEditarProduto);
            this.tabPageProduto.Controls.Add(this.BtnAdicionarProduto);
            this.tabPageProduto.Controls.Add(this.dataGridView);
            this.tabPageProduto.Controls.Add(this.BtnProcurar);
            this.tabPageProduto.Controls.Add(this.CboxSelecionaCat);
            this.tabPageProduto.Controls.Add(this.TxProcuraProd);
            this.tabPageProduto.Controls.Add(this.label3);
            this.tabPageProduto.Controls.Add(this.label2);
            this.tabPageProduto.Font = new System.Drawing.Font("Inter", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageProduto.Location = new System.Drawing.Point(4, 22);
            this.tabPageProduto.Name = "tabPageProduto";
            this.tabPageProduto.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageProduto.Size = new System.Drawing.Size(790, 364);
            this.tabPageProduto.TabIndex = 0;
            this.tabPageProduto.Text = "Produtos";
            this.tabPageProduto.UseVisualStyleBackColor = true;
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
            this.BtnAdicionarCat.Click += new System.EventHandler(this.BtAdicionarCat);
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
            // 
            // dataGridView
            // 
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(27, 135);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(636, 216);
            this.dataGridView.TabIndex = 5;
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
            // CboxSelecionaCat
            // 
            this.CboxSelecionaCat.FormattingEnabled = true;
            this.CboxSelecionaCat.Location = new System.Drawing.Point(27, 37);
            this.CboxSelecionaCat.Name = "CboxSelecionaCat";
            this.CboxSelecionaCat.Size = new System.Drawing.Size(200, 22);
            this.CboxSelecionaCat.TabIndex = 0;
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
            // tabPageCategoria
            // 
            this.tabPageCategoria.Controls.Add(this.BtnSalvarCat);
            this.tabPageCategoria.Controls.Add(this.BtnCancelarCat);
            this.tabPageCategoria.Controls.Add(this.TxNomeCat);
            this.tabPageCategoria.Controls.Add(this.label6);
            this.tabPageCategoria.Controls.Add(this.label5);
            this.tabPageCategoria.Font = new System.Drawing.Font("Inter", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageCategoria.Location = new System.Drawing.Point(4, 22);
            this.tabPageCategoria.Name = "tabPageCategoria";
            this.tabPageCategoria.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCategoria.Size = new System.Drawing.Size(790, 364);
            this.tabPageCategoria.TabIndex = 1;
            this.tabPageCategoria.Text = "Categorias";
            this.tabPageCategoria.UseVisualStyleBackColor = true;
            // 
            // BtnSalvarCat
            // 
            this.BtnSalvarCat.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnSalvarCat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalvarCat.Font = new System.Drawing.Font("Inter", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalvarCat.Location = new System.Drawing.Point(418, 250);
            this.BtnSalvarCat.Name = "BtnSalvarCat";
            this.BtnSalvarCat.Size = new System.Drawing.Size(112, 42);
            this.BtnSalvarCat.TabIndex = 1;
            this.BtnSalvarCat.Text = "Salvar";
            this.BtnSalvarCat.UseVisualStyleBackColor = true;
            this.BtnSalvarCat.Click += new System.EventHandler(this.Btn_SalvarCat_Click);
            // 
            // BtnCancelarCat
            // 
            this.BtnCancelarCat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancelarCat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelarCat.Font = new System.Drawing.Font("Inter", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelarCat.Location = new System.Drawing.Point(285, 250);
            this.BtnCancelarCat.Name = "BtnCancelarCat";
            this.BtnCancelarCat.Size = new System.Drawing.Size(112, 42);
            this.BtnCancelarCat.TabIndex = 2;
            this.BtnCancelarCat.Text = "Cancelar";
            this.BtnCancelarCat.UseVisualStyleBackColor = true;
            // 
            // TxNomeCat
            // 
            this.TxNomeCat.Location = new System.Drawing.Point(27, 94);
            this.TxNomeCat.Name = "TxNomeCat";
            this.TxNomeCat.Size = new System.Drawing.Size(212, 21);
            this.TxNomeCat.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(27, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(159, 19);
            this.label6.TabIndex = 1;
            this.label6.Text = "Nome da categoria:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Inter", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(333, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(195, 23);
            this.label5.TabIndex = 0;
            this.label5.Text = "Adicionar Categoria";
            // 
            // tabPageAddProd
            // 
            this.tabPageAddProd.Controls.Add(this.TxPreco);
            this.tabPageAddProd.Controls.Add(this.BtSalvarProd);
            this.tabPageAddProd.Controls.Add(this.BtCancelarProd);
            this.tabPageAddProd.Controls.Add(this.NudEstoque);
            this.tabPageAddProd.Controls.Add(this.CboxCategoriaProd);
            this.tabPageAddProd.Controls.Add(this.TxNomeProd);
            this.tabPageAddProd.Controls.Add(this.label11);
            this.tabPageAddProd.Controls.Add(this.label10);
            this.tabPageAddProd.Controls.Add(this.label9);
            this.tabPageAddProd.Controls.Add(this.label8);
            this.tabPageAddProd.Controls.Add(this.label7);
            this.tabPageAddProd.Location = new System.Drawing.Point(4, 22);
            this.tabPageAddProd.Name = "tabPageAddProd";
            this.tabPageAddProd.Size = new System.Drawing.Size(790, 364);
            this.tabPageAddProd.TabIndex = 2;
            this.tabPageAddProd.Text = "Add Prod";
            this.tabPageAddProd.UseVisualStyleBackColor = true;
            // 
            // BtSalvarProd
            // 
            this.BtSalvarProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtSalvarProd.Font = new System.Drawing.Font("Inter", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtSalvarProd.Location = new System.Drawing.Point(418, 250);
            this.BtSalvarProd.Name = "BtSalvarProd";
            this.BtSalvarProd.Size = new System.Drawing.Size(112, 42);
            this.BtSalvarProd.TabIndex = 11;
            this.BtSalvarProd.Text = "Salvar";
            this.BtSalvarProd.UseVisualStyleBackColor = true;
            // 
            // BtCancelarProd
            // 
            this.BtCancelarProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtCancelarProd.Font = new System.Drawing.Font("Inter", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtCancelarProd.Location = new System.Drawing.Point(285, 250);
            this.BtCancelarProd.Name = "BtCancelarProd";
            this.BtCancelarProd.Size = new System.Drawing.Size(112, 42);
            this.BtCancelarProd.TabIndex = 10;
            this.BtCancelarProd.Text = "Cancelar";
            this.BtCancelarProd.UseVisualStyleBackColor = true;
            // 
            // NudEstoque
            // 
            this.NudEstoque.Location = new System.Drawing.Point(301, 97);
            this.NudEstoque.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.NudEstoque.Name = "NudEstoque";
            this.NudEstoque.Size = new System.Drawing.Size(60, 20);
            this.NudEstoque.TabIndex = 1;
            // 
            // CboxCategoriaProd
            // 
            this.CboxCategoriaProd.FormattingEnabled = true;
            this.CboxCategoriaProd.Location = new System.Drawing.Point(27, 158);
            this.CboxCategoriaProd.Name = "CboxCategoriaProd";
            this.CboxCategoriaProd.Size = new System.Drawing.Size(212, 21);
            this.CboxCategoriaProd.TabIndex = 2;
            // 
            // TxNomeProd
            // 
            this.TxNomeProd.Location = new System.Drawing.Point(27, 97);
            this.TxNomeProd.Name = "TxNomeProd";
            this.TxNomeProd.Size = new System.Drawing.Size(212, 20);
            this.TxNomeProd.TabIndex = 0;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(27, 135);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(163, 20);
            this.label11.TabIndex = 5;
            this.label11.Text = "Categoria do produto:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(301, 135);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(135, 20);
            this.label10.TabIndex = 4;
            this.label10.Text = "Preço do produto:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(301, 74);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(160, 20);
            this.label9.TabIndex = 3;
            this.label9.Text = "Quantidade Estoque:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(27, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 20);
            this.label8.TabIndex = 2;
            this.label8.Text = "Nome do produto:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Inter", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(348, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(179, 23);
            this.label7.TabIndex = 1;
            this.label7.Text = "Adicionar Produto";
            // 
            // TxPreco
            // 
            this.TxPreco.Location = new System.Drawing.Point(301, 159);
            this.TxPreco.MaxLength = 99999;
            this.TxPreco.Name = "TxPreco";
            this.TxPreco.Size = new System.Drawing.Size(60, 20);
            this.TxPreco.TabIndex = 12;
            // 
            // EstoqueView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 450);
            this.Controls.Add(this.TbPrincipal);
            this.Controls.Add(this.panel1);
            this.Name = "EstoqueView";
            this.Text = "Controle de Estoque";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.TbPrincipal.ResumeLayout(false);
            this.tabPageProduto.ResumeLayout(false);
            this.tabPageProduto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.tabPageCategoria.ResumeLayout(false);
            this.tabPageCategoria.PerformLayout();
            this.tabPageAddProd.ResumeLayout(false);
            this.tabPageAddProd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudEstoque)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxProcuraProd;
        private System.Windows.Forms.Button BtnProcurar;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button BtnDeletarProduto;
        private System.Windows.Forms.Button BtnEditarProduto;
        private System.Windows.Forms.Button BtnAdicionarProduto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxNomeCat;
        private System.Windows.Forms.Button BtnCancelarCat;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxNomeProd;
        private System.Windows.Forms.ComboBox CboxCategoriaProd;
        private System.Windows.Forms.NumericUpDown NudEstoque;
        private System.Windows.Forms.Button BtSalvarProd;
        private System.Windows.Forms.Button BtCancelarProd;
        private System.Windows.Forms.Button BtnDeletarCat;
        private System.Windows.Forms.Button BtnEditarCat;
        private System.Windows.Forms.ImageList imageList;
        public System.Windows.Forms.Button BtnAdicionarCat;
        public System.Windows.Forms.TabControl TbPrincipal;
        public System.Windows.Forms.Button BtnSalvarCat;
        public System.Windows.Forms.TabPage tabPageProduto;
        public System.Windows.Forms.TabPage tabPageCategoria;
        public System.Windows.Forms.TabPage tabPageAddProd;
        private System.Windows.Forms.TextBox TxPreco;
        public System.Windows.Forms.ComboBox CboxSelecionaCat;
    }
}