namespace CashInBox
{
    partial class frmRelatorioAniversariantes
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
            this.AniversariantesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsAniversariantes = new CashInBox.DataSets.dsAniversariantes();
            this.rptRelAniversariantes = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panMenu = new System.Windows.Forms.Panel();
            this.cboMes = new System.Windows.Forms.ComboBox();
            this.lblGrupo = new System.Windows.Forms.Label();
            this.btnPesquisar = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.AniversariantesTableAdapter = new CashInBox.DataSets.dsAniversariantesTableAdapters.AniversariantesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.AniversariantesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAniversariantes)).BeginInit();
            this.panMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // AniversariantesBindingSource
            // 
            this.AniversariantesBindingSource.DataMember = "Aniversariantes";
            this.AniversariantesBindingSource.DataSource = this.dsAniversariantes;
            // 
            // dsAniversariantes
            // 
            this.dsAniversariantes.DataSetName = "dsAniversariantes";
            this.dsAniversariantes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rptRelAniversariantes
            // 
            this.rptRelAniversariantes.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "dsAniversariantes";
            reportDataSource1.Value = this.AniversariantesBindingSource;
            this.rptRelAniversariantes.LocalReport.DataSources.Add(reportDataSource1);
            this.rptRelAniversariantes.LocalReport.ReportEmbeddedResource = "CashInBox.Reports.rptAniversariantes.rdlc";
            this.rptRelAniversariantes.Location = new System.Drawing.Point(0, 70);
            this.rptRelAniversariantes.Name = "rptRelAniversariantes";
            this.rptRelAniversariantes.Size = new System.Drawing.Size(799, 421);
            this.rptRelAniversariantes.TabIndex = 165;
            // 
            // panMenu
            // 
            this.panMenu.BackColor = System.Drawing.SystemColors.Control;
            this.panMenu.Controls.Add(this.cboMes);
            this.panMenu.Controls.Add(this.lblGrupo);
            this.panMenu.Controls.Add(this.btnPesquisar);
            this.panMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panMenu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panMenu.Location = new System.Drawing.Point(0, 0);
            this.panMenu.Name = "panMenu";
            this.panMenu.Size = new System.Drawing.Size(799, 70);
            this.panMenu.TabIndex = 166;
            // 
            // cboMes
            // 
            this.cboMes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cboMes.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMes.FormattingEnabled = true;
            this.cboMes.Location = new System.Drawing.Point(16, 28);
            this.cboMes.Name = "cboMes";
            this.cboMes.Size = new System.Drawing.Size(251, 24);
            this.cboMes.TabIndex = 228;
            // 
            // lblGrupo
            // 
            this.lblGrupo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblGrupo.AutoSize = true;
            this.lblGrupo.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrupo.Location = new System.Drawing.Point(12, 9);
            this.lblGrupo.Name = "lblGrupo";
            this.lblGrupo.Size = new System.Drawing.Size(30, 16);
            this.lblGrupo.TabIndex = 227;
            this.lblGrupo.Text = "Mês";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(286, 22);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(175)))), ((int)(((byte)(241)))));
            this.btnPesquisar.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(175)))), ((int)(((byte)(241)))));
            this.btnPesquisar.OverrideDefault.Back.Image = global::CashInBox.Properties.Resources.search_white_16x16;
            this.btnPesquisar.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnPesquisar.OverrideDefault.Border.Rounding = 5;
            this.btnPesquisar.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.Transparent;
            this.btnPesquisar.OverrideFocus.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.btnPesquisar.OverrideFocus.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.btnPesquisar.OverrideFocus.Back.Image = global::CashInBox.Properties.Resources.search_white_16x16;
            this.btnPesquisar.OverrideFocus.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnPesquisar.OverrideFocus.Border.Rounding = 5;
            this.btnPesquisar.OverrideFocus.Content.ShortText.Color1 = System.Drawing.Color.Transparent;
            this.btnPesquisar.OverrideFocus.Content.ShortText.Color2 = System.Drawing.Color.Transparent;
            this.btnPesquisar.OverrideFocus.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.Size = new System.Drawing.Size(87, 30);
            this.btnPesquisar.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(175)))), ((int)(((byte)(241)))));
            this.btnPesquisar.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(175)))), ((int)(((byte)(241)))));
            this.btnPesquisar.StateCommon.Back.Image = global::CashInBox.Properties.Resources.search_white_16x16;
            this.btnPesquisar.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            this.btnPesquisar.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnPesquisar.StateCommon.Border.Rounding = 5;
            this.btnPesquisar.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Transparent;
            this.btnPesquisar.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(194)))), ((int)(((byte)(199)))));
            this.btnPesquisar.StateDisabled.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(194)))), ((int)(((byte)(199)))));
            this.btnPesquisar.StateDisabled.Back.Image = global::CashInBox.Properties.Resources.search_grey_16x16;
            this.btnPesquisar.TabIndex = 196;
            this.btnPesquisar.Values.Text = "Consultar";
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // AniversariantesTableAdapter
            // 
            this.AniversariantesTableAdapter.ClearBeforeFill = true;
            // 
            // frmRelatorioAniversariantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 491);
            this.Controls.Add(this.rptRelAniversariantes);
            this.Controls.Add(this.panMenu);
            this.Name = "frmRelatorioAniversariantes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório de Aniversariantes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmRelatorioMembrosPorGrupo_FormClosing);
            this.Load += new System.EventHandler(this.frmRelatorioMembrosPorGrupo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AniversariantesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAniversariantes)).EndInit();
            this.panMenu.ResumeLayout(false);
            this.panMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptRelAniversariantes;
        private System.Windows.Forms.Panel panMenu;
        public ComponentFactory.Krypton.Toolkit.KryptonButton btnPesquisar;
        public System.Windows.Forms.ComboBox cboMes;
        private System.Windows.Forms.Label lblGrupo;
        private System.Windows.Forms.BindingSource AniversariantesBindingSource;
        private DataSets.dsAniversariantes dsAniversariantes;
        private DataSets.dsAniversariantesTableAdapters.AniversariantesTableAdapter AniversariantesTableAdapter;
    }
}