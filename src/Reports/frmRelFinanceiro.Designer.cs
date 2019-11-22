namespace CashInBox
{
    partial class frmRelFinanceiro
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.RelatorioFinanceiroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsRelatorioFinanceiro = new CashInBox.DataSets.dsRelatorioFinanceiro();
            this.rptRelatorioFinanceiro = new Microsoft.Reporting.WinForms.ReportViewer();
            this.RelatorioFinanceiroTableAdapter = new CashInBox.DataSets.dsRelatorioFinanceiroTableAdapters.RelatorioFinanceiroTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.RelatorioFinanceiroBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRelatorioFinanceiro)).BeginInit();
            this.SuspendLayout();
            // 
            // RelatorioFinanceiroBindingSource
            // 
            this.RelatorioFinanceiroBindingSource.DataMember = "RelatorioFinanceiro";
            this.RelatorioFinanceiroBindingSource.DataSource = this.dsRelatorioFinanceiro;
            // 
            // dsRelatorioFinanceiro
            // 
            this.dsRelatorioFinanceiro.DataSetName = "dsRelatorioFinanceiro";
            this.dsRelatorioFinanceiro.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rptRelatorioFinanceiro
            // 
            this.rptRelatorioFinanceiro.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "dsFinanceiro";
            reportDataSource1.Value = this.RelatorioFinanceiroBindingSource;
            this.rptRelatorioFinanceiro.LocalReport.DataSources.Add(reportDataSource1);
            this.rptRelatorioFinanceiro.LocalReport.ReportEmbeddedResource = "CashInBox.Reports.relFinanceiro.rdlc";
            this.rptRelatorioFinanceiro.Location = new System.Drawing.Point(0, 0);
            this.rptRelatorioFinanceiro.Name = "rptRelatorioFinanceiro";
            this.rptRelatorioFinanceiro.Size = new System.Drawing.Size(573, 406);
            this.rptRelatorioFinanceiro.TabIndex = 0;
            // 
            // RelatorioFinanceiroTableAdapter
            // 
            this.RelatorioFinanceiroTableAdapter.ClearBeforeFill = true;
            // 
            // frmRelFinanceiro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 406);
            this.Controls.Add(this.rptRelatorioFinanceiro);
            this.Name = "frmRelFinanceiro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório para Financeiro";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmRelFinanceiro_FormClosing);
            this.Load += new System.EventHandler(this.frmRelFinanceiro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RelatorioFinanceiroBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRelatorioFinanceiro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptRelatorioFinanceiro;
        private System.Windows.Forms.BindingSource RelatorioFinanceiroBindingSource;
        private DataSets.dsRelatorioFinanceiro dsRelatorioFinanceiro;
        private DataSets.dsRelatorioFinanceiroTableAdapters.RelatorioFinanceiroTableAdapter RelatorioFinanceiroTableAdapter;









    }
}