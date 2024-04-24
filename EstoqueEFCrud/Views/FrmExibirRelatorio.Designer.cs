namespace EstoqueEFCrud.Views
{
    partial class FrmExibirRelatorio
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
            this.crvReport = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvReport
            // 
            this.crvReport.ActiveViewIndex = 0;
            this.crvReport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvReport.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvReport.Location = new System.Drawing.Point(0, 0);
            this.crvReport.Name = "crvReport";
            this.crvReport.ReportSource = "D:\\Workspace\\.GitDesktop\\EstoqueEFCrud\\EstoqueEFCrud\\Relatorios\\RelatorioProdutos" +
    ".rpt";
            this.crvReport.Size = new System.Drawing.Size(846, 702);
            this.crvReport.TabIndex = 0;
            this.crvReport.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // FrmExibirRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 702);
            this.Controls.Add(this.crvReport);
            this.Name = "FrmExibirRelatorio";
            this.Text = "FrmExibirRelatorio";
            this.Load += new System.EventHandler(this.FrmExibirRelatorio_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvReport;
        private Relatorios.RelatorioProdutos RelatorioProdutos;
    }
}