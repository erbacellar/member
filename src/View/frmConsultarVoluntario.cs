using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CashInBox
{
    public partial class frmConsultarFuncionario : Form
    {
        frmVoluntario formFuncionario = null;

        public frmConsultarFuncionario(Form f)
        {
            InitializeComponent();

            if (f.Name.Equals("frmFuncionario"))
            {
                formFuncionario = (frmVoluntario)f;
            }
        }

        private async void btnPesquisar_Click(object sender, EventArgs e)
        {
            grdCFuncionario.Rows.Clear();
            List<Voluntario> voluntarios;

            if (!string.IsNullOrEmpty(txtCFuncionario.Text))
            {
                Voluntario voluntario = new Voluntario();
                voluntario.Nome = txtCFuncionario.Text;
                voluntario.Cpf = txtCFuncionario.Text;
                voluntarios = await VoluntarioDAO.ObterPorNomeOuCpf(voluntario);
            }
            else
                voluntarios = await VoluntarioDAO.Listar();

            foreach (Voluntario voluntario in voluntarios)
            {
                grdCFuncionario.Rows.Add(voluntario.Key, voluntario.Cpf, voluntario.Rg, voluntario.Nome);
            }

            Utils.InformarConsultaVazia(grdCFuncionario);
        }

        private async void grdCFuncionario_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (formFuncionario != null)
            {
                try
                {
                    Utils.LimparCampos(formFuncionario);

                    Voluntario func = new Voluntario();
                    var key = grdCFuncionario.CurrentRow.Cells[0].Value.ToString();
                    func = await VoluntarioDAO.ObterPorKey(key);

                    formFuncionario.txtCodigo.Text = func.Id.ToString();
                    formFuncionario.txtKey.Text = func.Key;
                    formFuncionario.dtpData.Value = func.DataCadastro;
                    formFuncionario.txtVoluntario.Text = func.Nome;
                    formFuncionario.mskCep.Text = func.Cep;
                    formFuncionario.txtEndereco.Text = func.Logradouro;
                    formFuncionario.txtNumEnd.Text = func.NumeroEnd;
                    formFuncionario.txtBairro.Text = func.Bairro;
                    formFuncionario.txtCidade.Text = func.Cidade;
                    formFuncionario.cboEstados.SelectedItem = func.Estado;

                    foreach (Telefone x in func.Telefones)
                    {
                        formFuncionario.grdTelefones.Rows.Add(x.NumTel, x.TipoTel);
                    }

                    formFuncionario.txtEmail.Text = func.Email;

                    formFuncionario.mskCPF.Text = func.Cpf;
                    formFuncionario.txtRg.Text = func.Rg;
                    formFuncionario.cboStatus.SelectedItem = func.Status;
                    formFuncionario.txtObservacao.Text = func.Observacao;

                    Utils.Desabilitar(this);
                    formFuncionario.btnNovo.Enabled = true;
                    formFuncionario.btnEditar.Enabled = true;
                    formFuncionario.btnSalvar.Enabled = false;
                    formFuncionario.btnConsultar.Enabled = true;

                    Close();

                }
                catch
                {
                    Mensagens.mensagemALERTA("Selecione uma linha com dados");
                }
            }
        }

        private void txtCFuncionario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Utils.PressionarEnterCampoTexto(sender, e))
            {
                btnPesquisar_Click(sender, e);
            }
        }

        private void btnPesquisar_MouseEnter(object sender, EventArgs e)
        {
            btnPesquisar.Focus();
        }
    }
}
