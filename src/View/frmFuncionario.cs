using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

namespace CashInBox
{
    public partial class frmFuncionario : Form
    {
        Usuario usuario = new Usuario();

        public frmFuncionario(String Login)
        {
            InitializeComponent();

            if (!Login.Equals("admin"))
            {
                usuario = UsuarioDAO.ProcurarUsuarioPorLogin(Login);
            }
            else
            {
                usuario.Login = "admin";
            }
        }

        public void EsconderErros()
        {
            //erroBairro.Visible = false;
            //erroCidade.Visible = false;
            //erroCpf.Visible = false;
            //erroEndereco.Visible = false;
            //erroEstado.Visible = false;
            //erroGridEmail.Visible = false;
            //erroGridTelefone.Visible = false;
            //erroNomeFuncionario.Visible = false;
            //erroNumCep.Visible = false;
            //erroNumEnd.Visible = false;
            //erroRgIE.Visible = false;
        }

        private void frmFuncionario_Load(object sender, EventArgs e)
        {
            if (!usuario.Login.Equals("admin"))
            {
                VerificarAcesso.Verificar(this, usuario.Id);
            }
            
            EstadoInicial();

            foreach (String x in Utils.recuperarListaEstados())
            {
                cboEstados.Items.Add(x);
            }

            foreach (String x in Utils.recuperarListaTiposTel())
            {
                cboFone.Items.Add(x);
            }

            foreach (String x in Utils.recuperarListaStatus())
            {
                cboStatus.Items.Add(x);
            }
        }

        public void EstadoInicial()
        {
            EsconderErros();
            Utils.Desabilitar(this);
            Utils.LimparCampos(this);
            btnNovo.Enabled = true;
            btnSalvar.Enabled = false;
            btnEditar.Enabled = false;
            btnConsultar.Enabled = true;
        }

        private void PonteiroInicialMascara(object sender, EventArgs e)
        {
            Utils.PonteiroInicialMascara(sender);
        }

        private void mskTelefone_Leave(object sender, EventArgs e)
        {
            Utils.FocusOutTextMask(sender);

            if (!mskTelefone.Text.Equals(""))
            {
                if (!ValidaTelefone.IsTel(mskTelefone.Text))
                {
                    MessageBox.Show("Telefone deve conter no mínimo 10 e no máximo 11 números");
                    mskTelefone.Clear();
                }
            }
        }

        private void FocusInTextMask(object sender, EventArgs e)
        {
            Utils.FocusInTextMask(sender);
        }

        private void FocusOutTextMask(object sender, EventArgs e)
        {
            Utils.FocusOutTextMask(sender);
        }

        private void FocusInCombo(object sender, EventArgs e)
        {
            Utils.FocusInCombo(sender);
        }

        private void FocusOutCombo(object sender, EventArgs e)
        {
            Utils.FocusOutCombo(sender);
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            FocusOutTextMask(sender, e);

            if (!txtEmail.Text.Equals(""))
            {
                if (!ValidaEmail.IsEmail(txtEmail.Text))
                {
                    Mensagens.mensagemALERTA("Email inválido! Verifique e tente novamente");
                    txtEmail.Clear();
                }
            }
        }

        private void btnAdicionarTel_Click(object sender, EventArgs e)
        {
            bool tem = false;

            if (!mskTelefone.Text.Equals("") && cboFone.SelectedIndex != -1)
            {
                for (int i = 0; i < grdTelefones.Rows.Count; i++)
                {
                    if (grdTelefones.Rows[i].Cells[0].Value.ToString().Equals(mskTelefone.Text))
                    {
                        tem = true;
                        break;
                    }
                }

                if (tem)
                {
                    Mensagens.mensagemALERTA("Esse número já foi incluído");
                }
                else
                {
                    grdTelefones.Rows.Add(mskTelefone.Text, cboFone.SelectedItem.ToString());
                }

                mskTelefone.Clear();
                cboFone.SelectedIndex = -1;
            }
            else
            {
                Mensagens.mensagemALERTA("Para inserir um telefone informe o número e o seu tipo");
            }
        }

