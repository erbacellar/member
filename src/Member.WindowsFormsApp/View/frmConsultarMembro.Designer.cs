namespace CashInBox
{
    partial class frmConsultarMembro
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
            this.label18 = new System.Windows.Forms.Label();
            this.txtConsultar = new System.Windows.Forms.TextBox();
            this.grdConsulta = new System.Windows.Forms.DataGridView();
            this.btnPesquisar = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.grpTrabalhosVoluntarios = new System.Windows.Forms.GroupBox();
            this.rdbAmbosVol = new System.Windows.Forms.RadioButton();
            this.rdbTrabalhoVoluntarioS = new System.Windows.Forms.RadioButton();
            this.rdbTrabalhoVoluntarioN = new System.Windows.Forms.RadioButton();
            this.cboGrupoHorario = new System.Windows.Forms.ComboBox();
            this.cboGrupoDia = new System.Windows.Forms.ComboBox();
            this.lblGrupo = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.grpBiblioteca = new System.Windows.Forms.GroupBox();
            this.rdbAmbosBib = new System.Windows.Forms.RadioButton();
            this.rdbSimB = new System.Windows.Forms.RadioButton();
            this.rdbNaoB = new System.Windows.Forms.RadioButton();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.lblCidade = new System.Windows.Forms.Label();
            this.lblBairro = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdConsulta)).BeginInit();
            this.grpTrabalhosVoluntarios.SuspendLayout();
            this.grpBiblioteca.SuspendLayout();
            this.SuspendLayout();
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(80, 27);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(44, 17);
            this.label18.TabIndex = 93;
            this.label18.Text = "Nome";
            // 
            // txtConsultar
            // 
            this.txtConsultar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConsultar.Location = new System.Drawing.Point(81, 45);
            this.txtConsultar.Name = "txtConsultar";
            this.txtConsultar.Size = new System.Drawing.Size(234, 22);
            this.txtConsultar.TabIndex = 94;
            this.txtConsultar.TabStop = false;
            this.txtConsultar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtConsultar_KeyPress);
            // 
            // grdConsulta
            // 
            this.grdConsulta.AllowUserToAddRows = false;
            this.grdConsulta.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(125)))), ((int)(((byte)(129)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.grdConsulta.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grdConsulta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.grdConsulta.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdConsulta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grdConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdConsulta.DefaultCellStyle = dataGridViewCellStyle3;
            this.grdConsulta.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.grdConsulta.Location = new System.Drawing.Point(29, 186);
            this.grdConsulta.Name = "grdConsulta";
            this.grdConsulta.ReadOnly = true;
            this.grdConsulta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdConsulta.Size = new System.Drawing.Size(745, 226);
            this.grdConsulta.TabIndex = 97;
            this.grdConsulta.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdConsulta_CellDoubleClick);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(716, 43);
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
            this.btnPesquisar.Size = new System.Drawing.Size(74, 41);
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
            this.btnPesquisar.TabIndex = 195;
            this.btnPesquisar.Values.Text = "Consultar";
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // grpTrabalhosVoluntarios
            // 
            this.grpTrabalhosVoluntarios.Controls.Add(this.rdbAmbosVol);
            this.grpTrabalhosVoluntarios.Controls.Add(this.rdbTrabalhoVoluntarioS);
            this.grpTrabalhosVoluntarios.Controls.Add(this.rdbTrabalhoVoluntarioN);
            this.grpTrabalhosVoluntarios.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpTrabalhosVoluntarios.Location = new System.Drawing.Point(513, 76);
            this.grpTrabalhosVoluntarios.Name = "grpTrabalhosVoluntarios";
            this.grpTrabalhosVoluntarios.Size = new System.Drawing.Size(181, 47);
            this.grpTrabalhosVoluntarios.TabIndex = 231;
            this.grpTrabalhosVoluntarios.TabStop = false;
            this.grpTrabalhosVoluntarios.Text = "Voluntário";
            // 
            // rdbAmbosVol
            // 
            this.rdbAmbosVol.AutoSize = true;
            this.rdbAmbosVol.Checked = true;
            this.rdbAmbosVol.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbAmbosVol.Location = new System.Drawing.Point(112, 20);
            this.rdbAmbosVol.Name = "rdbAmbosVol";
            this.rdbAmbosVol.Size = new System.Drawing.Size(62, 20);
            this.rdbAmbosVol.TabIndex = 207;
            this.rdbAmbosVol.TabStop = true;
            this.rdbAmbosVol.Text = "Ambos";
            this.rdbAmbosVol.UseVisualStyleBackColor = true;
            // 
            // rdbTrabalhoVoluntarioS
            // 
            this.rdbTrabalhoVoluntarioS.AutoSize = true;
            this.rdbTrabalhoVoluntarioS.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbTrabalhoVoluntarioS.Location = new System.Drawing.Point(6, 20);
            this.rdbTrabalhoVoluntarioS.Name = "rdbTrabalhoVoluntarioS";
            this.rdbTrabalhoVoluntarioS.Size = new System.Drawing.Size(44, 20);
            this.rdbTrabalhoVoluntarioS.TabIndex = 205;
            this.rdbTrabalhoVoluntarioS.Text = "Sim";
            this.rdbTrabalhoVoluntarioS.UseVisualStyleBackColor = true;
            // 
            // rdbTrabalhoVoluntarioN
            // 
            this.rdbTrabalhoVoluntarioN.AutoSize = true;
            this.rdbTrabalhoVoluntarioN.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbTrabalhoVoluntarioN.Location = new System.Drawing.Point(61, 20);
            this.rdbTrabalhoVoluntarioN.Name = "rdbTrabalhoVoluntarioN";
            this.rdbTrabalhoVoluntarioN.Size = new System.Drawing.Size(49, 20);
            this.rdbTrabalhoVoluntarioN.TabIndex = 206;
            this.rdbTrabalhoVoluntarioN.Text = "Não";
            this.rdbTrabalhoVoluntarioN.UseVisualStyleBackColor = true;
            // 
            // cboGrupoHorario
            // 
            this.cboGrupoHorario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cboGrupoHorario.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboGrupoHorario.FormattingEnabled = true;
            this.cboGrupoHorario.Location = new System.Drawing.Point(436, 43);
            this.cboGrupoHorario.Name = "cboGrupoHorario";
            this.cboGrupoHorario.Size = new System.Drawing.Size(79, 24);
            this.cboGrupoHorario.TabIndex = 234;
            // 
            // cboGrupoDia
            // 
            this.cboGrupoDia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cboGrupoDia.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboGrupoDia.FormattingEnabled = true;
            this.cboGrupoDia.Location = new System.Drawing.Point(321, 43);
            this.cboGrupoDia.Name = "cboGrupoDia";
            this.cboGrupoDia.Size = new System.Drawing.Size(109, 24);
            this.cboGrupoDia.TabIndex = 233;
            // 
            // lblGrupo
            // 
            this.lblGrupo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblGrupo.AutoSize = true;
            this.lblGrupo.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrupo.Location = new System.Drawing.Point(318, 24);
            this.lblGrupo.Name = "lblGrupo";
            this.lblGrupo.Size = new System.Drawing.Size(43, 16);
            this.lblGrupo.TabIndex = 232;
            this.lblGrupo.Text = "Grupo";
            // 
            // lblNumero
            // 
            this.lblNumero.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblNumero.AutoSize = true;
            this.lblNumero.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumero.Location = new System.Drawing.Point(80, 72);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(50, 16);
            this.lblNumero.TabIndex = 236;
            this.lblNumero.Text = "Numero";
            // 
            // txtNum
            // 
            this.txtNum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtNum.BackColor = System.Drawing.SystemColors.Window;
            this.txtNum.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNum.Location = new System.Drawing.Point(81, 92);
            this.txtNum.MaxLength = 50;
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(101, 21);
            this.txtNum.TabIndex = 235;
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtEmail.BackColor = System.Drawing.SystemColors.Window;
            this.txtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEmail.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(196, 92);
            this.txtEmail.MaxLength = 100;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(300, 21);
            this.txtEmail.TabIndex = 237;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(193, 72);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 16);
            this.label9.TabIndex = 238;
            this.label9.Text = "E-Mail";
            // 
            // grpBiblioteca
            // 
            this.grpBiblioteca.Controls.Add(this.rdbAmbosBib);
            this.grpBiblioteca.Controls.Add(this.rdbSimB);
            this.grpBiblioteca.Controls.Add(this.rdbNaoB);
            this.grpBiblioteca.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBiblioteca.Location = new System.Drawing.Point(513, 123);
            this.grpBiblioteca.Name = "grpBiblioteca";
            this.grpBiblioteca.Size = new System.Drawing.Size(181, 47);
            this.grpBiblioteca.TabIndex = 232;
            this.grpBiblioteca.TabStop = false;
            this.grpBiblioteca.Text = "Biblioteca";
            // 
            // rdbAmbosBib
            // 
            this.rdbAmbosBib.AutoSize = true;
            this.rdbAmbosBib.Checked = true;
            this.rdbAmbosBib.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbAmbosBib.Location = new System.Drawing.Point(112, 20);
            this.rdbAmbosBib.Name = "rdbAmbosBib";
            this.rdbAmbosBib.Size = new System.Drawing.Size(62, 20);
            this.rdbAmbosBib.TabIndex = 208;
            this.rdbAmbosBib.TabStop = true;
            this.rdbAmbosBib.Text = "Ambos";
            this.rdbAmbosBib.UseVisualStyleBackColor = true;
            // 
            // rdbSimB
            // 
            this.rdbSimB.AutoSize = true;
            this.rdbSimB.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbSimB.Location = new System.Drawing.Point(6, 20);
            this.rdbSimB.Name = "rdbSimB";
            this.rdbSimB.Size = new System.Drawing.Size(44, 20);
            this.rdbSimB.TabIndex = 205;
            this.rdbSimB.Text = "Sim";
            this.rdbSimB.UseVisualStyleBackColor = true;
            // 
            // rdbNaoB
            // 
            this.rdbNaoB.AutoSize = true;
            this.rdbNaoB.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbNaoB.Location = new System.Drawing.Point(61, 20);
            this.rdbNaoB.Name = "rdbNaoB";
            this.rdbNaoB.Size = new System.Drawing.Size(49, 20);
            this.rdbNaoB.TabIndex = 206;
            this.rdbNaoB.Text = "Não";
            this.rdbNaoB.UseVisualStyleBackColor = true;
            // 
            // txtCidade
            // 
            this.txtCidade.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtCidade.BackColor = System.Drawing.SystemColors.Window;
            this.txtCidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCidade.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCidade.Location = new System.Drawing.Point(196, 143);
            this.txtCidade.MaxLength = 100;
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(300, 21);
            this.txtCidade.TabIndex = 241;
            // 
            // lblCidade
            // 
            this.lblCidade.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCidade.AutoSize = true;
            this.lblCidade.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCidade.Location = new System.Drawing.Point(193, 123);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(50, 16);
            this.lblCidade.TabIndex = 242;
            this.lblCidade.Text = "Cidade";
            // 
            // lblBairro
            // 
            this.lblBairro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblBairro.AutoSize = true;
            this.lblBairro.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBairro.Location = new System.Drawing.Point(80, 123);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(37, 16);
            this.lblBairro.TabIndex = 240;
            this.lblBairro.Text = "Bairro";
            // 
            // txtBairro
            // 
            this.txtBairro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtBairro.BackColor = System.Drawing.SystemColors.Window;
            this.txtBairro.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBairro.Location = new System.Drawing.Point(81, 143);
            this.txtBairro.MaxLength = 50;
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(101, 21);
            this.txtBairro.TabIndex = 239;
            // 
            // cboStatus
            // 
            this.cboStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cboStatus.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Location = new System.Drawing.Point(521, 43);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(109, 24);
            this.cboStatus.TabIndex = 244;
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(518, 24);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(41, 16);
            this.lblStatus.TabIndex = 243;
            this.lblStatus.Text = "Status";
            // 
            // frmConsultarMembro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(802, 424);
            this.Controls.Add(this.cboStatus);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.lblCidade);
            this.Controls.Add(this.lblBairro);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(this.grpBiblioteca);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.cboGrupoHorario);
            this.Controls.Add(this.cboGrupoDia);
            this.Controls.Add(this.lblGrupo);
            this.Controls.Add(this.grpTrabalhosVoluntarios);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.grdConsulta);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.txtConsultar);
            this.Name = "frmConsultarMembro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar Membro";
            this.Load += new System.EventHandler(this.frmConsultarMembro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdConsulta)).EndInit();
            this.grpTrabalhosVoluntarios.ResumeLayout(false);
            this.grpTrabalhosVoluntarios.PerformLayout();
            this.grpBiblioteca.ResumeLayout(false);
            this.grpBiblioteca.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtConsultar;
        private System.Windows.Forms.DataGridView grdConsulta;
        public ComponentFactory.Krypton.Toolkit.KryptonButton btnPesquisar;
        private System.Windows.Forms.GroupBox grpTrabalhosVoluntarios;
        public System.Windows.Forms.RadioButton rdbTrabalhoVoluntarioS;
        public System.Windows.Forms.RadioButton rdbTrabalhoVoluntarioN;
        public System.Windows.Forms.ComboBox cboGrupoHorario;
        public System.Windows.Forms.ComboBox cboGrupoDia;
        private System.Windows.Forms.Label lblGrupo;
        private System.Windows.Forms.Label lblNumero;
        public System.Windows.Forms.TextBox txtNum;
        public System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox grpBiblioteca;
        public System.Windows.Forms.RadioButton rdbSimB;
        public System.Windows.Forms.RadioButton rdbNaoB;
        public System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.Label lblBairro;
        public System.Windows.Forms.TextBox txtBairro;
        public System.Windows.Forms.RadioButton rdbAmbosVol;
        public System.Windows.Forms.RadioButton rdbAmbosBib;
        public System.Windows.Forms.ComboBox cboStatus;
        private System.Windows.Forms.Label lblStatus;
    }
}