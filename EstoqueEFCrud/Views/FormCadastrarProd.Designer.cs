namespace EstoqueEFCrud.Views
{
    partial class Produto
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.LblProd = new System.Windows.Forms.Label();
            this.LbProdId = new System.Windows.Forms.Label();
            this.TxPreco = new System.Windows.Forms.TextBox();
            this.NudEstoque = new System.Windows.Forms.NumericUpDown();
            this.CboxProd = new System.Windows.Forms.ComboBox();
            this.TxNomeProd = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.BtnSalvarProd = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudEstoque)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Controls.Add(this.LblProd);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(434, 68);
            this.panel1.TabIndex = 1;
            // 
            // LblProd
            // 
            this.LblProd.AutoSize = true;
            this.LblProd.Font = new System.Drawing.Font("Inter", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblProd.ForeColor = System.Drawing.Color.White;
            this.LblProd.Location = new System.Drawing.Point(25, 23);
            this.LblProd.Name = "LblProd";
            this.LblProd.Size = new System.Drawing.Size(179, 23);
            this.LblProd.TabIndex = 0;
            this.LblProd.Text = "Adicionar Produto";
            // 
            // LbProdId
            // 
            this.LbProdId.AutoSize = true;
            this.LbProdId.Location = new System.Drawing.Point(12, 72);
            this.LbProdId.Name = "LbProdId";
            this.LbProdId.Size = new System.Drawing.Size(0, 13);
            this.LbProdId.TabIndex = 22;
            // 
            // TxPreco
            // 
            this.TxPreco.Location = new System.Drawing.Point(264, 185);
            this.TxPreco.MaxLength = 99999;
            this.TxPreco.Name = "TxPreco";
            this.TxPreco.Size = new System.Drawing.Size(60, 20);
            this.TxPreco.TabIndex = 21;
            // 
            // NudEstoque
            // 
            this.NudEstoque.Location = new System.Drawing.Point(264, 123);
            this.NudEstoque.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.NudEstoque.Name = "NudEstoque";
            this.NudEstoque.Size = new System.Drawing.Size(60, 20);
            this.NudEstoque.TabIndex = 15;
            // 
            // CboxProd
            // 
            this.CboxProd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboxProd.FormattingEnabled = true;
            this.CboxProd.Location = new System.Drawing.Point(16, 184);
            this.CboxProd.Name = "CboxProd";
            this.CboxProd.Size = new System.Drawing.Size(212, 21);
            this.CboxProd.TabIndex = 16;
            // 
            // TxNomeProd
            // 
            this.TxNomeProd.Location = new System.Drawing.Point(16, 122);
            this.TxNomeProd.Name = "TxNomeProd";
            this.TxNomeProd.Size = new System.Drawing.Size(212, 20);
            this.TxNomeProd.TabIndex = 14;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(12, 161);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(163, 20);
            this.label11.TabIndex = 20;
            this.label11.Text = "Categoria do produto:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(260, 161);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(135, 20);
            this.label10.TabIndex = 19;
            this.label10.Text = "Preço do produto:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(260, 100);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(160, 20);
            this.label9.TabIndex = 18;
            this.label9.Text = "Quantidade Estoque:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 20);
            this.label8.TabIndex = 17;
            this.label8.Text = "Nome do produto:";
            // 
            // BtnSalvarProd
            // 
            this.BtnSalvarProd.BackColor = System.Drawing.Color.ForestGreen;
            this.BtnSalvarProd.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnSalvarProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalvarProd.Font = new System.Drawing.Font("Inter", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalvarProd.ForeColor = System.Drawing.Color.White;
            this.BtnSalvarProd.Location = new System.Drawing.Point(339, 313);
            this.BtnSalvarProd.Name = "BtnSalvarProd";
            this.BtnSalvarProd.Size = new System.Drawing.Size(81, 36);
            this.BtnSalvarProd.TabIndex = 23;
            this.BtnSalvarProd.Text = "Salvar";
            this.BtnSalvarProd.UseVisualStyleBackColor = false;
            // 
            // Produto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 361);
            this.Controls.Add(this.BtnSalvarProd);
            this.Controls.Add(this.LbProdId);
            this.Controls.Add(this.TxPreco);
            this.Controls.Add(this.NudEstoque);
            this.Controls.Add(this.CboxProd);
            this.Controls.Add(this.TxNomeProd);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Produto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCadastrarProd";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudEstoque)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LblProd;
        private System.Windows.Forms.Label LbProdId;
        private System.Windows.Forms.TextBox TxPreco;
        private System.Windows.Forms.NumericUpDown NudEstoque;
        private System.Windows.Forms.ComboBox CboxProd;
        private System.Windows.Forms.TextBox TxNomeProd;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button BtnSalvarProd;
    }
}