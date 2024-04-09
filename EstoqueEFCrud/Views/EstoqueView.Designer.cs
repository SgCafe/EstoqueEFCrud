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
            this.TabControlPrincipal = new System.Windows.Forms.TabControl();
            this.tabPageProduto = new System.Windows.Forms.TabPage();
            this.Btn_DeletarCat = new System.Windows.Forms.Button();
            this.Btn_EditarCat = new System.Windows.Forms.Button();
            this.Btn_AdicionarCat = new System.Windows.Forms.Button();
            this.Btn_DeletarProduto = new System.Windows.Forms.Button();
            this.Btn_EditarProduto = new System.Windows.Forms.Button();
            this.Btn_AdicionarProduto = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Btn_Procurar = new System.Windows.Forms.Button();
            this.Cbx_SelecionaCat = new System.Windows.Forms.ComboBox();
            this.Txt_ProcuraProd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPageCategoria = new System.Windows.Forms.TabPage();
            this.Btn_SalvarCat = new System.Windows.Forms.Button();
            this.Btn_CancelarCat = new System.Windows.Forms.Button();
            this.Txt_NomeCat = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPageAddProd = new System.Windows.Forms.TabPage();
            this.Btn_SalvarProd = new System.Windows.Forms.Button();
            this.btn_CancelarProd = new System.Windows.Forms.Button();
            this.Nud_Preco = new System.Windows.Forms.NumericUpDown();
            this.Nud_Estoque = new System.Windows.Forms.NumericUpDown();
            this.Cbx_CategoriaProd = new System.Windows.Forms.ComboBox();
            this.Txt_NomeProd = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.panel1.SuspendLayout();
            this.TabControlPrincipal.SuspendLayout();
            this.tabPageProduto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.tabPageCategoria.SuspendLayout();
            this.tabPageAddProd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Nud_Preco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nud_Estoque)).BeginInit();
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
            // TabControlPrincipal
            // 
            this.TabControlPrincipal.Controls.Add(this.tabPageProduto);
            this.TabControlPrincipal.Controls.Add(this.tabPageCategoria);
            this.TabControlPrincipal.Controls.Add(this.tabPageAddProd);
            this.TabControlPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControlPrincipal.Location = new System.Drawing.Point(0, 60);
            this.TabControlPrincipal.Multiline = true;
            this.TabControlPrincipal.Name = "TabControlPrincipal";
            this.TabControlPrincipal.SelectedIndex = 0;
            this.TabControlPrincipal.Size = new System.Drawing.Size(798, 390);
            this.TabControlPrincipal.TabIndex = 1;
            // 
            // tabPageProduto
            // 
            this.tabPageProduto.Controls.Add(this.Btn_DeletarCat);
            this.tabPageProduto.Controls.Add(this.Btn_EditarCat);
            this.tabPageProduto.Controls.Add(this.Btn_AdicionarCat);
            this.tabPageProduto.Controls.Add(this.Btn_DeletarProduto);
            this.tabPageProduto.Controls.Add(this.Btn_EditarProduto);
            this.tabPageProduto.Controls.Add(this.Btn_AdicionarProduto);
            this.tabPageProduto.Controls.Add(this.dataGridView);
            this.tabPageProduto.Controls.Add(this.Btn_Procurar);
            this.tabPageProduto.Controls.Add(this.Cbx_SelecionaCat);
            this.tabPageProduto.Controls.Add(this.Txt_ProcuraProd);
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
            // Btn_DeletarCat
            // 
            this.Btn_DeletarCat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_DeletarCat.ImageIndex = 2;
            this.Btn_DeletarCat.ImageList = this.imageList;
            this.Btn_DeletarCat.Location = new System.Drawing.Point(341, 37);
            this.Btn_DeletarCat.Name = "Btn_DeletarCat";
            this.Btn_DeletarCat.Size = new System.Drawing.Size(40, 22);
            this.Btn_DeletarCat.TabIndex = 8;
            this.Btn_DeletarCat.UseVisualStyleBackColor = true;
            // 
            // Btn_EditarCat
            // 
            this.Btn_EditarCat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_EditarCat.ImageIndex = 1;
            this.Btn_EditarCat.ImageList = this.imageList;
            this.Btn_EditarCat.Location = new System.Drawing.Point(291, 37);
            this.Btn_EditarCat.Name = "Btn_EditarCat";
            this.Btn_EditarCat.Size = new System.Drawing.Size(40, 22);
            this.Btn_EditarCat.TabIndex = 7;
            this.Btn_EditarCat.UseVisualStyleBackColor = true;
            // 
            // Btn_AdicionarCat
            // 
            this.Btn_AdicionarCat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_AdicionarCat.ImageIndex = 0;
            this.Btn_AdicionarCat.ImageList = this.imageList;
            this.Btn_AdicionarCat.Location = new System.Drawing.Point(241, 37);
            this.Btn_AdicionarCat.Name = "Btn_AdicionarCat";
            this.Btn_AdicionarCat.Size = new System.Drawing.Size(40, 22);
            this.Btn_AdicionarCat.TabIndex = 6;
            this.Btn_AdicionarCat.UseVisualStyleBackColor = true;
            // 
            // Btn_DeletarProduto
            // 
            this.Btn_DeletarProduto.BackColor = System.Drawing.Color.White;
            this.Btn_DeletarProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_DeletarProduto.Location = new System.Drawing.Point(673, 197);
            this.Btn_DeletarProduto.Name = "Btn_DeletarProduto";
            this.Btn_DeletarProduto.Size = new System.Drawing.Size(85, 23);
            this.Btn_DeletarProduto.TabIndex = 5;
            this.Btn_DeletarProduto.Text = "Deletar";
            this.Btn_DeletarProduto.UseVisualStyleBackColor = false;
            // 
            // Btn_EditarProduto
            // 
            this.Btn_EditarProduto.BackColor = System.Drawing.Color.White;
            this.Btn_EditarProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_EditarProduto.Location = new System.Drawing.Point(673, 166);
            this.Btn_EditarProduto.Name = "Btn_EditarProduto";
            this.Btn_EditarProduto.Size = new System.Drawing.Size(85, 23);
            this.Btn_EditarProduto.TabIndex = 4;
            this.Btn_EditarProduto.Text = "Editar";
            this.Btn_EditarProduto.UseVisualStyleBackColor = false;
            // 
            // Btn_AdicionarProduto
            // 
            this.Btn_AdicionarProduto.BackColor = System.Drawing.Color.White;
            this.Btn_AdicionarProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_AdicionarProduto.Location = new System.Drawing.Point(673, 135);
            this.Btn_AdicionarProduto.Name = "Btn_AdicionarProduto";
            this.Btn_AdicionarProduto.Size = new System.Drawing.Size(85, 23);
            this.Btn_AdicionarProduto.TabIndex = 3;
            this.Btn_AdicionarProduto.Text = "Adicionar";
            this.Btn_AdicionarProduto.UseVisualStyleBackColor = false;
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
            // Btn_Procurar
            // 
            this.Btn_Procurar.BackColor = System.Drawing.Color.White;
            this.Btn_Procurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Procurar.Font = new System.Drawing.Font("Inter", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Procurar.Location = new System.Drawing.Point(509, 103);
            this.Btn_Procurar.Name = "Btn_Procurar";
            this.Btn_Procurar.Size = new System.Drawing.Size(85, 23);
            this.Btn_Procurar.TabIndex = 2;
            this.Btn_Procurar.Text = "Procurar";
            this.Btn_Procurar.UseVisualStyleBackColor = false;
            // 
            // Cbx_SelecionaCat
            // 
            this.Cbx_SelecionaCat.FormattingEnabled = true;
            this.Cbx_SelecionaCat.Location = new System.Drawing.Point(27, 37);
            this.Cbx_SelecionaCat.Name = "Cbx_SelecionaCat";
            this.Cbx_SelecionaCat.Size = new System.Drawing.Size(200, 22);
            this.Cbx_SelecionaCat.TabIndex = 0;
            // 
            // Txt_ProcuraProd
            // 
            this.Txt_ProcuraProd.Location = new System.Drawing.Point(27, 104);
            this.Txt_ProcuraProd.MaxLength = 99999;
            this.Txt_ProcuraProd.Name = "Txt_ProcuraProd";
            this.Txt_ProcuraProd.Size = new System.Drawing.Size(469, 21);
            this.Txt_ProcuraProd.TabIndex = 1;
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
            this.tabPageCategoria.Controls.Add(this.Btn_SalvarCat);
            this.tabPageCategoria.Controls.Add(this.Btn_CancelarCat);
            this.tabPageCategoria.Controls.Add(this.Txt_NomeCat);
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
            // Btn_SalvarCat
            // 
            this.Btn_SalvarCat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_SalvarCat.Font = new System.Drawing.Font("Inter", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_SalvarCat.Location = new System.Drawing.Point(418, 250);
            this.Btn_SalvarCat.Name = "Btn_SalvarCat";
            this.Btn_SalvarCat.Size = new System.Drawing.Size(112, 42);
            this.Btn_SalvarCat.TabIndex = 1;
            this.Btn_SalvarCat.Text = "Salvar";
            this.Btn_SalvarCat.UseVisualStyleBackColor = true;
            // 
            // Btn_CancelarCat
            // 
            this.Btn_CancelarCat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_CancelarCat.Font = new System.Drawing.Font("Inter", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_CancelarCat.Location = new System.Drawing.Point(285, 250);
            this.Btn_CancelarCat.Name = "Btn_CancelarCat";
            this.Btn_CancelarCat.Size = new System.Drawing.Size(112, 42);
            this.Btn_CancelarCat.TabIndex = 2;
            this.Btn_CancelarCat.Text = "Cancelar";
            this.Btn_CancelarCat.UseVisualStyleBackColor = true;
            // 
            // Txt_NomeCat
            // 
            this.Txt_NomeCat.Location = new System.Drawing.Point(27, 94);
            this.Txt_NomeCat.Name = "Txt_NomeCat";
            this.Txt_NomeCat.Size = new System.Drawing.Size(212, 21);
            this.Txt_NomeCat.TabIndex = 0;
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
            this.tabPageAddProd.Controls.Add(this.Btn_SalvarProd);
            this.tabPageAddProd.Controls.Add(this.btn_CancelarProd);
            this.tabPageAddProd.Controls.Add(this.Nud_Preco);
            this.tabPageAddProd.Controls.Add(this.Nud_Estoque);
            this.tabPageAddProd.Controls.Add(this.Cbx_CategoriaProd);
            this.tabPageAddProd.Controls.Add(this.Txt_NomeProd);
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
            // Btn_SalvarProd
            // 
            this.Btn_SalvarProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_SalvarProd.Font = new System.Drawing.Font("Inter", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_SalvarProd.Location = new System.Drawing.Point(418, 250);
            this.Btn_SalvarProd.Name = "Btn_SalvarProd";
            this.Btn_SalvarProd.Size = new System.Drawing.Size(112, 42);
            this.Btn_SalvarProd.TabIndex = 11;
            this.Btn_SalvarProd.Text = "Salvar";
            this.Btn_SalvarProd.UseVisualStyleBackColor = true;
            // 
            // btn_CancelarProd
            // 
            this.btn_CancelarProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CancelarProd.Font = new System.Drawing.Font("Inter", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CancelarProd.Location = new System.Drawing.Point(285, 250);
            this.btn_CancelarProd.Name = "btn_CancelarProd";
            this.btn_CancelarProd.Size = new System.Drawing.Size(112, 42);
            this.btn_CancelarProd.TabIndex = 10;
            this.btn_CancelarProd.Text = "Cancelar";
            this.btn_CancelarProd.UseVisualStyleBackColor = true;
            // 
            // Nud_Preco
            // 
            this.Nud_Preco.Location = new System.Drawing.Point(301, 158);
            this.Nud_Preco.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.Nud_Preco.Name = "Nud_Preco";
            this.Nud_Preco.Size = new System.Drawing.Size(60, 20);
            this.Nud_Preco.TabIndex = 3;
            // 
            // Nud_Estoque
            // 
            this.Nud_Estoque.Location = new System.Drawing.Point(301, 97);
            this.Nud_Estoque.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.Nud_Estoque.Name = "Nud_Estoque";
            this.Nud_Estoque.Size = new System.Drawing.Size(60, 20);
            this.Nud_Estoque.TabIndex = 1;
            // 
            // Cbx_CategoriaProd
            // 
            this.Cbx_CategoriaProd.FormattingEnabled = true;
            this.Cbx_CategoriaProd.Location = new System.Drawing.Point(27, 158);
            this.Cbx_CategoriaProd.Name = "Cbx_CategoriaProd";
            this.Cbx_CategoriaProd.Size = new System.Drawing.Size(212, 21);
            this.Cbx_CategoriaProd.TabIndex = 2;
            // 
            // Txt_NomeProd
            // 
            this.Txt_NomeProd.Location = new System.Drawing.Point(27, 97);
            this.Txt_NomeProd.Name = "Txt_NomeProd";
            this.Txt_NomeProd.Size = new System.Drawing.Size(212, 20);
            this.Txt_NomeProd.TabIndex = 0;
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
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "add.png");
            this.imageList.Images.SetKeyName(1, "edit.png");
            this.imageList.Images.SetKeyName(2, "delete.png");
            // 
            // EstoqueView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 450);
            this.Controls.Add(this.TabControlPrincipal);
            this.Controls.Add(this.panel1);
            this.Name = "EstoqueView";
            this.Text = "Controle de Estoque";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.TabControlPrincipal.ResumeLayout(false);
            this.tabPageProduto.ResumeLayout(false);
            this.tabPageProduto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.tabPageCategoria.ResumeLayout(false);
            this.tabPageCategoria.PerformLayout();
            this.tabPageAddProd.ResumeLayout(false);
            this.tabPageAddProd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Nud_Preco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nud_Estoque)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl TabControlPrincipal;
        private System.Windows.Forms.TabPage tabPageProduto;
        private System.Windows.Forms.TabPage tabPageCategoria;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Cbx_SelecionaCat;
        private System.Windows.Forms.TextBox Txt_ProcuraProd;
        private System.Windows.Forms.Button Btn_Procurar;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button Btn_DeletarProduto;
        private System.Windows.Forms.Button Btn_EditarProduto;
        private System.Windows.Forms.Button Btn_AdicionarProduto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Txt_NomeCat;
        private System.Windows.Forms.Button Btn_SalvarCat;
        private System.Windows.Forms.Button Btn_CancelarCat;
        private System.Windows.Forms.TabPage tabPageAddProd;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Txt_NomeProd;
        private System.Windows.Forms.ComboBox Cbx_CategoriaProd;
        private System.Windows.Forms.NumericUpDown Nud_Estoque;
        private System.Windows.Forms.NumericUpDown Nud_Preco;
        private System.Windows.Forms.Button Btn_SalvarProd;
        private System.Windows.Forms.Button btn_CancelarProd;
        private System.Windows.Forms.Button Btn_DeletarCat;
        private System.Windows.Forms.Button Btn_EditarCat;
        private System.Windows.Forms.Button Btn_AdicionarCat;
        private System.Windows.Forms.ImageList imageList;
    }
}