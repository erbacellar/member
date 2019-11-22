using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace CashInBox
{
    public partial class frmConfigImagemCabecalho : Form
    {
        long tamanhoArquivoImagem;
        byte[] vetorImagens;

        public frmConfigImagemCabecalho()
        {
            InitializeComponent();
        }

        private void frmConfigImagemCabecalho_Load(object sender, EventArgs e)
        {
            Cabecalho cab = CabecalhoDAO.ObterPrimeiroCabecalho();

            if (cab != null)
            {

                vetorImagens = cab.Imagem;
                string strNomeArquivo = Convert.ToString(DateTime.Now.ToFileTime());
                FileStream fs = new FileStream(strNomeArquivo, FileMode.CreateNew, FileAccess.Write);
                fs.Write(vetorImagens, 0, vetorImagens.Length);
                fs.Flush();
                fs.Close();

                picImagem.BackgroundImage = Image.FromFile(strNomeArquivo);
                txtId.Text = cab.Id.ToString();
            }
        }

        protected void CarregaImagem()
        {
            
            try
            {
                this.ofdImagem.ShowDialog(this);
                string strFn = this.ofdImagem.FileName;
                txtCaminhoImagem.Text = strFn;

                if (string.IsNullOrEmpty(strFn))
                    return;

                this.picImagem.BackgroundImage = Image.FromFile(strFn);
                FileInfo arqImagem = new FileInfo(strFn);
                tamanhoArquivoImagem = arqImagem.Length;
                FileStream fs = new FileStream(strFn, FileMode.Open, FileAccess.Read, FileShare.Read);
                vetorImagens = new byte[Convert.ToInt32(this.tamanhoArquivoImagem)];
                int iBytesRead = fs.Read(vetorImagens, 0, Convert.ToInt32(this.tamanhoArquivoImagem));
                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSelecionarImagem_Click(object sender, EventArgs e)
        {
            CarregaImagem();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Cabecalho cab = new Cabecalho();

            if (!string.IsNullOrEmpty(txtId.Text))
            {
                cab.Id = int.Parse(txtId.Text);
            }
            else
            {
                cab.Id = 0;
            }

            if (cab.Id == 0)
            {
                cab.Imagem = vetorImagens;

                if (CabecalhoDAO.Incluir(cab))
                {
                    Mensagens.mensagemINFO_INCLUIR();
                }
                else
                {
                    Mensagens.mensagemERRO_INCLUIR();
                }
            }
            else
            {
                cab = CabecalhoDAO.ProcurarPorId(cab.Id);
                cab.Imagem = vetorImagens;

                if (CabecalhoDAO.Alterar(cab))
                {
                    Mensagens.mensagemINFO_ALTERAR();
                }
                else
                {
                    Mensagens.mensagemERRO_ALTERAR();
                }
            }
        }
    }
}
