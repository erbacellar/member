namespace CashInBox
{
    partial class frmRelatorioVoluntarios
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
            this.VoluntariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsVoluntarios = new CashInBox.dsVoluntarios();
            this.rptRelVoluntarios = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.VoluntariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsVoluntarios)).BeginInit();
            this.SuspendLayout();
            // 
            // VoluntariosBindingSource
            // 
            this.VoluntariosBindingSource.DataMember = "Voluntarios";
            this.VoluntariosBindingSource.DataSource = this.dsVoluntarios;
            // 
            // dsVoluntarios
            // 
            this.dsVoluntarios.DataSetName = "dsVoluntarios";
            this.dsVoluntarios.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rptRelVoluntarios
            // 
            this.rptRelVoluntarios.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "dsVoluntarios";
            reportDataSource1.Value = this.VoluntariosBindingSource;
            this.rptRelVoluntarios.LocalReport.DataSources.Add(reportDataSource1);
            this.rptRelVoluntarios.LocalReport.ReportEmbeddedResource = "CashInBox.relVoluntarios.rdlc";
            this.rptRelVoluntarios.Location = new System.Drawing.Point(0, 0);
            this.rptRelVoluntarios.Name = "rptRelVoluntarios";
            this.rptRelVoluntarios.Size = new System.Drawing.Size(554, 440);
            this.rptRelVoluntarios.TabIndex = 166;
            // 
            // frmRelatorioVoluntarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 440);
            this.Controls.Add(this.rptRelVoluntarios);
            this.Name = "frmRelatorioVoluntarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório de Voluntários";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmRelatorioVoluntarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.VoluntariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsVoluntarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptRelVoluntarios;
        private System.Windows.Forms.BindingSource VoluntariosBindingSource;
        private dsVoluntarios dsVoluntarios;
    }
}