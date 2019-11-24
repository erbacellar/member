namespace CashInBox
{
    partial class frmRelBiblioteca
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
            this.RelatorioBibliotecaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsRelatorioBiblioteca = new CashInBox.DataSets.dsRelatorioBiblioteca();
            this.rptRelatorioBiblioteca = new Microsoft.Reporting.WinForms.ReportViewer();
            this.RelatorioBibliotecaTableAdapter = new CashInBox.DataSets.dsRelatorioBibliotecaTableAdapters.RelatorioBibliotecaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.RelatorioBibliotecaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRelatorioBiblioteca)).BeginInit();
            this.SuspendLayout();
            // 
            // RelatorioBibliotecaBindingSource
            // 
            this.RelatorioBibliotecaBindingSource.DataMember = "RelatorioBiblioteca";
            this.RelatorioBibliotecaBindingSource.DataSource = this.dsRelatorioBiblioteca;
            // 
            // dsRelatorioBiblioteca
            // 
            this.dsRelatorioBiblioteca.DataSetName = "dsRelatorioBiblioteca";
            this.dsRelatorioBiblioteca.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rptRelatorioBiblioteca
            // 
            this.rptRelatorioBiblioteca.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "dsBiblioteca";
            reportDataSource1.Value = this.RelatorioBibliotecaBindingSource;
            this.rptRelatorioBiblioteca.LocalReport.DataSources.Add(reportDataSource1);
            this.rptRelatorioBiblioteca.LocalReport.ReportEmbeddedResource = "CashInBox.Reports.relBiblioteca.rdlc";
            this.rptRelatorioBiblioteca.Location = new System.Drawing.Point(0, 0);
            this.rptRelatorioBiblioteca.Name = "rptRelatorioBiblioteca";
            this.rptRelatorioBiblioteca.Size = new System.Drawing.Size(284, 261);
            this.rptRelatorioBiblioteca.TabIndex = 0;
            // 
            // RelatorioBibliotecaTableAdapter
            // 
            this.RelatorioBibliotecaTableAdapter.ClearBeforeFill = true;
            // 
            // frmRelBiblioteca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.rptRelatorioBiblioteca);
            this.Name = "frmRelBiblioteca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório para Biblioteca";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmRelBiblioteca_FormClosing);
            this.Load += new System.EventHandler(this.frmRelBiblioteca_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RelatorioBibliotecaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRelatorioBiblioteca)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptRelatorioBiblioteca;
        private System.Windows.Forms.BindingSource RelatorioBibliotecaBindingSource;
        private DataSets.dsRelatorioBiblioteca dsRelatorioBiblioteca;
        private DataSets.dsRelatorioBibliotecaTableAdapters.RelatorioBibliotecaTableAdapter RelatorioBibliotecaTableAdapter;


    }
}