namespace CashInBox
{
    partial class frmRelatorioFichaCadastroMembro
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
            this.MembroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsFichaCadMembro = new CashInBox.dsFichaCadMembro();
            this.rptFichaCadMembro = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panMenu = new System.Windows.Forms.Panel();
            this.btnAtualizar = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.lblId = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblCpf = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.mskCPF = new System.Windows.Forms.MaskedTextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnPesquisar = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.panCorpo = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.MembroBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFichaCadMembro)).BeginInit();
            this.panMenu.SuspendLayout();
            this.panCorpo.SuspendLayout();
            this.SuspendLayout();
            // 
            // MembroBindingSource
            // 
            this.MembroBindingSource.DataMember = "Membro";
            this.MembroBindingSource.DataSource = this.dsFichaCadMembro;
            // 
            // dsFichaCadMembro
            // 
            this.dsFichaCadMembro.DataSetName = "dsFichaCadMembro";
            this.dsFichaCadMembro.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rptFichaCadMembro
            // 
            this.rptFichaCadMembro.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "dsFichaCadMembro";
            reportDataSource1.Value = this.MembroBindingSource;
            this.rptFichaCadMembro.LocalReport.DataSources.Add(reportDataSource1);
            this.rptFichaCadMembro.LocalReport.ReportEmbeddedResource = "CashInBox.rptFichaCadMembro.rdlc";
            this.rptFichaCadMembro.Location = new System.Drawing.Point(0, 0);
            this.rptFichaCadMembro.Name = "rptFichaCadMembro";
            this.rptFichaCadMembro.Size = new System.Drawing.Size(711, 312);
            this.rptFichaCadMembro.TabIndex = 0;
            // 
            // panMenu
            // 
            this.panMenu.BackColor = System.Drawing.SystemColors.Control;
            this.panMenu.Controls.Add(this.btnAtualizar);
            this.panMenu.Controls.Add(this.lblId);
            this.panMenu.Controls.Add(this.txtId);
            this.panMenu.Controls.Add(this.lblCpf);
            this.panMenu.Controls.Add(this.lblNome);
            this.panMenu.Controls.Add(this.mskCPF);
            this.panMenu.Controls.Add(this.txtNome);
            this.panMenu.Controls.Add(this.btnPesquisar);
            this.panMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panMenu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panMenu.Location = new System.Drawing.Point(0, 0);
            this.panMenu.Name = "panMenu";
            this.panMenu.Size = new System.Drawing.Size(711, 70);
            this.panMenu.TabIndex = 164;
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(532, 23);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(175)))), ((int)(((byte)(241)))));
            this.btnAtualizar.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(175)))), ((int)(((byte)(241)))));
            this.btnAtualizar.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnAtualizar.OverrideDefault.Border.Rounding = 3;
            this.btnAtualizar.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnAtualizar.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnAtualizar.OverrideDefault.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizar.OverrideDefault.Content.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.btnAtualizar.OverrideDefault.Content.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.btnAtualizar.OverrideFocus.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.btnAtualizar.OverrideFocus.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.btnAtualizar.OverrideFocus.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnAtualizar.OverrideFocus.Border.Rounding = 3;
            this.btnAtualizar.OverrideFocus.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnAtualizar.OverrideFocus.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnAtualizar.OverrideFocus.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizar.Size = new System.Drawing.Size(80, 30);
            this.btnAtualizar.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(175)))), ((int)(((byte)(241)))));
            this.btnAtualizar.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(175)))), ((int)(((byte)(241)))));
            this.btnAtualizar.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnAtualizar.StateCommon.Border.Rounding = 3;
            this.btnAtualizar.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnAtualizar.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizar.StateCommon.Content.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.btnAtualizar.StateCommon.Content.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.btnAtualizar.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(194)))), ((int)(((byte)(199)))));
            this.btnAtualizar.StateDisabled.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(194)))), ((int)(((byte)(199)))));
            this.btnAtualizar.StateDisabled.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(127)))), ((int)(((byte)(130)))));
            this.btnAtualizar.StateDisabled.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(127)))), ((int)(((byte)(130)))));
            this.btnAtualizar.StateDisabled.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizar.StateDisabled.Content.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.btnAtualizar.StateDisabled.Content.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.btnAtualizar.TabIndex = 204;
            this.btnAtualizar.TabStop = false;
            this.btnAtualizar.Values.Text = "Atualizar";
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(618, 12);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(19, 17);
            this.lblId.TabIndex = 202;
            this.lblId.Text = "Id";
            this.lblId.Visible = false;
            // 
            // txtId
            // 
            this.txtId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtId.BackColor = System.Drawing.SystemColors.Window;
            this.txtId.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtId.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(621, 32);
            this.txtId.MaxLength = 200;
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(60, 21);
            this.txtId.TabIndex = 201;
            this.txtId.Visible = false;
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCpf.Location = new System.Drawing.Point(347, 12);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(30, 17);
            this.lblCpf.TabIndex = 200;
            this.lblCpf.Text = "CPF";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(9, 12);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(44, 17);
            this.lblNome.TabIndex = 199;
            this.lblNome.Text = "Nome";
            // 
            // mskCPF
            // 
            this.mskCPF.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.mskCPF.BackColor = System.Drawing.SystemColors.Window;
            this.mskCPF.Enabled = false;
            this.mskCPF.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskCPF.Location = new System.Drawing.Point(350, 32);
            this.mskCPF.Mask = "000\\.000\\.000\\-00";
            this.mskCPF.Name = "mskCPF";
            this.mskCPF.ReadOnly = true;
            this.mskCPF.Size = new System.Drawing.Size(120, 21);
            this.mskCPF.TabIndex = 198;
            this.mskCPF.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // txtNome
            // 
            this.txtNome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtNome.BackColor = System.Drawing.SystemColors.Window;
            this.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNome.Enabled = false;
            this.txtNome.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(12, 32);
            this.txtNome.MaxLength = 200;
            this.txtNome.Name = "txtNome";
            this.txtNome.ReadOnly = true;
            this.txtNome.Size = new System.Drawing.Size(319, 21);
            this.txtNome.TabIndex = 197;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(476, 23);
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
            this.btnPesquisar.Size = new System.Drawing.Size(50, 30);
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
            // panCorpo
            // 
            this.panCorpo.Controls.Add(this.rptFichaCadMembro);
            this.panCorpo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panCorpo.Location = new System.Drawing.Point(0, 70);
            this.panCorpo.Name = "panCorpo";
            this.panCorpo.Size = new System.Drawing.Size(711, 312);
            this.panCorpo.TabIndex = 165;
            // 
            // frmRelatorioFichaCadastroMembro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(711, 382);
            this.Controls.Add(this.panCorpo);
            this.Controls.Add(this.panMenu);
            this.Name = "frmRelatorioFichaCadastroMembro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ficha de Cadastro de Membro";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmRelatorioFichaCadastroMembro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MembroBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFichaCadMembro)).EndInit();
            this.panMenu.ResumeLayout(false);
            this.panMenu.PerformLayout();
            this.panCorpo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptFichaCadMembro;
        private System.Windows.Forms.Panel panMenu;
        public ComponentFactory.Krypton.Toolkit.KryptonButton btnPesquisar;
        public System.Windows.Forms.MaskedTextBox mskCPF;
        public System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Panel panCorpo;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblId;
        public System.Windows.Forms.TextBox txtId;
        public ComponentFactory.Krypton.Toolkit.KryptonButton btnAtualizar;
        private System.Windows.Forms.BindingSource MembroBindingSource;
        private dsFichaCadMembro dsFichaCadMembro;
    }
}