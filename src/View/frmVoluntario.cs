using CashInBox.Controller;
using CashInBox.Enums;
using CashInBox.Extensions;
using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CashInBox
{
    public partial class frmVoluntario : Form
    {
        Usuario usuario = new Usuario();

        public frmVoluntario(String Login)
        {
            InitializeComponent();
            usuario.Login = "admin";
        }

        private void frmFuncionario_Load(object sender, EventArgs e)
        {
            EstadoInicial();

            foreach (String x in Utils.recuperarListaEstados())
                cboEstados.Items.Add(x);

            foreach (String x in Utils.recuperarListaTiposTel())
                cboFone.Items.Add(x);

            foreach (String x in Utils.recuperarListaStatus())
                cboStatus.Items.Add(x);
        }

        public void EstadoInicial()
        {
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


        private async void btNovo_Click(object sender, EventArgs e)
        {
            Utils.LimparCampos(this);
            Utils.Habilitar(this);
            btnSalvar.Enabled = true;
            btnEditar.Enabled = false;

            var ultimoId = await VoluntarioDAO.UltimoId();
            txtCodigo.Text = ultimoId.ToString();

            cboStatus.SelectedItem = EnumHelper.GetDescription(StatusType.ATIVO).ToUpper();
        }

        private async void btnSalvar_Click(object sender, EventArgs e)
        {
            Voluntario func = new Voluntario();

            func.Key = txtKey.Text;

            if (string.IsNullOrEmpty(func.Key))
            {
                var voluntarioJaExistente = await VoluntarioDAO.ObterPorNome(txtVoluntario.Text);
                if (voluntarioJaExistente == null)
                {
                    await SalvarDados(SaveType.INCLUIR);
                }
                else
                {
                    Mensagens.mensagemALERTA("Voluntario já cadastrado com este Nome!");
                }
            }
            else
                await SalvarDados(SaveType.ALTERAR);

        }

        public async Task SalvarDados(SaveType saveType)
        {
            Voluntario voluntario = PreencherDadosVoluntario();

            if (saveType == SaveType.INCLUIR)
            {
                if (await VoluntarioDAO.Incluir(voluntario))
                {
                    Mensagens.mensagemINFO_INCLUIR();
                    if (Mensagens.mensagemPERGUNTA_INCLUIR())
                    {
                        Utils.LimparCampos(this);
                        txtVoluntario.Focus();
                    }
                    else
                        EstadoInicial();
                }
                else
                {
                    Mensagens.mensagemERRO_INCLUIR();
                }
            }
            else
            {
                if (await VoluntarioDAO.Alterar(voluntario))
                {
                    Mensagens.mensagemINFO_ALTERAR();
                    EstadoInicial();
                }
                else
                    Mensagens.mensagemERRO_ALTERAR();
            }
        }

        private Voluntario PreencherDadosVoluntario()
        {
            Voluntario voluntario = new Voluntario();
            voluntario.Key = txtKey.Text;
            voluntario.DataCadastro = dtpData.Value;
            voluntario.Nome = txtVoluntario.Text;

            voluntario.Cpf = mskCPF.Text;

            voluntario.Nome = txtVoluntario.Text;

            voluntario.Cep = mskCep.Text;
            voluntario.Logradouro = txtEndereco.Text;
            voluntario.NumeroEnd = txtNumEnd.Text;
            voluntario.Bairro = txtBairro.Text;
            voluntario.Cidade = txtCidade.Text;
            voluntario.Estado = cboEstados.SelectedItem.ToString();

            List<Telefone> telefones = new List<Telefone>();
            for (int i = 0; i < grdTelefones.Rows.Count; i++)
            {
                Telefone tel = new Telefone();
                tel.NumTel = grdTelefones.Rows[i].Cells[0].Value.ToString();
                tel.TipoTel = grdTelefones.Rows[i].Cells[1].Value.ToString();

                telefones.Add(tel);
            }

            voluntario.Telefones = telefones;

            voluntario.Email = txtEmail.Text;

            voluntario.Rg = txtRg.Text;

            if (cboStatus.SelectedIndex != -1)
            {
                voluntario.Status = cboStatus.SelectedItem.ToString();
            }

            voluntario.Observacao = txtObservacao.Text;

            return voluntario;
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

        private async void MskCep_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(mskCep.Text))
            {
                var endereco = await CepService.EnderecoPorCep(Utils.RemoveCaracteresEspeciais(mskCep.Text, false, false));
                if (endereco != null && !string.IsNullOrEmpty(endereco.Uf))
                {
                    txtEndereco.Text = endereco.Logradouro;
                    txtBairro.Text = endereco.Bairro;
                    txtCidade.Text = endereco.Localidade;
                    cboEstados.SelectedItem = endereco.Uf;
                }
            }
        }
    }
}