        private void btnRemoverTel_Click(object sender, EventArgs e)
        {
            try
            {
                grdTelefones.Rows.RemoveAt(grdTelefones.CurrentRow.Index);
            }
            catch
            {
                Mensagens.mensagemALERTA("Selecione uma linha com um telefone para poder excluir");
            }
        }

        private void mskCPF_Leave(object sender, EventArgs e)
        {
            FocusOutTextMask(sender, e);

            if (!mskCPF.Text.Equals(""))
            {
                if (!ValidaCpf.IsCpf(mskCPF.Text))
                {
                    Mensagens.mensagemALERTA("Cpf inválido! Informe um número válido");
                    mskCPF.Clear();
                }
            }
        }


        private void btNovo_Click(object sender, EventArgs e)
        {
            Utils.LimparCampos(this);
            Utils.Habilitar(this);
            btnSalvar.Enabled = true;
            btnEditar.Enabled = false;
        }

        public String ValidarCamposObrigatorios()
        {
            String erros = null;

            //if (txtFuncionario.Text.Equals(""))
            //{
            //    erros += "Campo nome do Funcionario deve ser preenchido\n";
            //    erroNomeFuncionario.Visible = true;
            //}
            //else
            //{
            //    erroNomeFuncionario.Visible = false;
            //}

            //if (mskCep.Text.Equals(""))
            //{
            //    erros += "Campo número do cep deve ser preenchido\n";
            //    erroNumCep.Visible = true;
            //}
            //else
            //{
            //    erroNumCep.Visible = false;
            //}

            //if (txtEndereco.Text.Equals(""))
            //{
            //    erros += "Campo endereço deve ser preenchido\n";
            //    erroEndereco.Visible = true;
            //}
            //else
            //{
            //    erroEndereco.Visible = false;
            //}

            //if (txtNumEnd.Text.Equals(""))
            //{
            //    erros += "Campo número do endereço deve ser preenchido\n";
            //    erroNumEnd.Visible = true;
            //}
            //else
            //{
            //    erroNumEnd.Visible = false;
            //}

            //if (txtBairro.Text.Equals(""))
            //{
            //    erros += "Campo bairro deve ser preenchido\n";
            //    erroBairro.Visible = true;
            //}
            //else
            //{
            //    erroBairro.Visible = false;
            //}

            //if (txtCidade.Text.Equals(""))
            //{
            //    erros += "Campo cidade deve ser preenchido\n";
            //    erroCidade.Visible = true;
            //}
            //else
            //{
            //    erroCidade.Visible = false;
            //}

            //if (cboEstados.SelectedIndex == -1)
            //{
            //    erros += "Campo UF deve ser selecionado\n";
            //    erroEstado.Visible = true;
            //}
            //else
            //{
            //    erroEstado.Visible = false;
            //}

            //if (grdTelefones.Rows.Count <= 0)
            //{
            //    erros += "Um telefone ao menos deve ser incluído\n";
            //    erroGridTelefone.Visible = true;
            //}
            //else
            //{
            //    erroGridTelefone.Visible = false;
            //}

            //if (grdEmails.Rows.Count <= 1)
            //{
            //    erros += "Um email ao menos deve ser incluído\n";
            //    erroGridEmail.Visible = true;
            //}
            //else
            //{
            //    erroGridEmail.Visible = false;
            //}

            //if (mskCPF.Text.Equals(""))
            //{
            //    erros += "Campo CPF devem ser preenchidos\n";
            //    erroCpf.Visible = true;
            //}
            //else
            //{
            //    erroCpf.Visible = false;
            //}

            //if (txtRg.Text.Equals(""))
            //{
            //    erros += "Campo RG deve ser preenchido\n";
            //    erroRgIE.Visible = true;
            //}
            //else
            //{
            //    erroRgIE.Visible = false;
            //}

            return erros;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            String erros = null;
            String tipoSalvar = null;
            Funcionario func = new Funcionario();

            if (txtCodigo.Text.Equals(""))
            {
                func.Id = 0;
            }
            else
            {
                func.Id = int.Parse(txtCodigo.Text);
            }
            if (ValidarCamposObrigatorios() == null)
            {
                /*
                 * If para inclusão de um Funcionario
                 */
                if (func.Id == 0)
                {
                    if (FuncionarioDAO.ProcurarFuncionarioPorCpf(mskCPF.Text) == null)
                    {
                        tipoSalvar = "i";
                        IncluirAtualizarCadastro(tipoSalvar, func.Id);
                    }
                    else
                    {
                            Mensagens.mensagemALERTA("Funcionario já cadastrado com este CPF!");
                    }
                }
                /*
                 * Else para alteração de um Funcionario
                 */
                else
                {
                    tipoSalvar = "a";
                    IncluirAtualizarCadastro(tipoSalvar, func.Id);
                }
            }
            else
            {
                erros = ValidarCamposObrigatorios();
                Mensagens.mensagemCamposObrigatorios();
            }

        }

