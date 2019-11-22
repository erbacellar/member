namespace CashInBox
{
    partial class frmUsuario
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
            this.lblPerfil = new System.Windows.Forms.Label();
            this.cboPerfil = new System.Windows.Forms.ComboBox();
            this.lblFuncionario = new System.Windows.Forms.Label();
            this.cboFuncionario = new System.Windows.Forms.ComboBox();
            this.lblLogin = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.lblConfirmarSenha = new System.Windows.Forms.Label();
            this.txtConfirmarSenha = new System.Windows.Forms.TextBox();
            this.lblForcaSenha = new System.Windows.Forms.Label();
            this.txtForca5 = new System.Windows.Forms.TextBox();
            this.txtForca4 = new System.Windows.Forms.TextBox();
            this.txtForca3 = new System.Windows.Forms.TextBox();
            this.txtForca2 = new System.Windows.Forms.TextBox();
            this.txtForca1 = new System.Windows.Forms.TextBox();
            this.Codigo = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.grpCUsuario = new System.Windows.Forms.GroupBox();
            this.btnPesquisar = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.grdCUsuario = new System.Windows.Forms.DataGridView();
            this.grdID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdPerfil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdLogin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdFuncionario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label18 = new System.Windows.Forms.Label();
            this.txtCUsuario = new System.Windows.Forms.TextBox();
            this.erroSenha = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.erroLogin = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.erroPerfil = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.erroFuncionario = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.panMenu = new System.Windows.Forms.Panel();
            this.btnSalvar = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnEditar = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnNovo = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.grpCUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCUsuario)).BeginInit();
            this.panMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPerfil
            // 
            this.lblPerfil.AutoSize = true;
            this.lblPerfil.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerfil.Location = new System.Drawing.Point(25, 172);
            this.lblPerfil.Name = "lblPerfil";
            this.lblPerfil.Size = new System.Drawing.Size(37, 17);
            this.lblPerfil.TabIndex = 164;
            this.lblPerfil.Text = "Perfil";
            // 
            // cboPerfil
            // 
            this.cboPerfil.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboPerfil.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboPerfil.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPerfil.FormattingEnabled = true;
            this.cboPerfil.Location = new System.Drawing.Point(27, 192);
            this.cboPerfil.Name = "cboPerfil";
            this.cboPerfil.Size = new System.Drawing.Size(211, 25);
            this.cboPerfil.TabIndex = 2;
            this.cboPerfil.Enter += new System.EventHandler(this.FocusInCombo);
            this.cboPerfil.Leave += new System.EventHandler(this.FocusOutCombo);
            // 
            // lblFuncionario
            // 
            this.lblFuncionario.AutoSize = true;
            this.lblFuncionario.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFuncionario.Location = new System.Drawing.Point(24, 93);
            this.lblFuncionario.Name = "lblFuncionario";
            this.lblFuncionario.Size = new System.Drawing.Size(77, 17);
            this.lblFuncionario.TabIndex = 166;
            this.lblFuncionario.Text = "Funcionário";
            // 
            // cboFuncionario
            // 
            this.cboFuncionario.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboFuncionario.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboFuncionario.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboFuncionario.FormattingEnabled = true;
            this.cboFuncionario.Location = new System.Drawing.Point(27, 113);
            this.cboFuncionario.Name = "cboFuncionario";
            this.cboFuncionario.Size = new System.Drawing.Size(316, 25);
            this.cboFuncionario.TabIndex = 1;
            this.cboFuncionario.Enter += new System.EventHandler(this.FocusInCombo);
            this.cboFuncionario.Leave += new System.EventHandler(this.FocusOutCombo);
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.Location = new System.Drawing.Point(25, 225);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(40, 17);
            this.lblLogin.TabIndex = 170;
            this.lblLogin.Text = "Login";
            // 
            // txtLogin
            // 
            this.txtLogin.BackColor = System.Drawing.SystemColors.Window;
            this.txtLogin.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogin.Location = new System.Drawing.Point(28, 245);
            this.txtLogin.MaxLength = 20;
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(210, 22);
            this.txtLogin.TabIndex = 3;
            this.txtLogin.Enter += new System.EventHandler(this.FocusInTextMask);
            this.txtLogin.Leave += new System.EventHandler(this.FocusOutTextMask);
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.Location = new System.Drawing.Point(24, 275);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(45, 17);
            this.lblSenha.TabIndex = 172;
            this.lblSenha.Text = "Senha";
            // 
            // txtSenha
            // 
            this.txtSenha.BackColor = System.Drawing.SystemColors.Window;
            this.txtSenha.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.Location = new System.Drawing.Point(27, 295);
            this.txtSenha.MaxLength = 20;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(210, 22);
            this.txtSenha.TabIndex = 4;
            this.txtSenha.UseSystemPasswordChar = true;
            this.txtSenha.TextChanged += new System.EventHandler(this.checarSenha);
            this.txtSenha.Enter += new System.EventHandler(this.FocusInTextMask);
            this.txtSenha.Leave += new System.EventHandler(this.FocusOutTextMask);
            // 
            // lblConfirmarSenha
            // 
            this.lblConfirmarSenha.AutoSize = true;
            this.lblConfirmarSenha.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmarSenha.Location = new System.Drawing.Point(25, 327);
            this.lblConfirmarSenha.Name = "lblConfirmarSenha";
            this.lblConfirmarSenha.Size = new System.Drawing.Size(106, 17);
            this.lblConfirmarSenha.TabIndex = 174;
            this.lblConfirmarSenha.Text = "Confirmar Senha";
            // 
            // txtConfirmarSenha
            // 
            this.txtConfirmarSenha.BackColor = System.Drawing.SystemColors.Window;
            this.txtConfirmarSenha.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmarSenha.Location = new System.Drawing.Point(28, 347);
            this.txtConfirmarSenha.MaxLength = 20;
            this.txtConfirmarSenha.Name = "txtConfirmarSenha";
            this.txtConfirmarSenha.Size = new System.Drawing.Size(210, 22);
            this.txtConfirmarSenha.TabIndex = 5;
            this.txtConfirmarSenha.UseSystemPasswordChar = true;
            this.txtConfirmarSenha.Enter += new System.EventHandler(this.FocusInTextMask);
            this.txtConfirmarSenha.Leave += new System.EventHandler(this.FocusOutTextMask);
            // 
            // lblForcaSenha
            // 
            this.lblForcaSenha.AutoSize = true;
            this.lblForcaSenha.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblForcaSenha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblForcaSenha.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForcaSenha.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblForcaSenha.Location = new System.Drawing.Point(259, 300);
            this.lblForcaSenha.Name = "lblForcaSenha";
            this.lblForcaSenha.Size = new System.Drawing.Size(81, 17);
            this.lblForcaSenha.TabIndex = 202;
            this.lblForcaSenha.Text = "Senha Vazia";
            // 
            // txtForca5
            // 
            this.txtForca5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtForca5.Location = new System.Drawing.Point(332, 286);
            this.txtForca5.Multiline = true;
            this.txtForca5.Name = "txtForca5";
            this.txtForca5.Size = new System.Drawing.Size(12, 11);
            this.txtForca5.TabIndex = 201;
            this.txtForca5.TabStop = false;
            // 
            // txtForca4
            // 
            this.txtForca4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtForca4.Location = new System.Drawing.Point(314, 286);
            this.txtForca4.Multiline = true;
            this.txtForca4.Name = "txtForca4";
            this.txtForca4.Size = new System.Drawing.Size(12, 11);
            this.txtForca4.TabIndex = 200;
            this.txtForca4.TabStop = false;
            // 
            // txtForca3
            // 
            this.txtForca3.BackColor = System.Drawing.SystemColors.Window;
            this.txtForca3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtForca3.Location = new System.Drawing.Point(296, 286);
            this.txtForca3.Multiline = true;
            this.txtForca3.Name = "txtForca3";
            this.txtForca3.Size = new System.Drawing.Size(12, 11);
            this.txtForca3.TabIndex = 199;
            this.txtForca3.TabStop = false;
            // 
            // txtForca2
            // 
            this.txtForca2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtForca2.Location = new System.Drawing.Point(278, 286);
            this.txtForca2.Multiline = true;
            this.txtForca2.Name = "txtForca2";
            this.txtForca2.Size = new System.Drawing.Size(12, 11);
            this.txtForca2.TabIndex = 198;
            this.txtForca2.TabStop = false;
            // 
            // txtForca1
            // 
            this.txtForca1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtForca1.Location = new System.Drawing.Point(260, 286);
            this.txtForca1.Multiline = true;
            this.txtForca1.Name = "txtForca1";
            this.txtForca1.Size = new System.Drawing.Size(12, 11);
            this.txtForca1.TabIndex = 197;
            this.txtForca1.TabStop = false;
            // 
            // Codigo
            // 
            this.Codigo.AutoSize = true;
            this.Codigo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Codigo.Location = new System.Drawing.Point(275, 172);
            this.Codigo.Name = "Codigo";
            this.Codigo.Size = new System.Drawing.Size(52, 17);
            this.Codigo.TabIndex = 205;
            this.Codigo.Text = "Codigo";
            this.Codigo.Visible = false;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(278, 192);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(12, 22);
            this.txtCodigo.TabIndex = 204;
            this.txtCodigo.TabStop = false;
            this.txtCodigo.Visible = false;
            // 
            // grpCUsuario
            // 
            this.grpCUsuario.Controls.Add(this.btnPesquisar);
            this.grpCUsuario.Controls.Add(this.grdCUsuario);
            this.grpCUsuario.Controls.Add(this.label18);
            this.grpCUsuario.Controls.Add(this.txtCUsuario);
            this.grpCUsuario.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCUsuario.Location = new System.Drawing.Point(424, 93);
            this.grpCUsuario.Name = "grpCUsuario";
            this.grpCUsuario.Size = new System.Drawing.Size(450, 303);
            this.grpCUsuario.TabIndex = 6;
            this.grpCUsuario.TabStop = false;
            this.grpCUsuario.Text = "Consultar Usuários";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(374, 54);
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
            this.btnPesquisar.OverrideFocus.Back.Image = global::CashInBox.Properties.Resources.transparent_64x64;
            this.btnPesquisar.OverrideFocus.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnPesquisar.OverrideFocus.Border.Rounding = 5;
            this.btnPesquisar.OverrideFocus.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnPesquisar.OverrideFocus.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnPesquisar.OverrideFocus.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.Size = new System.Drawing.Size(51, 32);
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
            this.btnPesquisar.TabIndex = 77;
            this.btnPesquisar.Values.Text = "Consultar";
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            this.btnPesquisar.MouseEnter += new System.EventHandler(this.FocusInButton);
            // 
            // grdCUsuario
            // 
            this.grdCUsuario.AllowUserToAddRows = false;
            this.grdCUsuario.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(125)))), ((int)(((byte)(129)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdCUsuario.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grdCUsuario.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.grdCUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCUsuario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.grdID,
            this.grdPerfil,
            this.grdLogin,
            this.grdFuncionario});
            this.grdCUsuario.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.grdCUsuario.Location = new System.Drawing.Point(26, 99);
            this.grdCUsuario.Name = "grdCUsuario";
            this.grdCUsuario.ReadOnly = true;
            this.grdCUsuario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdCUsuario.Size = new System.Drawing.Size(399, 179);
            this.grdCUsuario.TabIndex = 76;
            this.grdCUsuario.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdCUsuario_CellDoubleClick);
            // 
            // grdID
            // 
            this.grdID.HeaderText = "ID";
            this.grdID.Name = "grdID";
            this.grdID.ReadOnly = true;
            this.grdID.Visible = false;
            // 
            // grdPerfil
            // 
            this.grdPerfil.HeaderText = "Perfil";
            this.grdPerfil.Name = "grdPerfil";
            this.grdPerfil.ReadOnly = true;
            // 
            // grdLogin
            // 
            this.grdLogin.HeaderText = "Login";
            this.grdLogin.Name = "grdLogin";
            this.grdLogin.ReadOnly = true;
            // 
            // grdFuncionario
            // 
            this.grdFuncionario.HeaderText = "Nome do Funcionario";
            this.grdFuncionario.Name = "grdFuncionario";
            this.grdFuncionario.ReadOnly = true;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(23, 34);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(397, 17);
            this.label18.TabIndex = 39;
            this.label18.Text = "Pesquise informando parte do nome do funcionário, login ou perfil";
            // 
            // txtCUsuario
            // 
            this.txtCUsuario.Location = new System.Drawing.Point(26, 64);
            this.txtCUsuario.Name = "txtCUsuario";
            this.txtCUsuario.Size = new System.Drawing.Size(318, 22);
            this.txtCUsuario.TabIndex = 0;
            this.txtCUsuario.TabStop = false;
            this.txtCUsuario.Enter += new System.EventHandler(this.FocusInTextMask);
            this.txtCUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCUsuario_KeyPress);
            this.txtCUsuario.Leave += new System.EventHandler(this.FocusOutTextMask);
            // 
            // erroSenha
            // 
            this.erroSenha.BorderColor = System.Drawing.Color.Red;
            this.erroSenha.BorderWidth = 2;
            this.erroSenha.Location = new System.Drawing.Point(26, 321);
            this.erroSenha.Name = "erroSenha";
            this.erroSenha.Size = new System.Drawing.Size(212, 24);
            // 
            // erroLogin
            // 
            this.erroLogin.BorderColor = System.Drawing.Color.Red;
            this.erroLogin.BorderWidth = 2;
            this.erroLogin.Location = new System.Drawing.Point(27, 271);
            this.erroLogin.Name = "erroLogin";
            this.erroLogin.Size = new System.Drawing.Size(212, 24);
            // 
            // erroPerfil
            // 
            this.erroPerfil.BorderColor = System.Drawing.Color.Red;
            this.erroPerfil.BorderWidth = 2;
            this.erroPerfil.Location = new System.Drawing.Point(26, 218);
            this.erroPerfil.Name = "erroPerfil";
            this.erroPerfil.Size = new System.Drawing.Size(213, 27);
            // 
            // erroFuncionario
            // 
            this.erroFuncionario.BorderColor = System.Drawing.Color.Red;
            this.erroFuncionario.BorderWidth = 2;
            this.erroFuncionario.Location = new System.Drawing.Point(27, 162);
            this.erroFuncionario.Name = "erroFuncionario";
            this.erroFuncionario.Size = new System.Drawing.Size(318, 27);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.erroFuncionario,
            this.erroPerfil,
            this.erroLogin,
            this.erroSenha});
            this.shapeContainer1.Size = new System.Drawing.Size(888, 435);
            this.shapeContainer1.TabIndex = 206;
            this.shapeContainer1.TabStop = false;
            // 
            // panMenu
            // 
            this.panMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.panMenu.Controls.Add(this.btnSalvar);
            this.panMenu.Controls.Add(this.btnEditar);
            this.panMenu.Controls.Add(this.btnNovo);
            this.panMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panMenu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panMenu.Location = new System.Drawing.Point(0, 0);
            this.panMenu.Name = "panMenu";
            this.panMenu.Size = new System.Drawing.Size(888, 60);
            this.panMenu.TabIndex = 207;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(113, 7);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(175)))), ((int)(((byte)(241)))));
            this.btnSalvar.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(175)))), ((int)(((byte)(241)))));
            this.btnSalvar.OverrideDefault.Back.Image = global::CashInBox.Properties.Resources.save_25x25;
            this.btnSalvar.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSalvar.OverrideDefault.Border.Rounding = 5;
            this.btnSalvar.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.Transparent;
            this.btnSalvar.OverrideFocus.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.btnSalvar.OverrideFocus.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.btnSalvar.OverrideFocus.Back.Image = global::CashInBox.Properties.Resources.transparent_64x64;
            this.btnSalvar.OverrideFocus.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSalvar.OverrideFocus.Border.Rounding = 5;
            this.btnSalvar.OverrideFocus.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnSalvar.OverrideFocus.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnSalvar.OverrideFocus.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Size = new System.Drawing.Size(49, 45);
            this.btnSalvar.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(175)))), ((int)(((byte)(241)))));
            this.btnSalvar.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(175)))), ((int)(((byte)(241)))));
            this.btnSalvar.StateCommon.Back.Image = global::CashInBox.Properties.Resources.save_25x25;
            this.btnSalvar.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            this.btnSalvar.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSalvar.StateCommon.Border.Rounding = 5;
            this.btnSalvar.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Transparent;
            this.btnSalvar.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(194)))), ((int)(((byte)(199)))));
            this.btnSalvar.StateDisabled.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(194)))), ((int)(((byte)(199)))));
            this.btnSalvar.StateDisabled.Back.Image = global::CashInBox.Properties.Resources.save_grey_25x25;
            this.btnSalvar.TabIndex = 3;
            this.btnSalvar.TabStop = false;
            this.btnSalvar.Values.Text = "Salvar";
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            this.btnSalvar.MouseEnter += new System.EventHandler(this.FocusInButton);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(62, 7);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(175)))), ((int)(((byte)(241)))));
            this.btnEditar.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(175)))), ((int)(((byte)(241)))));
            this.btnEditar.OverrideDefault.Back.Image = global::CashInBox.Properties.Resources.edit_25x25;
            this.btnEditar.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnEditar.OverrideDefault.Border.Rounding = 5;
            this.btnEditar.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.Transparent;
            this.btnEditar.OverrideFocus.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.btnEditar.OverrideFocus.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.btnEditar.OverrideFocus.Back.Image = global::CashInBox.Properties.Resources.transparent_64x64;
            this.btnEditar.OverrideFocus.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnEditar.OverrideFocus.Border.Rounding = 5;
            this.btnEditar.OverrideFocus.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnEditar.OverrideFocus.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnEditar.OverrideFocus.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Size = new System.Drawing.Size(45, 45);
            this.btnEditar.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(175)))), ((int)(((byte)(241)))));
            this.btnEditar.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(175)))), ((int)(((byte)(241)))));
            this.btnEditar.StateCommon.Back.Image = global::CashInBox.Properties.Resources.edit_25x25;
            this.btnEditar.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            this.btnEditar.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnEditar.StateCommon.Border.Rounding = 5;
            this.btnEditar.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Transparent;
            this.btnEditar.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(194)))), ((int)(((byte)(199)))));
            this.btnEditar.StateDisabled.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(194)))), ((int)(((byte)(199)))));
            this.btnEditar.StateDisabled.Back.Image = global::CashInBox.Properties.Resources.edit_grey_25x25;
            this.btnEditar.TabIndex = 2;
            this.btnEditar.TabStop = false;
            this.btnEditar.Values.Text = "Editar";
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            this.btnEditar.MouseEnter += new System.EventHandler(this.FocusInButton);
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(11, 7);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(175)))), ((int)(((byte)(241)))));
            this.btnNovo.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(175)))), ((int)(((byte)(241)))));
            this.btnNovo.OverrideDefault.Back.Image = global::CashInBox.Properties.Resources.add_25x25;
            this.btnNovo.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnNovo.OverrideDefault.Border.Rounding = 5;
            this.btnNovo.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.Transparent;
            this.btnNovo.OverrideFocus.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.btnNovo.OverrideFocus.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.btnNovo.OverrideFocus.Back.Image = global::CashInBox.Properties.Resources.transparent_64x64;
            this.btnNovo.OverrideFocus.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnNovo.OverrideFocus.Border.Rounding = 5;
            this.btnNovo.OverrideFocus.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnNovo.OverrideFocus.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnNovo.OverrideFocus.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.Size = new System.Drawing.Size(45, 45);
            this.btnNovo.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(175)))), ((int)(((byte)(241)))));
            this.btnNovo.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(175)))), ((int)(((byte)(241)))));
            this.btnNovo.StateCommon.Back.Image = global::CashInBox.Properties.Resources.add_25x25;
            this.btnNovo.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            this.btnNovo.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnNovo.StateCommon.Border.Rounding = 5;
            this.btnNovo.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Transparent;
            this.btnNovo.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(194)))), ((int)(((byte)(199)))));
            this.btnNovo.StateDisabled.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(194)))), ((int)(((byte)(199)))));
            this.btnNovo.StateDisabled.Back.Image = global::CashInBox.Properties.Resources.add_grey_25x25;
            this.btnNovo.TabIndex = 1;
            this.btnNovo.TabStop = false;
            this.btnNovo.Values.Text = "Novo";
            this.btnNovo.Click += new System.EventHandler(this.btNovo_Click);
            this.btnNovo.MouseEnter += new System.EventHandler(this.FocusInButton);
            // 
            // frmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(888, 435);
            this.Controls.Add(this.panMenu);
            this.Controls.Add(this.grpCUsuario);
            this.Controls.Add(this.Codigo);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblForcaSenha);
            this.Controls.Add(this.txtForca5);
            this.Controls.Add(this.txtForca4);
            this.Controls.Add(this.txtForca3);
            this.Controls.Add(this.txtForca2);
            this.Controls.Add(this.txtForca1);
            this.Controls.Add(this.txtConfirmarSenha);
            this.Controls.Add(this.lblConfirmarSenha);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.lblFuncionario);
            this.Controls.Add(this.cboFuncionario);
            this.Controls.Add(this.lblPerfil);
            this.Controls.Add(this.cboPerfil);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Usuário";
            this.Load += new System.EventHandler(this.frmUsuario_Load);
            this.grpCUsuario.ResumeLayout(false);
            this.grpCUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCUsuario)).EndInit();
            this.panMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPerfil;
        private System.Windows.Forms.ComboBox cboPerfil;
        private System.Windows.Forms.Label lblFuncionario;
        private System.Windows.Forms.ComboBox cboFuncionario;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label lblConfirmarSenha;
        private System.Windows.Forms.TextBox txtConfirmarSenha;
        public System.Windows.Forms.Label lblForcaSenha;
        public System.Windows.Forms.TextBox txtForca5;
        public System.Windows.Forms.TextBox txtForca4;
        public System.Windows.Forms.TextBox txtForca3;
        public System.Windows.Forms.TextBox txtForca2;
        public System.Windows.Forms.TextBox txtForca1;
        private System.Windows.Forms.Label Codigo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.DataGridView grdCUsuario;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtCUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn grdID;
        private System.Windows.Forms.DataGridViewTextBoxColumn grdPerfil;
        private System.Windows.Forms.DataGridViewTextBoxColumn grdLogin;
        private System.Windows.Forms.DataGridViewTextBoxColumn grdFuncionario;
        public System.Windows.Forms.GroupBox grpCUsuario;
        public ComponentFactory.Krypton.Toolkit.KryptonButton btnPesquisar;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape erroSenha;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape erroLogin;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape erroPerfil;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape erroFuncionario;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private System.Windows.Forms.Panel panMenu;
        public ComponentFactory.Krypton.Toolkit.KryptonButton btnSalvar;
        public ComponentFactory.Krypton.Toolkit.KryptonButton btnEditar;
        public ComponentFactory.Krypton.Toolkit.KryptonButton btnNovo;
    }
}