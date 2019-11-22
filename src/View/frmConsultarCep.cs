using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CashInBox
{
    public partial class frmConsultarCep : Form
    {

        frmFuncionario formFuncionario = null;
        frmMembro formMembro = null;

        string numCep;

        public frmConsultarCep(Form f)
        {
            InitializeComponent();

            if (f.Name.Equals("frmFuncionario"))
            {
                formFuncionario = (frmFuncionario)f;
            }
            if (f.Name.Equals("frmMembro"))
            {
                formMembro = (frmMembro)f;
            }
        }

        public frmConsultarCep(Form f, string numCepPARAM)
        {
            InitializeComponent();

            if (f.Name.Equals("frmFuncionario"))
            {
                formFuncionario = (frmFuncionario)f;
            }
            if (f.Name.Equals("frmMembro"))
            {
                formMembro = (frmMembro)f;
            }

            object sender = new object();
            EventArgs e = new EventArgs();

            mskCep.Text = numCepPARAM;
            btnPesquisar_Click(sender, e);
            
        }

        private void mskCep_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Utils.PressionarEnterCampoTexto(sender, e))
            {
                btnPesquisar_Click(sender, e);
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            grdConsultaCepFormatado.Rows.Clear();
            grdConsultaCepSemFormatacao.Rows.Clear();
            
            string xml = "http://cep.republicavirtual.com.br/web_cep.php?cep=@cep&formato=xml"
            .Replace("@cep", mskCep.Text);
            DataSet ds = new DataSet();
            ds.ReadXml(xml);
            grdConsultaCepSemFormatacao.DataSource = ds.Tables[0];

            lblQtdNumResult.Text = grdConsultaCepSemFormatacao.Rows[0].Cells[0].Value.ToString();
            lblResultadoTxt.Text = "Descrição: " + grdConsultaCepSemFormatacao.Rows[0].Cells[1].Value.ToString();

            if (int.Parse(lblQtdNumResult.Text) != 0)
            {
                for (int i = 0; i < grdConsultaCepSemFormatacao.Rows.Count - 1; i++)
                {
                    String numcep = mskCep.Text;
                    String endereco = grdConsultaCepSemFormatacao.Rows[i].Cells[5].Value.ToString() +" "+ grdConsultaCepSemFormatacao.Rows[i].Cells[6].Value.ToString();
                    String bairro = grdConsultaCepSemFormatacao.Rows[i].Cells[4].Value.ToString();
                    String cidade = grdConsultaCepSemFormatacao.Rows[i].Cells[3].Value.ToString();
                    String uf = grdConsultaCepSemFormatacao.Rows[i].Cells[2].Value.ToString();

                    grdConsultaCepFormatado.Rows.Add(numcep, endereco, bairro, cidade, uf);
                }
            }
        }

        private void grdConsultaCepFormatado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (formFuncionario != null)
            {
                try
                {
                    String numcep = grdConsultaCepFormatado.CurrentRow.Cells[0].Value.ToString();
                    String endereco = grdConsultaCepFormatado.CurrentRow.Cells[1].Value.ToString();
                    String bairro = grdConsultaCepFormatado.CurrentRow.Cells[2].Value.ToString();
                    String cidade = grdConsultaCepFormatado.CurrentRow.Cells[3].Value.ToString();
                    String uf = grdConsultaCepFormatado.CurrentRow.Cells[4].Value.ToString();

                    formFuncionario.mskCep.Text = numcep;
                    formFuncionario.txtEndereco.Text = endereco;
                    formFuncionario.txtBairro.Text = bairro;
                    formFuncionario.txtCidade.Text = cidade;
                    formFuncionario.cboEstados.SelectedItem = uf;

                    Close();
                }
                catch (Exception exc)
                {
                    Mensagens.mensagemERRO(exc.Message);
                }
            }
            
        }

        private void mskCep_Click(object sender, EventArgs e)
        {
            Utils.PonteiroInicialMascara(sender);
        }

        private void frmConsultarCep_Load(object sender, EventArgs e)
        {

        }

        private void btnPesquisar_MouseEnter(object sender, EventArgs e)
        {
            btnPesquisar.Focus();
        }

    }
}
