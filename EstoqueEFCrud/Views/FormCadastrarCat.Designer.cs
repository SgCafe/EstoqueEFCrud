namespace EstoqueEFCrud.Views
{
    partial class FormCadastrarCat
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
            this.LblCat = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxNomeCat = new System.Windows.Forms.TextBox();
            this.BtnSalvarCat = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Controls.Add(this.LblCat);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(579, 84);
            this.panel1.TabIndex = 0;
            // 
            // LblCat
            // 
            this.LblCat.AutoSize = true;
            this.LblCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCat.ForeColor = System.Drawing.Color.White;
            this.LblCat.Location = new System.Drawing.Point(33, 28);
            this.LblCat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblCat.Name = "LblCat";
            this.LblCat.Size = new System.Drawing.Size(244, 29);
            this.LblCat.TabIndex = 0;
            this.LblCat.Text = "Adicionar Categoria";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 123);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome da categoria:";
            // 
            // TxNomeCat
            // 
            this.TxNomeCat.Location = new System.Drawing.Point(39, 160);
            this.TxNomeCat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxNomeCat.Name = "TxNomeCat";
            this.TxNomeCat.Size = new System.Drawing.Size(281, 22);
            this.TxNomeCat.TabIndex = 2;
            // 
            // BtnSalvarCat
            // 
            this.BtnSalvarCat.BackColor = System.Drawing.Color.ForestGreen;
            this.BtnSalvarCat.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnSalvarCat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalvarCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalvarCat.ForeColor = System.Drawing.Color.White;
            this.BtnSalvarCat.Location = new System.Drawing.Point(420, 246);
            this.BtnSalvarCat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnSalvarCat.Name = "BtnSalvarCat";
            this.BtnSalvarCat.Size = new System.Drawing.Size(108, 44);
            this.BtnSalvarCat.TabIndex = 3;
            this.BtnSalvarCat.Text = "Salvar";
            this.BtnSalvarCat.UseVisualStyleBackColor = false;
            // 
            // FormCadastrarCat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 321);
            this.Controls.Add(this.BtnSalvarCat);
            this.Controls.Add(this.TxNomeCat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCadastrarCat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Categoria";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnSalvarCat;
        public System.Windows.Forms.Label LblCat;
        public System.Windows.Forms.TextBox TxNomeCat;
    }
}