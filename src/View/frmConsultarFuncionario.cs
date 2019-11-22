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
    public partial class frmConsultarFuncionario : Form
    {
        frmFuncionario formFuncionario = null;

        public frmConsultarFuncionario(Form f)
        {
            InitializeComponent();

            if (f.Name.Equals("frmFuncionario"))
            {
                formFuncionario = (frmFuncionario)f;
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            grdCFuncionario.Rows.Clear();

            if (txtCFuncionario.Text.Equals(""))
            {
                foreach (Funcionario x in FuncionarioDAO.ObterFuncionarios())
                {
                    grdCFuncionario.Rows.Add(x.Id, x.Cpf, x.Rg, x.Nome);
                }
            }
            else
            {
                Funcionario funcConsulta = new Funcionario();
                funcConsulta.Nome = txtCFuncionario.Text;
                funcConsulta.Cpf = txtCFuncionario.Text;

                foreach (Funcionario x in FuncionarioDAO.ObterFuncionariosPorLetraParcial(funcConsulta))
                {
                    grdCFuncionario.Rows.Add(x.Id, x.Cpf, x.Rg, x.Nome);
                }
            }

            Utils.InformarConsultaVazia(grdCFuncionario);
        }

        private void grdCFuncionario_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (formFuncionario != null)
            {
                try
                {
                    Utils.LimparCampos(formFuncionario);

                    Funcionario func = new Funcionario();
                    func.Id = int.Parse(grdCFuncionario.CurrentRow.Cells[0].Value.ToString());
                    func = FuncionarioDAO.ProcurarFuncionarioPorId(func);

                    formFuncionario.txtCodigo.Text = func.Id.ToString();
                    formFuncionario.dtpData.Value = func.DataCadastro;
                    formFuncionario.txtFuncionario.Text = func.Nome;
                    formFuncionario.mskCep.Text = func.Cep;
                    formFuncionario.txtEndereco.Text = func.Logradouro;
                    formFuncionario.txtNumEnd.Text = func.NumeroEnd;
                    formFuncionario.txtBairro.Text = func.Bairro;
                    formFuncionario.txtCidade.Text = func.Cidade;
                    formFuncionario.cboEstados.SelectedItem = func.Estado;

                    foreach (TelefoneFuncionario x in func.Telefones)
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
                    formFuncionario.EsconderErros();

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
