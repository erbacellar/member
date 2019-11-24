namespace CashInBox
{
    partial class frmRelDoutrinario
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
            this.DoutrinarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsDoutrinario = new CashInBox.DataSets.dsDoutrinario();
            this.rptRelFinanceiro = new Microsoft.Reporting.WinForms.ReportViewer();
            this.pgbLoad = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.DoutrinarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDoutrinario)).BeginInit();
            this.SuspendLayout();
            // 
            // DoutrinarioBindingSource
            // 
            this.DoutrinarioBindingSource.DataMember = "Doutrinario";
            this.DoutrinarioBindingSource.DataSource = this.dsDoutrinario;
            // 
            // dsDoutrinario
            // 
            this.dsDoutrinario.DataSetName = "dsDoutrinario";
            this.dsDoutrinario.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rptRelFinanceiro
            // 
            this.rptRelFinanceiro.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "dsDoutrinario";
            reportDataSource1.Value = this.DoutrinarioBindingSource;
            this.rptRelFinanceiro.LocalReport.DataSources.Add(reportDataSource1);
            this.rptRelFinanceiro.LocalReport.ReportEmbeddedResource = "CashInBox.Reports.rptDoutrinario.rdlc";
            this.rptRelFinanceiro.Location = new System.Drawing.Point(0, 0);
            this.rptRelFinanceiro.Name = "rptRelFinanceiro";
            this.rptRelFinanceiro.Size = new System.Drawing.Size(284, 238);
            this.rptRelFinanceiro.TabIndex = 167;
            // 
            // pgbLoad
            // 
            this.pgbLoad.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pgbLoad.Location = new System.Drawing.Point(0, 238);
            this.pgbLoad.Name = "pgbLoad";
            this.pgbLoad.Size = new System.Drawing.Size(284, 23);
            this.pgbLoad.TabIndex = 168;
            // 
            // frmRelDoutrinario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.rptRelFinanceiro);
            this.Controls.Add(this.pgbLoad);
            this.Name = "frmRelDoutrinario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Relatório Doutrinário";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmRelDoutrinario_FormClosing);
            this.Load += new System.EventHandler(this.frmRelDoutrinario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DoutrinarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDoutrinario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptRelFinanceiro;
        private System.Windows.Forms.BindingSource DoutrinarioBindingSource;
        private DataSets.dsDoutrinario dsDoutrinario;
        private System.Windows.Forms.ProgressBar pgbLoad;
    }
}