namespace CashInBox
{
    partial class frmPerfil
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblPerfil = new System.Windows.Forms.Label();
            this.txtPerfil = new System.Windows.Forms.TextBox();
            this.lblFuncionalidades = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.grpCPerfil = new System.Windows.Forms.GroupBox();
            this.btnPesquisar = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.grdCPerfil = new System.Windows.Forms.DataGridView();
            this.grdID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdPerfil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label18 = new System.Windows.Forms.Label();
            this.txtCPerfil = new System.Windows.Forms.TextBox();
            this.tipMarcar = new System.Windows.Forms.ToolTip(this.components);
            this.treFuncionalidades = new System.Windows.Forms.TreeView();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.erroUnidades = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.erroFuncionalidade = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.erroPerfilNome = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.panMenu = new System.Windows.Forms.Panel();
            this.btnSalvar = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnEditar = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnNovo = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.grpCPerfil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCPerfil)).BeginInit();
            this.panMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPerfil
            // 
            this.lblPerfil.AutoSize = true;
            this.lblPerfil.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerfil.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPerfil.Location = new System.Drawing.Point(12, 78);
            this.lblPerfil.Name = "lblPerfil";
            this.lblPerfil.Size = new System.Drawing.Size(40, 17);
            this.lblPerfil.TabIndex = 74;
            this.lblPerfil.Text = "Perfil:";
            // 
            // txtPerfil
            // 
            this.txtPerfil.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPerfil.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPerfil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPerfil.Location = new System.Drawing.Point(16, 98);
            this.txtPerfil.MaxLength = 50;
            this.txtPerfil.Name = "txtPerfil";
            this.txtPerfil.Size = new System.Drawing.Size(144, 22);
            this.txtPerfil.TabIndex = 73;
            // 
            // lblFuncionalidades
            // 
            this.lblFuncionalidades.AutoSize = true;
            this.lblFuncionalidades.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFuncionalidades.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblFuncionalidades.Location = new System.Drawing.Point(12, 132);
            this.lblFuncionalidades.Name = "lblFuncionalidades";
            this.lblFuncionalidades.Size = new System.Drawing.Size(108, 17);
            this.lblFuncionalidades.TabIndex = 83;
            this.lblFuncionalidades.Text = "Funcionalidades:";
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtId.Location = new System.Drawing.Point(189, 100);
            this.txtId.MaxLength = 255;
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(62, 20);
            this.txtId.TabIndex = 79;
            this.txtId.Visible = false;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblId.Location = new System.Drawing.Point(186, 80);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(21, 13);
            this.lblId.TabIndex = 78;
            this.lblId.Text = "ID:";
            this.lblId.Visible = false;
            // 
            // grpCPerfil
            // 
            this.grpCPerfil.Controls.Add(this.btnPesquisar);
            this.grpCPerfil.Controls.Add(this.grdCPerfil);
            this.grpCPerfil.Controls.Add(this.label18);
            this.grpCPerfil.Controls.Add(this.txtCPerfil);
            this.grpCPerfil.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCPerfil.Location = new System.Drawing.Point(467, 72);
            this.grpCPerfil.Name = "grpCPerfil";
            this.grpCPerfil.Size = new System.Drawing.Size(324, 310);
            this.grpCPerfil.TabIndex = 85;
            this.grpCPerfil.TabStop = false;
            this.grpCPerfil.Text = "Consultar Perfis";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(238, 26);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(175)))), ((int)(((byte)(241)))));
            this.btnPesquisar.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(175)))), ((int)(((byte)(241)))));
            this.btnPesquisar.OverrideDefault.Back.Image = global::CashInBox.Properties.Resources.search_25x25;
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
            this.btnPesquisar.OverrideFocus.Content.ShortText.Font = new System.Drawing.Font("Hasteristico", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.Size = new System.Drawing.Size(66, 35);
            this.btnPesquisar.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(175)))), ((int)(((byte)(241)))));
            this.btnPesquisar.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(175)))), ((int)(((byte)(241)))));
            this.btnPesquisar.StateCommon.Back.Image = global::CashInBox.Properties.Resources.search_25x25;
            this.btnPesquisar.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            this.btnPesquisar.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnPesquisar.StateCommon.Border.Rounding = 5;
            this.btnPesquisar.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Transparent;
            this.btnPesquisar.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(194)))), ((int)(((byte)(199)))));
            this.btnPesquisar.StateDisabled.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(194)))), ((int)(((byte)(199)))));
            this.btnPesquisar.StateDisabled.Back.Image = global::CashInBox.Properties.Resources.search_grey_25x25;
            this.btnPesquisar.TabIndex = 4;
            this.btnPesquisar.Values.Text = "Consultar";
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            this.btnPesquisar.MouseEnter += new System.EventHandler(this.FocusInButton);
            // 
            // grdCPerfil
            // 
            this.grdCPerfil.AllowUserToAddRows = false;
            this.grdCPerfil.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdCPerfil.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grdCPerfil.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.grdCPerfil.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCPerfil.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.grdID,
            this.grdPerfil});
            this.grdCPerfil.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.grdCPerfil.Location = new System.Drawing.Point(18, 67);
            this.grdCPerfil.Name = "grdCPerfil";
            this.grdCPerfil.ReadOnly = true;
            this.grdCPerfil.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdCPerfil.Size = new System.Drawing.Size(286, 226);
            this.grdCPerfil.TabIndex = 99;
            this.grdCPerfil.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdCPerfil_CellDoubleClick);
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
            this.grdPerfil.Width = 200;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(15, 21);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(37, 17);
            this.label18.TabIndex = 97;
            this.label18.Text = "Perfil";
            // 
            // txtCPerfil
            // 
            this.txtCPerfil.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCPerfil.Location = new System.Drawing.Point(18, 41);
            this.txtCPerfil.Name = "txtCPerfil";
            this.txtCPerfil.Size = new System.Drawing.Size(205, 22);
            this.txtCPerfil.TabIndex = 98;
            this.txtCPerfil.TabStop = false;
            this.txtCPerfil.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCPerfil_KeyPress);
            // 
            // treFuncionalidades
            // 
            this.treFuncionalidades.CheckBoxes = true;
            this.treFuncionalidades.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treFuncionalidades.Location = new System.Drawing.Point(15, 156);
            this.treFuncionalidades.Name = "treFuncionalidades";
            this.treFuncionalidades.Size = new System.Drawing.Size(430, 233);
            this.treFuncionalidades.TabIndex = 102;
            this.treFuncionalidades.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.treFuncionalidades_AfterCheck);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.erroUnidades,
            this.erroFuncionalidade,
            this.erroPerfilNome});
            this.shapeContainer1.Size = new System.Drawing.Size(803, 409);
            this.shapeContainer1.TabIndex = 103;
            this.shapeContainer1.TabStop = false;
            // 
            // erroUnidades
            // 
            this.erroUnidades.BorderColor = System.Drawing.Color.Red;
            this.erroUnidades.BorderWidth = 2;
            this.erroUnidades.Location = new System.Drawing.Point(286, 155);
            this.erroUnidades.Name = "erroUnidades";
            this.erroUnidades.Size = new System.Drawing.Size(160, 130);
            this.erroUnidades.Visible = false;
            // 
            // erroFuncionalidade
            // 
            this.erroFuncionalidade.BorderColor = System.Drawing.Color.Red;
            this.erroFuncionalidade.BorderWidth = 2;
            this.erroFuncionalidade.Location = new System.Drawing.Point(13, 155);
            this.erroFuncionalidade.Name = "erroFuncionalidade";
            this.erroFuncionalidade.Size = new System.Drawing.Size(261, 236);
            this.erroFuncionalidade.Visible = false;
            // 
            // erroPerfilNome
            // 
            this.erroPerfilNome.BorderColor = System.Drawing.Color.Red;
            this.erroPerfilNome.BorderWidth = 2;
            this.erroPerfilNome.Location = new System.Drawing.Point(15, 97);
            this.erroPerfilNome.Name = "erroPerfilNome";
            this.erroPerfilNome.Size = new System.Drawing.Size(146, 24);
            this.erroPerfilNome.Visible = false;
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
            this.panMenu.Size = new System.Drawing.Size(803, 66);
            this.panMenu.TabIndex = 197;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(114, 12);
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
            this.btnSalvar.OverrideFocus.Content.ShortText.Font = new System.Drawing.Font("Hasteristico", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btnSalvar.Values.Text = "Salvar";
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            this.btnSalvar.MouseEnter += new System.EventHandler(this.FocusInButton);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(63, 12);
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
            this.btnEditar.OverrideFocus.Content.ShortText.Font = new System.Drawing.Font("Hasteristico", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btnEditar.Values.Text = "Editar";
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            this.btnEditar.MouseEnter += new System.EventHandler(this.FocusInButton);
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(12, 12);
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
            this.btnNovo.OverrideFocus.Content.ShortText.Font = new System.Drawing.Font("Hasteristico", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btnNovo.Values.Text = "Novo";
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            this.btnNovo.MouseEnter += new System.EventHandler(this.FocusInButton);
            // 
            // frmPerfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(803, 409);
            this.Controls.Add(this.panMenu);
            this.Controls.Add(this.treFuncionalidades);
            this.Controls.Add(this.grpCPerfil);
            this.Controls.Add(this.lblFuncionalidades);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtPerfil);
            this.Controls.Add(this.lblPerfil);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmPerfil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Perfil";
            this.Load += new System.EventHandler(this.frmPerfil_Load);
            this.grpCPerfil.ResumeLayout(false);
            this.grpCPerfil.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCPerfil)).EndInit();
            this.panMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblPerfil;
        public System.Windows.Forms.TextBox txtPerfil;
        public System.Windows.Forms.Label lblFuncionalidades;
        public System.Windows.Forms.TextBox txtId;
        public System.Windows.Forms.Label lblId;
        private System.Windows.Forms.DataGridViewTextBoxColumn grdID;
        private System.Windows.Forms.DataGridViewTextBoxColumn grdPerfil;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ToolTip tipMarcar;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape erroFuncionalidade;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape erroPerfilNome;
        public System.Windows.Forms.DataGridView grdCPerfil;
        public System.Windows.Forms.TextBox txtCPerfil;
        public System.Windows.Forms.TreeView treFuncionalidades;
        public System.Windows.Forms.GroupBox grpCPerfil;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape erroUnidades;
        public ComponentFactory.Krypton.Toolkit.KryptonButton btnPesquisar;
        private System.Windows.Forms.Panel panMenu;
        public ComponentFactory.Krypton.Toolkit.KryptonButton btnSalvar;
        public ComponentFactory.Krypton.Toolkit.KryptonButton btnEditar;
        public ComponentFactory.Krypton.Toolkit.KryptonButton btnNovo;

    }
}