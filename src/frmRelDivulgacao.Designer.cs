namespace CashInBox
{
    partial class frmRelDivulgacao
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
            this.rptRelatorioDivulgacao = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dsRelatorioDivulgacao = new CashInBox.dsRelatorioDivulgacao();
            this.RelatorioDivulgacaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.RelatorioDivulgacaoTableAdapter = new CashInBox.dsRelatorioDivulgacaoTableAdapters.RelatorioDivulgacaoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dsRelatorioDivulgacao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RelatorioDivulgacaoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rptRelatorioDivulgacao
            // 
            this.rptRelatorioDivulgacao.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "dsDivulgacao";
            reportDataSource1.Value = this.RelatorioDivulgacaoBindingSource;
            this.rptRelatorioDivulgacao.LocalReport.DataSources.Add(reportDataSource1);
            this.rptRelatorioDivulgacao.LocalReport.ReportEmbeddedResource = "CashInBox.relDivulgacao.rdlc";
            this.rptRelatorioDivulgacao.Location = new System.Drawing.Point(0, 0);
            this.rptRelatorioDivulgacao.Name = "rptRelatorioDivulgacao";
            this.rptRelatorioDivulgacao.Size = new System.Drawing.Size(638, 374);
            this.rptRelatorioDivulgacao.TabIndex = 0;
            // 
            // dsRelatorioDivulgacao
            // 
            this.dsRelatorioDivulgacao.DataSetName = "dsRelatorioDivulgacao";
            this.dsRelatorioDivulgacao.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // RelatorioDivulgacaoBindingSource
            // 
            this.RelatorioDivulgacaoBindingSource.DataMember = "RelatorioDivulgacao";
            this.RelatorioDivulgacaoBindingSource.DataSource = this.dsRelatorioDivulgacao;
            // 
            // RelatorioDivulgacaoTableAdapter
            // 
            this.RelatorioDivulgacaoTableAdapter.ClearBeforeFill = true;
            // 
            // frmRelDivulgacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 374);
            this.Controls.Add(this.rptRelatorioDivulgacao);
            this.Name = "frmRelDivulgacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório para Divulgação";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmRelDivulgacao_FormClosing);
            this.Load += new System.EventHandler(this.frmRelDivulgacao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsRelatorioDivulgacao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RelatorioDivulgacaoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptRelatorioDivulgacao;
        private System.Windows.Forms.BindingSource RelatorioDivulgacaoBindingSource;
        private dsRelatorioDivulgacao dsRelatorioDivulgacao;
        private dsRelatorioDivulgacaoTableAdapters.RelatorioDivulgacaoTableAdapter RelatorioDivulgacaoTableAdapter;

    }
}