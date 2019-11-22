namespace CashInBox
{
    partial class frmFuncionario
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
            this.cboEstados = new System.Windows.Forms.ComboBox();
            this.lblUf = new System.Windows.Forms.Label();
            this.lblNumeroEnd = new System.Windows.Forms.Label();
            this.txtNumEnd = new System.Windows.Forms.TextBox();
            this.lblTipoTel = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.mskTelefone = new System.Windows.Forms.MaskedTextBox();
            this.mskCep = new System.Windows.Forms.MaskedTextBox();
            this.mskCPF = new System.Windows.Forms.MaskedTextBox();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboFone = new System.Windows.Forms.ComboBox();
            this.grdTelefones = new System.Windows.Forms.DataGridView();
            this.grdFone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label22 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.Nome = new System.Windows.Forms.Label();
            this.DtCadastro = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Codigo = new System.Windows.Forms.Label();
            this.txtRg = new System.Windows.Forms.TextBox();
            this.txtObservacao = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.txtFuncionario = new System.Windows.Forms.TextBox();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.btnRemoverTel = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnAdicionarTel = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.panMenu = new System.Windows.Forms.Panel();
            this.btnConsultar = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnSalvar = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnEditar = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnNovo = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.grdTelefones)).BeginInit();
            this.panMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboEstados
            // 
            this.cboEstados.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboEstados.FormattingEnabled = true;
            this.cboEstados.Location = new System.Drawing.Point(374, 369);
            this.cboEstados.Name = "cboEstados";
            this.cboEstados.Size = new System.Drawing.Size(44, 25);
            this.cboEstados.TabIndex = 12;
            this.cboEstados.Enter += new System.EventHandler(this.FocusInCombo);
            this.cboEstados.Leave += new System.EventHandler(this.FocusOutCombo);
            // 
            // lblUf
            // 
            this.lblUf.AutoSize = true;
            this.lblUf.Location = new System.Drawing.Point(371, 353);
            this.lblUf.Name = "lblUf";
            this.lblUf.Size = new System.Drawing.Size(21, 13);
            this.lblUf.TabIndex = 159;
            this.lblUf.Text = "UF";
            // 
            // lblNumeroEnd
            // 
            this.lblNumeroEnd.AutoSize = true;
            this.lblNumeroEnd.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroEnd.Location = new System.Drawing.Point(334, 304);
            this.lblNumeroEnd.Name = "lblNumeroEnd";
            this.lblNumeroEnd.Size = new System.Drawing.Size(55, 17);
            this.lblNumeroEnd.TabIndex = 158;
            this.lblNumeroEnd.Text = "Número";
            // 
            // txtNumEnd
            // 
            this.txtNumEnd.BackColor = System.Drawing.SystemColors.Window;
            this.txtNumEnd.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNumEnd.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumEnd.Location = new System.Drawing.Point(337, 324);
            this.txtNumEnd.MaxLength = 15;
            this.txtNumEnd.Name = "txtNumEnd";
            this.txtNumEnd.Size = new System.Drawing.Size(81, 22);
            this.txtNumEnd.TabIndex = 9;
            this.txtNumEnd.Enter += new System.EventHandler(this.FocusInTextMask);
            this.txtNumEnd.Leave += new System.EventHandler(this.FocusOutTextMask);
            // 
            // lblTipoTel
            // 
            this.lblTipoTel.AutoSize = true;
            this.lblTipoTel.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoTel.Location = new System.Drawing.Point(612, 98);
            this.lblTipoTel.Name = "lblTipoTel";
            this.lblTipoTel.Size = new System.Drawing.Size(32, 17);
            this.lblTipoTel.TabIndex = 157;
            this.lblTipoTel.Text = "Tipo";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.SystemColors.Window;
            this.txtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEmail.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(453, 344);
            this.txtEmail.MaxLength = 100;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(300, 22);
            this.txtEmail.TabIndex = 16;
            this.txtEmail.Enter += new System.EventHandler(this.FocusInTextMask);
            this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
            // 
            // mskTelefone
            // 
            this.mskTelefone.BackColor = System.Drawing.SystemColors.Window;
            this.mskTelefone.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskTelefone.Location = new System.Drawing.Point(453, 118);
            this.mskTelefone.Mask = "(99)00000-0000";
            this.mskTelefone.Name = "mskTelefone";
            this.mskTelefone.Size = new System.Drawing.Size(156, 22);
            this.mskTelefone.TabIndex = 14;
            this.mskTelefone.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mskTelefone.Click += new System.EventHandler(this.PonteiroInicialMascara);
            this.mskTelefone.Enter += new System.EventHandler(this.FocusInTextMask);
            this.mskTelefone.Leave += new System.EventHandler(this.mskTelefone_Leave);
            // 
            // mskCep
            // 
            this.mskCep.BackColor = System.Drawing.SystemColors.Window;
            this.mskCep.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskCep.Location = new System.Drawing.Point(15, 268);
            this.mskCep.Mask = "00\\.000\\-000";
            this.mskCep.Name = "mskCep";
            this.mskCep.Size = new System.Drawing.Size(92, 22);
            this.mskCep.TabIndex = 7;
            this.mskCep.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mskCep.Click += new System.EventHandler(this.PonteiroInicialMascara);
            this.mskCep.Enter += new System.EventHandler(this.FocusInTextMask);
            // 
            // mskCPF
            // 
            this.mskCPF.BackColor = System.Drawing.SystemColors.Window;
            this.mskCPF.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskCPF.Location = new System.Drawing.Point(15, 213);
            this.mskCPF.Mask = "000\\.000\\.000\\-00";
            this.mskCPF.Name = "mskCPF";
            this.mskCPF.Size = new System.Drawing.Size(166, 22);
            this.mskCPF.TabIndex = 5;
            this.mskCPF.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mskCPF.Click += new System.EventHandler(this.PonteiroInicialMascara);
            this.mskCPF.Enter += new System.EventHandler(this.FocusInTextMask);
            this.mskCPF.Leave += new System.EventHandler(this.mskCPF_Leave);
            // 
            // cboStatus
            // 
            this.cboStatus.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboStatus.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboStatus.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Location = new System.Drawing.Point(297, 115);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(121, 25);
            this.cboStatus.TabIndex = 2;
            this.cboStatus.Enter += new System.EventHandler(this.FocusInCombo);
            this.cboStatus.Leave += new System.EventHandler(this.FocusOutCombo);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(294, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 148;
            this.label1.Text = "Status";
            // 
            // cboFone
            // 
            this.cboFone.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboFone.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboFone.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboFone.FormattingEnabled = true;
            this.cboFone.Location = new System.Drawing.Point(615, 117);
            this.cboFone.Name = "cboFone";
            this.cboFone.Size = new System.Drawing.Size(138, 25);
            this.cboFone.TabIndex = 15;
            this.cboFone.Enter += new System.EventHandler(this.FocusInCombo);
            this.cboFone.Leave += new System.EventHandler(this.FocusOutCombo);
            // 
            // grdTelefones
            // 
            this.grdTelefones.AllowUserToAddRows = false;
            this.grdTelefones.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(125)))), ((int)(((byte)(129)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdTelefones.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grdTelefones.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdTelefones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grdTelefones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdTelefones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.grdFone,
            this.grdTipo});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdTelefones.DefaultCellStyle = dataGridViewCellStyle3;
            this.grdTelefones.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.grdTelefones.Location = new System.Drawing.Point(453, 150);
            this.grdTelefones.Name = "grdTelefones";
            this.grdTelefones.ReadOnly = true;
            this.grdTelefones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdTelefones.Size = new System.Drawing.Size(270, 140);
            this.grdTelefones.TabIndex = 92;
            this.grdTelefones.TabStop = false;
            // 
            // grdFone
            // 
            this.grdFone.HeaderText = "Fone";
            this.grdFone.MaxInputLength = 15000;
            this.grdFone.Name = "grdFone";
            this.grdFone.ReadOnly = true;
            this.grdFone.Width = 150;
            // 
            // grdTipo
            // 
            this.grdTipo.HeaderText = "Tipo";
            this.grdTipo.Name = "grdTipo";
            this.grdTipo.ReadOnly = true;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(214, 193);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(25, 17);
            this.label22.TabIndex = 142;
            this.label22.Text = "RG";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(12, 248);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(33, 17);
            this.label16.TabIndex = 137;
            this.label16.Text = "Cep";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(12, 304);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(65, 17);
            this.label15.TabIndex = 136;
            this.label15.Text = "Endereço";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(450, 98);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(59, 17);
            this.label14.TabIndex = 135;
            this.label14.Text = "Telefone";
            // 
            // Nome
            // 
            this.Nome.AutoSize = true;
            this.Nome.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nome.Location = new System.Drawing.Point(12, 144);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(135, 17);
            this.Nome.TabIndex = 133;
            this.Nome.Text = "Nome do Funcionário";
            // 
            // DtCadastro
            // 
            this.DtCadastro.AutoSize = true;
            this.DtCadastro.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtCadastro.Location = new System.Drawing.Point(146, 90);
            this.DtCadastro.Name = "DtCadastro";
            this.DtCadastro.Size = new System.Drawing.Size(115, 17);
            this.DtCadastro.TabIndex = 131;
            this.DtCadastro.Text = "Data de Cadastro";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(450, 324);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 17);
            this.label9.TabIndex = 130;
            this.label9.Text = "E-Mail";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 352);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 17);
            this.label8.TabIndex = 128;
            this.label8.Text = "Bairro";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 406);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 17);
            this.label6.TabIndex = 125;
            this.label6.Text = "Observação";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(165, 352);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 17);
            this.label4.TabIndex = 122;
            this.label4.Text = "Cidade";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 17);
            this.label3.TabIndex = 119;
            this.label3.Text = "CPF";
            // 
            // Codigo
            // 
            this.Codigo.AutoSize = true;
            this.Codigo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Codigo.Location = new System.Drawing.Point(12, 90);
            this.Codigo.Name = "Codigo";
            this.Codigo.Size = new System.Drawing.Size(52, 17);
            this.Codigo.TabIndex = 116;
            this.Codigo.Text = "Codigo";
            // 
            // txtRg
            // 
            this.txtRg.BackColor = System.Drawing.SystemColors.Window;
            this.txtRg.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRg.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRg.Location = new System.Drawing.Point(217, 213);
            this.txtRg.MaxLength = 50;
            this.txtRg.Name = "txtRg";
            this.txtRg.Size = new System.Drawing.Size(201, 22);
            this.txtRg.TabIndex = 6;
            this.txtRg.Enter += new System.EventHandler(this.FocusInTextMask);
            this.txtRg.Leave += new System.EventHandler(this.FocusOutTextMask);
            // 
            // txtObservacao
            // 
            this.txtObservacao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtObservacao.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservacao.Location = new System.Drawing.Point(15, 426);
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Size = new System.Drawing.Size(403, 22);
            this.txtObservacao.TabIndex = 13;
            this.txtObservacao.Enter += new System.EventHandler(this.FocusInTextMask);
            this.txtObservacao.Leave += new System.EventHandler(this.FocusOutTextMask);
            // 
            // txtCidade
            // 
            this.txtCidade.BackColor = System.Drawing.SystemColors.Window;
            this.txtCidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCidade.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCidade.Location = new System.Drawing.Point(168, 372);
            this.txtCidade.MaxLength = 50;
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(200, 22);
            this.txtCidade.TabIndex = 11;
            this.txtCidade.Enter += new System.EventHandler(this.FocusInTextMask);
            this.txtCidade.Leave += new System.EventHandler(this.FocusOutTextMask);
            // 
            // txtBairro
            // 
            this.txtBairro.BackColor = System.Drawing.SystemColors.Window;
            this.txtBairro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBairro.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBairro.Location = new System.Drawing.Point(15, 372);
            this.txtBairro.MaxLength = 50;
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(147, 22);
            this.txtBairro.TabIndex = 10;
            this.txtBairro.Enter += new System.EventHandler(this.FocusInTextMask);
            this.txtBairro.Leave += new System.EventHandler(this.FocusOutTextMask);
            // 
            // txtEndereco
            // 
            this.txtEndereco.BackColor = System.Drawing.SystemColors.Window;
            this.txtEndereco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEndereco.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndereco.Location = new System.Drawing.Point(15, 324);
            this.txtEndereco.MaxLength = 100;
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(316, 22);
            this.txtEndereco.TabIndex = 8;
            this.txtEndereco.Enter += new System.EventHandler(this.FocusInTextMask);
            this.txtEndereco.Leave += new System.EventHandler(this.FocusOutTextMask);
            // 
            // txtFuncionario
            // 
            this.txtFuncionario.BackColor = System.Drawing.SystemColors.Window;
            this.txtFuncionario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFuncionario.Location = new System.Drawing.Point(15, 164);
            this.txtFuncionario.MaxLength = 200;
            this.txtFuncionario.Name = "txtFuncionario";
            this.txtFuncionario.Size = new System.Drawing.Size(403, 20);
            this.txtFuncionario.TabIndex = 3;
            this.txtFuncionario.Enter += new System.EventHandler(this.FocusInTextMask);
            this.txtFuncionario.Leave += new System.EventHandler(this.FocusOutTextMask);
            // 
            // dtpData
            // 
            this.dtpData.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpData.Location = new System.Drawing.Point(149, 115);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(112, 22);
            this.dtpData.TabIndex = 1;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(15, 115);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(100, 22);
            this.txtCodigo.TabIndex = 0;
            this.txtCodigo.TabStop = false;
            // 
            // btnRemoverTel
            // 
            this.btnRemoverTel.Location = new System.Drawing.Point(729, 184);
            this.btnRemoverTel.Name = "btnRemoverTel";
            this.btnRemoverTel.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(84)))), ((int)(((byte)(62)))));
            this.btnRemoverTel.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(84)))), ((int)(((byte)(62)))));
            this.btnRemoverTel.OverrideDefault.Back.Image = global::CashInBox.Properties.Resources.remove_white_16x16;
            this.btnRemoverTel.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnRemoverTel.OverrideDefault.Border.Rounding = 5;
            this.btnRemoverTel.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.Transparent;
            this.btnRemoverTel.OverrideFocus.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.btnRemoverTel.OverrideFocus.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.btnRemoverTel.OverrideFocus.Back.Image = global::CashInBox.Properties.Resources.remove_white_16x16;
            this.btnRemoverTel.OverrideFocus.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnRemoverTel.OverrideFocus.Border.Rounding = 5;
            this.btnRemoverTel.OverrideFocus.Content.ShortText.Color1 = System.Drawing.Color.Transparent;
            this.btnRemoverTel.OverrideFocus.Content.ShortText.Color2 = System.Drawing.Color.Transparent;
            this.btnRemoverTel.OverrideFocus.Content.ShortText.Font = new System.Drawing.Font("Hasteristico", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoverTel.Size = new System.Drawing.Size(24, 30);
            this.btnRemoverTel.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(84)))), ((int)(((byte)(62)))));
            this.btnRemoverTel.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(84)))), ((int)(((byte)(62)))));
            this.btnRemoverTel.StateCommon.Back.Image = global::CashInBox.Properties.Resources.remove_white_16x16;
            this.btnRemoverTel.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            this.btnRemoverTel.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnRemoverTel.StateCommon.Border.Rounding = 5;
            this.btnRemoverTel.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Transparent;
            this.btnRemoverTel.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(194)))), ((int)(((byte)(199)))));
            this.btnRemoverTel.StateDisabled.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(194)))), ((int)(((byte)(199)))));
            this.btnRemoverTel.StateDisabled.Back.Image = global::CashInBox.Properties.Resources.remove_grey_16x16;
            this.btnRemoverTel.TabIndex = 170;
            this.btnRemoverTel.TabStop = false;
            this.btnRemoverTel.Values.Text = "Novo";
            this.btnRemoverTel.Click += new System.EventHandler(this.btnRemoverTel_Click);
            this.btnRemoverTel.MouseEnter += new System.EventHandler(this.FocuInButton);
            // 
            // btnAdicionarTel
            // 
            this.btnAdicionarTel.Location = new System.Drawing.Point(729, 150);
            this.btnAdicionarTel.Name = "btnAdicionarTel";
            this.btnAdicionarTel.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(84)))), ((int)(((byte)(62)))));
            this.btnAdicionarTel.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(84)))), ((int)(((byte)(62)))));
            this.btnAdicionarTel.OverrideDefault.Back.Image = global::CashInBox.Properties.Resources.add_white_16x16;
            this.btnAdicionarTel.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnAdicionarTel.OverrideDefault.Border.Rounding = 5;
            this.btnAdicionarTel.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.Transparent;
            this.btnAdicionarTel.OverrideFocus.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.btnAdicionarTel.OverrideFocus.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.btnAdicionarTel.OverrideFocus.Back.Image = global::CashInBox.Properties.Resources.add_white_16x16;
            this.btnAdicionarTel.OverrideFocus.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnAdicionarTel.OverrideFocus.Border.Rounding = 5;
            this.btnAdicionarTel.OverrideFocus.Content.ShortText.Color1 = System.Drawing.Color.Transparent;
            this.btnAdicionarTel.OverrideFocus.Content.ShortText.Color2 = System.Drawing.Color.Transparent;
            this.btnAdicionarTel.OverrideFocus.Content.ShortText.Font = new System.Drawing.Font("Hasteristico", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionarTel.Size = new System.Drawing.Size(24, 28);
            this.btnAdicionarTel.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(84)))), ((int)(((byte)(62)))));
            this.btnAdicionarTel.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(84)))), ((int)(((byte)(62)))));
            this.btnAdicionarTel.StateCommon.Back.Image = global::CashInBox.Properties.Resources.add_white_16x16;
            this.btnAdicionarTel.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            this.btnAdicionarTel.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnAdicionarTel.StateCommon.Border.Rounding = 5;
            this.btnAdicionarTel.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Transparent;
            this.btnAdicionarTel.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(194)))), ((int)(((byte)(199)))));
            this.btnAdicionarTel.StateDisabled.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(194)))), ((int)(((byte)(199)))));
            this.btnAdicionarTel.StateDisabled.Back.Image = global::CashInBox.Properties.Resources.add_grey_16x16;
            this.btnAdicionarTel.TabIndex = 169;
            this.btnAdicionarTel.TabStop = false;
            this.btnAdicionarTel.Values.Text = "Novo";
            this.btnAdicionarTel.Click += new System.EventHandler(this.btnAdicionarTel_Click);
            this.btnAdicionarTel.MouseEnter += new System.EventHandler(this.FocuInButton);
            // 
            // panMenu
            // 
            this.panMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.panMenu.Controls.Add(this.btnConsultar);
            this.panMenu.Controls.Add(this.btnSalvar);
            this.panMenu.Controls.Add(this.btnEditar);
            this.panMenu.Controls.Add(this.btnNovo);
            this.panMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panMenu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panMenu.Location = new System.Drawing.Point(0, 0);
            this.panMenu.Name = "panMenu";
            this.panMenu.Size = new System.Drawing.Size(774, 60);
            this.panMenu.TabIndex = 173;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(168, 7);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(175)))), ((int)(((byte)(241)))));
            this.btnConsultar.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(175)))), ((int)(((byte)(241)))));
            this.btnConsultar.OverrideDefault.Back.Image = global::CashInBox.Properties.Resources.search_25x25;
            this.btnConsultar.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnConsultar.OverrideDefault.Border.Rounding = 5;
            this.btnConsultar.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.Transparent;
            this.btnConsultar.OverrideFocus.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.btnConsultar.OverrideFocus.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.btnConsultar.OverrideFocus.Back.Image = global::CashInBox.Properties.Resources.transparent_64x64;
            this.btnConsultar.OverrideFocus.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnConsultar.OverrideFocus.Border.Rounding = 5;
            this.btnConsultar.OverrideFocus.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnConsultar.OverrideFocus.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnConsultar.OverrideFocus.Content.ShortText.Font = new System.Drawing.Font("Hasteristico", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.Size = new System.Drawing.Size(66, 45);
            this.btnConsultar.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(175)))), ((int)(((byte)(241)))));
            this.btnConsultar.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(175)))), ((int)(((byte)(241)))));
            this.btnConsultar.StateCommon.Back.Image = global::CashInBox.Properties.Resources.search_25x25;
            this.btnConsultar.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            this.btnConsultar.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnConsultar.StateCommon.Border.Rounding = 5;
            this.btnConsultar.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Transparent;
            this.btnConsultar.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(194)))), ((int)(((byte)(199)))));
            this.btnConsultar.StateDisabled.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(194)))), ((int)(((byte)(199)))));
            this.btnConsultar.StateDisabled.Back.Image = global::CashInBox.Properties.Resources.search_grey_25x25;
            this.btnConsultar.TabIndex = 4;
            this.btnConsultar.TabStop = false;
            this.btnConsultar.Values.Text = "Consultar";
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            this.btnConsultar.MouseEnter += new System.EventHandler(this.FocuInButton);
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
            this.btnSalvar.TabStop = false;
            this.btnSalvar.Values.Text = "Salvar";
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            this.btnSalvar.MouseEnter += new System.EventHandler(this.FocuInButton);
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
            this.btnEditar.TabStop = false;
            this.btnEditar.Values.Text = "Editar";
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            this.btnEditar.MouseEnter += new System.EventHandler(this.FocuInButton);
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
            this.btnNovo.TabStop = false;
            this.btnNovo.Values.Text = "Novo";
            this.btnNovo.Click += new System.EventHandler(this.btNovo_Click);
            this.btnNovo.MouseEnter += new System.EventHandler(this.FocuInButton);
            // 
            // frmFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(774, 477);
            this.Controls.Add(this.panMenu);
            this.Controls.Add(this.btnRemoverTel);
            this.Controls.Add(this.btnAdicionarTel);
            this.Controls.Add(this.cboEstados);
            this.Controls.Add(this.lblUf);
            this.Controls.Add(this.lblNumeroEnd);
            this.Controls.Add(this.txtNumEnd);
            this.Controls.Add(this.lblTipoTel);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.mskTelefone);
            this.Controls.Add(this.mskCep);
            this.Controls.Add(this.mskCPF);
            this.Controls.Add(this.cboStatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboFone);
            this.Controls.Add(this.grdTelefones);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.Nome);
            this.Controls.Add(this.DtCadastro);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Codigo);
            this.Controls.Add(this.txtRg);
            this.Controls.Add(this.txtObservacao);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.txtFuncionario);
            this.Controls.Add(this.dtpData);
            this.Controls.Add(this.txtCodigo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Voluntários";
            this.Load += new System.EventHandler(this.frmFuncionario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdTelefones)).EndInit();
            this.panMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUf;
        private System.Windows.Forms.Label lblNumeroEnd;
        private System.Windows.Forms.Label lblTipoTel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label Nome;
        private System.Windows.Forms.Label DtCadastro;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Codigo;
        public System.Windows.Forms.ComboBox cboEstados;
        public System.Windows.Forms.MaskedTextBox mskCep;
        public System.Windows.Forms.TextBox txtCidade;
        public System.Windows.Forms.TextBox txtBairro;
        public System.Windows.Forms.TextBox txtEndereco;
        public System.Windows.Forms.TextBox txtNumEnd;
        public System.Windows.Forms.TextBox txtEmail;
        public System.Windows.Forms.MaskedTextBox mskTelefone;
        public System.Windows.Forms.MaskedTextBox mskCPF;
        public System.Windows.Forms.ComboBox cboStatus;
        public System.Windows.Forms.ComboBox cboFone;
        public System.Windows.Forms.DataGridView grdTelefones;
        public System.Windows.Forms.TextBox txtRg;
        public System.Windows.Forms.TextBox txtObservacao;
        public System.Windows.Forms.TextBox txtFuncionario;
        public System.Windows.Forms.DateTimePicker dtpData;
        public System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn grdFone;
        private System.Windows.Forms.DataGridViewTextBoxColumn grdTipo;
        public ComponentFactory.Krypton.Toolkit.KryptonButton btnRemoverTel;
        public ComponentFactory.Krypton.Toolkit.KryptonButton btnAdicionarTel;
        private System.Windows.Forms.Panel panMenu;
        public ComponentFactory.Krypton.Toolkit.KryptonButton btnConsultar;
        public ComponentFactory.Krypton.Toolkit.KryptonButton btnSalvar;
        public ComponentFactory.Krypton.Toolkit.KryptonButton btnEditar;
        public ComponentFactory.Krypton.Toolkit.KryptonButton btnNovo;
    }
}