        public void IncluirAtualizarCadastro(String x, int id)
        {
            Funcionario func = new Funcionario();

            func.Id = id;
            if (x.Equals("a"))
            {
                func = FuncionarioDAO.ProcurarFuncionarioPorId(func);
            }
            func.DataCadastro = dtpData.Value;

            func.Nome = txtFuncionario.Text;

                func.Cpf = mskCPF.Text;

            func.Nome = txtFuncionario.Text;

            func.Cep = mskCep.Text;
            func.Logradouro = txtEndereco.Text;
            func.NumeroEnd = txtNumEnd.Text;
            func.Bairro = txtBairro.Text;
            func.Cidade = txtCidade.Text;
            func.Estado = cboEstados.SelectedItem.ToString();

            List<TelefoneFuncionario> telefones = new List<TelefoneFuncionario>();
            for (int i = 0; i < grdTelefones.Rows.Count; i++)
            {
                TelefoneFuncionario tel = new TelefoneFuncionario();
                tel.NumTel = grdTelefones.Rows[i].Cells[0].Value.ToString();
                tel.TipoTel = grdTelefones.Rows[i].Cells[1].Value.ToString();

                telefones.Add(tel);
            }

            func.Telefones = telefones;

            func.Email = txtEmail.Text;

            func.Rg = txtRg.Text;

            if (cboStatus.SelectedIndex != -1)
            {
                func.Status = cboStatus.SelectedItem.ToString();
            }

            func.Observacao = txtObservacao.Text;

            if (x.Equals("i"))
            {
                if (FuncionarioDAO.Incluir(func))
                {
                    Mensagens.mensagemINFO_INCLUIR();
                    if (Mensagens.mensagemPERGUNTA_INCLUIR())
                    {
                        Utils.LimparCampos(this);
                        txtFuncionario.Focus();
                    }
                    else
                    {
                        EstadoInicial();
                    }
                }
                else
                {
                    Mensagens.mensagemERRO_INCLUIR();
                }
            }
            if (x.Equals("a"))
            {
                if (FuncionarioDAO.Alterar(func))
                {
                    Mensagens.mensagemINFO_ALTERAR();
                    EstadoInicial();
                }
                else
                {
                    Mensagens.mensagemERRO_ALTERAR();
                }
            }
        }

        

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Utils.Habilitar(this);
            btnSalvar.Enabled = true;
        }

        private void BtBusca_Click(object sender, EventArgs e)
        {
            frmConsultarCep f = new frmConsultarCep(this);
            f.ShowDialog();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            frmConsultarFuncionario f = new frmConsultarFuncionario(this);
            f.ShowDialog();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void FocuInButton(object sender, EventArgs e)
        {
            KryptonButton b = sender as KryptonButton;
            b.Focus();
        }

    }
}
