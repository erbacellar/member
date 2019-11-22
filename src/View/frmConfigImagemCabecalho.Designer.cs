namespace CashInBox
{
    partial class frmConfigImagemCabecalho
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConfigImagemCabecalho));
            this.ofdImagem = new System.Windows.Forms.OpenFileDialog();
            this.txtCaminhoImagem = new System.Windows.Forms.TextBox();
            this.btnSelecionarImagem = new System.Windows.Forms.Button();
            this.lblImagem = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripCliente = new System.Windows.Forms.ToolStrip();
            this.btnSalvar = new System.Windows.Forms.ToolStripButton();
            this.btnFechar = new System.Windows.Forms.ToolStripButton();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.panImagem = new System.Windows.Forms.Panel();
            this.picImagem = new System.Windows.Forms.PictureBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.toolStripCliente.SuspendLayout();
            this.panImagem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImagem)).BeginInit();
            this.SuspendLayout();
            // 
            // ofdImagem
            // 
            this.ofdImagem.FileName = "cabecalho";
            this.ofdImagem.Filter = "Imagem (*.jpg, *.png) |*.JPG;*.PNG";
            // 
            // txtCaminhoImagem
            // 
            this.txtCaminhoImagem.Location = new System.Drawing.Point(13, 58);
            this.txtCaminhoImagem.Name = "txtCaminhoImagem";
            this.txtCaminhoImagem.ReadOnly = true;
            this.txtCaminhoImagem.Size = new System.Drawing.Size(338, 20);
            this.txtCaminhoImagem.TabIndex = 1;
            this.txtCaminhoImagem.TabStop = false;
            // 
            // btnSelecionarImagem
            // 
            this.btnSelecionarImagem.Location = new System.Drawing.Point(357, 58);
            this.btnSelecionarImagem.Name = "btnSelecionarImagem";
            this.btnSelecionarImagem.Size = new System.Drawing.Size(24, 21);
            this.btnSelecionarImagem.TabIndex = 2;
            this.btnSelecionarImagem.Text = "...";
            this.btnSelecionarImagem.UseVisualStyleBackColor = true;
            this.btnSelecionarImagem.Click += new System.EventHandler(this.btnSelecionarImagem_Click);
            // 
            // lblImagem
            // 
            this.lblImagem.AutoSize = true;
            this.lblImagem.Location = new System.Drawing.Point(12, 39);
            this.lblImagem.Name = "lblImagem";
            this.lblImagem.Size = new System.Drawing.Size(44, 13);
            this.lblImagem.TabIndex = 3;
            this.lblImagem.Text = "Imagem";
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("statusStrip1.BackgroundImage")));
            this.statusStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.statusStrip1.Location = new System.Drawing.Point(0, 367);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(403, 22);
            this.statusStrip1.TabIndex = 210;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripCliente
            // 
            this.toolStripCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.toolStripCliente.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("toolStripCliente.BackgroundImage")));
            this.toolStripCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toolStripCliente.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripCliente.ImageScalingSize = new System.Drawing.Size(48, 48);
            this.toolStripCliente.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSalvar,
            this.btnFechar});
            this.toolStripCliente.Location = new System.Drawing.Point(0, 0);
            this.toolStripCliente.Name = "toolStripCliente";
            this.toolStripCliente.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStripCliente.Size = new System.Drawing.Size(403, 25);
            this.toolStripCliente.TabIndex = 211;
            this.toolStripCliente.Text = "toolStrip1";
            // 
            // btnSalvar
            // 
            this.btnSalvar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnSalvar.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(46, 22);
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnFechar.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnFechar.Image = ((System.Drawing.Image)(resources.GetObject("btnFechar.Image")));
            this.btnFechar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(48, 22);
            this.btnFechar.Text = "Fechar";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(357, 32);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(19, 20);
            this.txtId.TabIndex = 212;
            this.txtId.TabStop = false;
            this.txtId.Visible = false;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(335, 32);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(16, 13);
            this.lblId.TabIndex = 213;
            this.lblId.Text = "Id";
            this.lblId.Visible = false;
            // 
            // panImagem
            // 
            this.panImagem.AutoScroll = true;
            this.panImagem.Controls.Add(this.picImagem);
            this.panImagem.Location = new System.Drawing.Point(43, 127);
            this.panImagem.Name = "panImagem";
            this.panImagem.Size = new System.Drawing.Size(283, 218);
            this.panImagem.TabIndex = 214;
            // 
            // picImagem
            // 
            this.picImagem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picImagem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picImagem.Location = new System.Drawing.Point(0, 0);
            this.picImagem.Name = "picImagem";
            this.picImagem.Size = new System.Drawing.Size(283, 218);
            this.picImagem.TabIndex = 1;
            this.picImagem.TabStop = false;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(40, 99);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(267, 13);
            this.lblInfo.TabIndex = 215;
            this.lblInfo.Text = "Imagem deve conter no máximo 120px de comprimento";
            // 
            // frmConfigImagemCabecalho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(403, 389);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.panImagem);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.toolStripCliente);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.lblImagem);
            this.Controls.Add(this.btnSelecionarImagem);
            this.Controls.Add(this.txtCaminhoImagem);
            this.Name = "frmConfigImagemCabecalho";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuração de imagem para cabeçalho";
            this.Load += new System.EventHandler(this.frmConfigImagemCabecalho_Load);
            this.toolStripCliente.ResumeLayout(false);
            this.toolStripCliente.PerformLayout();
            this.panImagem.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picImagem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog ofdImagem;
        private System.Windows.Forms.TextBox txtCaminhoImagem;
        private System.Windows.Forms.Button btnSelecionarImagem;
        private System.Windows.Forms.Label lblImagem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        public System.Windows.Forms.ToolStrip toolStripCliente;
        public System.Windows.Forms.ToolStripButton btnSalvar;
        public System.Windows.Forms.ToolStripButton btnFechar;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Panel panImagem;
        private System.Windows.Forms.PictureBox picImagem;
        private System.Windows.Forms.Label lblInfo;
    }
}