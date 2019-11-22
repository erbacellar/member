namespace CashInBox
{
    partial class frmRelatorioFinanceiro2Isentos
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.rptRelatorioFinanceiro = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dsRelatorioFinanceiro = new CashInBox.dsRelatorioFinanceiro();
            this.RelatorioFinanceiroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.RelatorioFinanceiroTableAdapter = new CashInBox.dsRelatorioFinanceiroTableAdapters.RelatorioFinanceiroTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dsRelatorioFinanceiro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RelatorioFinanceiroBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rptRelatorioFinanceiro
            // 
            this.rptRelatorioFinanceiro.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "dsRelatorioFinanceiro2Isentos";
            reportDataSource2.Value = this.RelatorioFinanceiroBindingSource;
            this.rptRelatorioFinanceiro.LocalReport.DataSources.Add(reportDataSource2);
            this.rptRelatorioFinanceiro.LocalReport.ReportEmbeddedResource = "CashInBox.rptRelatorioFinanceiro2Isentos.rdlc";
            this.rptRelatorioFinanceiro.Location = new System.Drawing.Point(0, 0);
            this.rptRelatorioFinanceiro.Name = "rptRelatorioFinanceiro";
            this.rptRelatorioFinanceiro.Size = new System.Drawing.Size(284, 261);
            this.rptRelatorioFinanceiro.TabIndex = 0;
            // 
            // dsRelatorioFinanceiro
            // 
            this.dsRelatorioFinanceiro.DataSetName = "dsRelatorioFinanceiro";
            this.dsRelatorioFinanceiro.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // RelatorioFinanceiroBindingSource
            // 
            this.RelatorioFinanceiroBindingSource.DataMember = "RelatorioFinanceiro";
            this.RelatorioFinanceiroBindingSource.DataSource = this.dsRelatorioFinanceiro;
            // 
            // RelatorioFinanceiroTableAdapter
            // 
            this.RelatorioFinanceiroTableAdapter.ClearBeforeFill = true;
            // 
            // frmRelatorioFinanceiro2Isentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.rptRelatorioFinanceiro);
            this.Name = "frmRelatorioFinanceiro2Isentos";
            this.Text = "Relatório Financeiro 2 - Isentos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmRelatorioFinanceiro2Isentos_FormClosing);
            this.Load += new System.EventHandler(this.frmRelatorioFinanceiro2Isentos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsRelatorioFinanceiro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RelatorioFinanceiroBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptRelatorioFinanceiro;
        private System.Windows.Forms.BindingSource RelatorioFinanceiroBindingSource;
        private dsRelatorioFinanceiro dsRelatorioFinanceiro;
        private dsRelatorioFinanceiroTableAdapters.RelatorioFinanceiroTableAdapter RelatorioFinanceiroTableAdapter;
    }
}