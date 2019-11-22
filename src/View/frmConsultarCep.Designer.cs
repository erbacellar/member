namespace CashInBox
{
    partial class frmConsultarCep
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grdConsultaCepSemFormatacao = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.mskCep = new System.Windows.Forms.MaskedTextBox();
            this.grdConsultaCepFormatado = new System.Windows.Forms.DataGridView();
            this.grdNumCep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdEnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdBairro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdCidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdUF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblQuantidadeResultado = new System.Windows.Forms.Label();
            this.lblResultadoTxt = new System.Windows.Forms.Label();
            this.lblQtdNumResult = new System.Windows.Forms.Label();
            this.btnPesquisar = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.grdConsultaCepSemFormatacao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdConsultaCepFormatado)).BeginInit();
            this.SuspendLayout();
            // 
            // grdConsultaCepSemFormatacao
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.grdConsultaCepSemFormatacao.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grdConsultaCepSemFormatacao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdConsultaCepSemFormatacao.Location = new System.Drawing.Point(8, 54);
            this.grdConsultaCepSemFormatacao.Name = "grdConsultaCepSemFormatacao";
            this.grdConsultaCepSemFormatacao.Size = new System.Drawing.Size(576, 244);
            this.grdConsultaCepSemFormatacao.TabIndex = 7;
            this.grdConsultaCepSemFormatacao.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Informe o Cep";
            // 
            // mskCep
            // 
            this.mskCep.BackColor = System.Drawing.SystemColors.Window;
            this.mskCep.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskCep.Location = new System.Drawing.Point(15, 27);
            this.mskCep.Mask = "00\\.000\\-000";
            this.mskCep.Name = "mskCep";
            this.mskCep.Size = new System.Drawing.Size(85, 21);
            this.mskCep.TabIndex = 8;
            this.mskCep.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mskCep.Click += new System.EventHandler(this.mskCep_Click);
            this.mskCep.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mskCep_KeyPress);
            // 
            // grdConsultaCepFormatado
            // 
            this.grdConsultaCepFormatado.AllowUserToAddRows = false;
            this.grdConsultaCepFormatado.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(125)))), ((int)(((byte)(129)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdConsultaCepFormatado.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.grdConsultaCepFormatado.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdConsultaCepFormatado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grdConsultaCepFormatado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdConsultaCepFormatado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.grdNumCep,
            this.grdEnd,
            this.grdBairro,
            this.grdCidade,
            this.grdUF});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdConsultaCepFormatado.DefaultCellStyle = dataGridViewCellStyle4;
            this.grdConsultaCepFormatado.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.grdConsultaCepFormatado.Location = new System.Drawing.Point(8, 70);
            this.grdConsultaCepFormatado.Name = "grdConsultaCepFormatado";
            this.grdConsultaCepFormatado.ReadOnly = true;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdConsultaCepFormatado.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.grdConsultaCepFormatado.Size = new System.Drawing.Size(576, 244);
            this.grdConsultaCepFormatado.TabIndex = 9;
            this.grdConsultaCepFormatado.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdConsultaCepFormatado_CellDoubleClick);
            // 
            // grdNumCep
            // 
            this.grdNumCep.HeaderText = "Cep";
            this.grdNumCep.Name = "grdNumCep";
            this.grdNumCep.ReadOnly = true;
            // 
            // grdEnd
            // 
            this.grdEnd.HeaderText = "Endereço";
            this.grdEnd.Name = "grdEnd";
            this.grdEnd.ReadOnly = true;
            this.grdEnd.Width = 250;
            // 
            // grdBairro
            // 
            this.grdBairro.HeaderText = "Bairro";
            this.grdBairro.Name = "grdBairro";
            this.grdBairro.ReadOnly = true;
            // 
            // grdCidade
            // 
            this.grdCidade.HeaderText = "Cidade";
            this.grdCidade.Name = "grdCidade";
            this.grdCidade.ReadOnly = true;
            // 
            // grdUF
            // 
            this.grdUF.HeaderText = "UF";
            this.grdUF.Name = "grdUF";
            this.grdUF.ReadOnly = true;
            // 
            // lblQuantidadeResultado
            // 
            this.lblQuantidadeResultado.AutoSize = true;
            this.lblQuantidadeResultado.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantidadeResultado.Location = new System.Drawing.Point(268, 9);
            this.lblQuantidadeResultado.Name = "lblQuantidadeResultado";
            this.lblQuantidadeResultado.Size = new System.Drawing.Size(159, 16);
            this.lblQuantidadeResultado.TabIndex = 10;
            this.lblQuantidadeResultado.Text = "Quantidade de Resultados:";
            // 
            // lblResultadoTxt
            // 
            this.lblResultadoTxt.AutoSize = true;
            this.lblResultadoTxt.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultadoTxt.Location = new System.Drawing.Point(268, 30);
            this.lblResultadoTxt.Name = "lblResultadoTxt";
            this.lblResultadoTxt.Size = new System.Drawing.Size(139, 16);
            this.lblResultadoTxt.TabIndex = 11;
            this.lblResultadoTxt.Text = "Descrição do Resultado:";
            // 
            // lblQtdNumResult
            // 
            this.lblQtdNumResult.AutoSize = true;
            this.lblQtdNumResult.Location = new System.Drawing.Point(410, 9);
            this.lblQtdNumResult.Name = "lblQtdNumResult";
            this.lblQtdNumResult.Size = new System.Drawing.Size(0, 13);
            this.lblQtdNumResult.TabIndex = 12;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(106, 27);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(73)))), ((int)(((byte)(79)))));
            this.btnPesquisar.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(73)))), ((int)(((byte)(79)))));
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
            this.btnPesquisar.OverrideFocus.Content.ShortText.Font = new System.Drawing.Font("Hasteristico", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.Size = new System.Drawing.Size(45, 22);
            this.btnPesquisar.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(73)))), ((int)(((byte)(79)))));
            this.btnPesquisar.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(73)))), ((int)(((byte)(79)))));
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
            this.btnPesquisar.TabIndex = 95;
            this.btnPesquisar.Values.Text = "Consultar";
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            this.btnPesquisar.MouseEnter += new System.EventHandler(this.btnPesquisar_MouseEnter);
            // 
            // frmConsultarCep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(596, 343);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.lblQtdNumResult);
            this.Controls.Add(this.lblResultadoTxt);
            this.Controls.Add(this.lblQuantidadeResultado);
            this.Controls.Add(this.grdConsultaCepFormatado);
            this.Controls.Add(this.mskCep);
            this.Controls.Add(this.grdConsultaCepSemFormatacao);
            this.Controls.Add(this.label1);
            this.Name = "frmConsultarCep";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar Cep";
            this.Load += new System.EventHandler(this.frmConsultarCep_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdConsultaCepSemFormatacao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdConsultaCepFormatado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdConsultaCepSemFormatacao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mskCep;
        private System.Windows.Forms.DataGridView grdConsultaCepFormatado;
        private System.Windows.Forms.Label lblQuantidadeResultado;
        private System.Windows.Forms.Label lblResultadoTxt;
        private System.Windows.Forms.Label lblQtdNumResult;
        private System.Windows.Forms.DataGridViewTextBoxColumn grdNumCep;
        private System.Windows.Forms.DataGridViewTextBoxColumn grdEnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn grdBairro;
        private System.Windows.Forms.DataGridViewTextBoxColumn grdCidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn grdUF;
        public ComponentFactory.Krypton.Toolkit.KryptonButton btnPesquisar;
    }
}