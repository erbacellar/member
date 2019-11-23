using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CashInBox.Controller;
using ComponentFactory.Krypton.Toolkit;
using Microsoft.VisualBasic.PowerPacks;

namespace CashInBox
{
    public partial class frmMembro : Form
    {
        Usuario usuario = new Usuario();
        public List<Membro> membros;
        public int IndexAtual;
        public int IndexFinal;
        Membro membroConsult;
        public bool back = false;
        public bool next = false;

        RectangleShape erroNome = new RectangleShape();
        RectangleShape erroCpf = new RectangleShape();
        RectangleShape erroNumCep = new RectangleShape();
        RectangleShape erroEndereco = new RectangleShape();
        RectangleShape erroBairro = new RectangleShape();
        RectangleShape erroCidade = new RectangleShape();
        RectangleShape erroEstado = new RectangleShape();
        RectangleShape erroNumEnd = new RectangleShape();
        public frmMembro(String Login)
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
            erroNome.Visible = false;
            erroCpf.Visible = false;
            erroBairro.Visible = false;
            erroCidade.Visible = false;
            erroEndereco.Visible = false;
            erroEstado.Visible = false;
            erroNumCep.Visible = false;
            erroNumEnd.Visible = false;
        }

        private void frmMembro_Load(object sender, EventArgs e)
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

            foreach (String x in Utils.recuperarDiasSemana())
            {
                cboGrupoDia.Items.Add(x);
            }

            foreach (String x in Utils.recuperarHorarios())
            {
                cboGrupoHorario.Items.Add(x);
            }

            foreach (String x in Utils.recuperarStatus())
            {
                cboStatus.Items.Add(x);
            }
            foreach (String x in Utils.recuperarIsento())
            {
                cboIsento.Items.Add(x);
            }

            btnNextMembro.Visible = false;
            btnBackMembro.Visible = false;

            createRectangles(txtNome);
            createRectangles(mskCep);
            createRectangles(txtEndereco);
            createRectangles(txtCidade);
            createRectangles(cboEstados);
            createRectangles(txtBairro);
            createRectangles(txtNumEnd);
            createRectangles(mskCPF);
        }

        public void EstadoInicial()
        {
            EsconderErros();
            Utils.Desabilitar(this);
            Utils.LimparCampos(this);
            btnNovo.Enabled = true;
            btnConsultar.Enabled = true;
            btnSalvar.Enabled = false;
            btnEditar.Enabled = false;
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

        private bool ConverteParaInt(object sender, EventArgs e)
        {
            if (Utils.ConverterParaInt(sender))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool ConverteParaFloat(object sender, EventArgs e)
        {
            if (Utils.ConverterParaFloat(sender))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void FocusOutEConverterParaFloat(object sender, EventArgs e)
        {
            FocusOutTextMask(sender, e);
            TextBox t = sender as TextBox;

            if (!t.Text.Equals(""))
            {
                if (!ConverteParaFloat(sender, e))
                {
                    Mensagens.mensagemALERTA("Informe apenas números");
                }
            }
        }

        private void FocusOutEConverterParaInt(object sender, EventArgs e)
        {
            FocusOutTextMask(sender, e);
            TextBox t = sender as TextBox;

            if (!t.Text.Equals(""))
            {
                if (!ConverteParaInt(sender, e))
                {
                    Mensagens.mensagemALERTA("Informe apenas números");
                }
            }
        }

        private async void btNovo_Click(object sender, EventArgs e)
        {
            Utils.LimparCampos(this);
            Utils.Habilitar(this);
            btnSalvar.Enabled = true;
            btnEditar.Enabled = false;
            cboIsento.SelectedIndex = 1;
            mskDataIsentoIni.Enabled = false;
            mskDataIsentoFin.Enabled = false;
            cboStatus.SelectedIndex = 0;

            var lastId = await MembroDAO.ObterUltimoMembroId();
            if (lastId.HasValue)
            {
                txtNum.Text = "" + (lastId.Value + 1);
            }
            else
            {
                txtNum.Text = "1";
            }
        }

        public String ValidarCamposObrigatorios()
        {
            String erros = null;

            if (txtNome.Text.Equals(""))
            {
                erros += "Campo nome do Membro deve ser preenchido\n";

                erroNome.Visible = true;
            }
            else
            {
                erroNome.Visible = false;
            }

            if (mskCep.Text.Equals(""))
            {
                erros += "Campo número do cep deve ser preenchido\n";
                erroNumCep.Visible = true;
            }
            else
            {
                erroNumCep.Visible = false;
            }

            if (txtEndereco.Text.Equals(""))
            {
                erros += "Campo endereço deve ser preenchido\n";
                erroEndereco.Visible = true;
            }
            else
            {
                erroEndereco.Visible = false;
            }

            if (txtNumEnd.Text.Equals(""))
            {
                erros += "Campo número do endereço deve ser preenchido\n";
                erroNumEnd.Visible = true;
            }
            else
            {
                erroNumEnd.Visible = false;
            }

            if (txtBairro.Text.Equals(""))
            {
                erros += "Campo bairro deve ser preenchido\n";
                erroBairro.Visible = true;
            }
            else
            {
                erroBairro.Visible = false;
            }

            if (txtCidade.Text.Equals(""))
            {
                erros += "Campo cidade deve ser preenchido\n";
                erroCidade.Visible = true;
            }
            else
            {
                erroCidade.Visible = false;
            }

            if (cboEstados.SelectedIndex == -1)
            {
                erros += "Campo UF deve ser selecionado\n";
                erroEstado.Visible = true;
            }
            else
            {
                erroEstado.Visible = false;
            }

            if (mskCPF.Text.Equals(""))
            {
                erros += "Campo CPF deve ser preenchido";
                erroCpf.Visible = true;
            }
            else
            {
                erroCpf.Visible = false;
            }

            return erros;
        }

        private async void btnSalvar_Click(object sender, EventArgs e)
        {
            String erros = null;
            String tipoSalvar = null;
            Membro membro = new Membro();
            membro.Key = txtKey.Text;
            if (txtCodigo.Text.Equals(""))
            {
                membro.Id = 0;
            }
            else
            {
                membro.Id = int.Parse(txtCodigo.Text);
            }
            if (ValidarCamposObrigatorios() == null)
            {
                /*
                 * If para inclusão de um Membro
                 */
                if (membro.Id == 0)
                {

                    membro.Cpf = mskCPF.Text;
                    var membroJaExiste = await MembroDAO.ProcurarMembroPorCpf(membro);
                    if (membroJaExiste == null)
                    {
                        tipoSalvar = "i";
                        IncluirAtualizarCadastro(tipoSalvar, membro.Key);
                    }
                    else
                    {
                        Mensagens.mensagemALERTA("Membro já cadastrado com este CPF!");
                    }
                }
                /*
                 * Else para alteração de um Membro
                 */
                else
                {
                    tipoSalvar = "a";
                    IncluirAtualizarCadastro(tipoSalvar, membro.Key);
                }
            }
            else
            {
                erros = ValidarCamposObrigatorios();
                Mensagens.mensagemCamposObrigatorios();
            }

        }

        public async void IncluirAtualizarCadastro(String x, string key)
        {
            Membro member = new Membro();

            member.Key = key;
            if (x.Equals("a"))
            {
                member = await MembroDAO.Obter(key);
            }
            member.DataEntrada = dtpDataEntrada.Value;
            member.DataSaida = dtpDataSaida.Value;
            member.DataNascimento = dtpDataNascimento.Value;
            member.Numero = txtNum.Text;

            member.Status = cboStatus.SelectedItem.ToString();

            if (cboIsento.SelectedItem.ToString().Equals("Sim"))
            {
                member.Isento = true;
                member.DataIsentoIni = mskDataIsentoIni.Text;
                member.DataIsentoFin = mskDataIsentoFin.Text;
            }
            else
            {
                member.Isento = false;
                member.DataIsentoIni = "";
                member.DataIsentoFin = "";
            }


            member.Nome = txtNome.Text;

            member.Cpf = mskCPF.Text;

            member.Cep = mskCep.Text;
            member.Logradouro = txtEndereco.Text;
            member.NumEnd = txtNumEnd.Text;
            member.Bairro = txtBairro.Text;
            member.Complemento = txtComplemento.Text;
            member.Cidade = txtCidade.Text;

            if (cboEstados.SelectedIndex != -1)
                member.Estado = cboEstados.SelectedItem.ToString();

            if (cboGrupoDia.SelectedIndex != -1)
                member.GrupoDia = cboGrupoDia.SelectedItem.ToString();

            if (cboGrupoHorario.SelectedIndex != -1)
                member.GrupoHorario = cboGrupoHorario.SelectedItem.ToString();

            member.Telefone1 = mskTelefone.Text;
            member.Telefone2 = mskTelefone2.Text;
            member.Telefone3 = mskTelefone3.Text;
            member.Telefone4 = mskTelefone4.Text;

            member.Email = txtEmail.Text;
            member.GrauInstrucao = txtGrauInstrucao.Text;
            member.Profissao = txtProfissao.Text;
            member.Rg = txtRg.Text;

            setarValoresQuestionario(member);

            if (x.Equals("i"))
            {
                if (await MembroDAO.Incluir(member))
                {
                    Mensagens.mensagemINFO_INCLUIR();
                    if (Mensagens.mensagemPERGUNTA_INCLUIR())
                    {
                        Utils.LimparCampos(this);
                        txtNome.Focus();
                        cboIsento.SelectedIndex = 1;
                        mskDataIsentoIni.Enabled = false;
                        mskDataIsentoFin.Enabled = false;
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
                if (await MembroDAO.Alterar(member))
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

        public void setarValoresQuestionario(Membro member)
        {
            //Setando valores do questionario
            if (rdbEspiritaS.Checked)
            {
                member.Espirita = true;
            }
            else
            {
                member.Espirita = false;
            }

            if (rdbConheceKardecS.Checked)
            {
                member.ConheceEspiritismoKardecista = true;
            }
            else
            {
                member.ConheceEspiritismoKardecista = false;
            }

            if (rdbFezCursoS.Checked)
            {
                member.FezCurso = true;
            }
            else
            {
                member.FezCurso = false;
            }

            if (chkPbde.Checked)
            {
                member.CursoPbde = true;
            }
            else
            {
                member.CursoPbde = false;
            }

            if (chkEsde.Checked)
            {
                member.CursoEsde = true;
            }
            else
            {
                member.CursoEsde = false;
            }

            if (chkCoem.Checked)
            {
                member.CursoCoem = true;
            }
            else
            {
                member.CursoCoem = false;
            }

            if (chkOutros.Checked)
            {
                member.CursoOutros = true;
            }
            else
            {
                member.CursoOutros = false;
            }

            member.AondeCursou = txtAondeCursou.Text;

            if (txtQuaisLivros.Text.Equals(""))
            {
                member.JaLeuLivrosEspiritas = false;
            }
            else
            {
                if (rdbLivrosEspiritasS.Checked)
                {
                    member.JaLeuLivrosEspiritas = true;
                }
                else
                {
                    member.JaLeuLivrosEspiritas = false;
                }

                member.QuaisLivros = txtQuaisLivros.Text;
            }

            if (rdbTrabalhoVoluntarioS.Checked)
            {
                member.GostariaTrabalhoVoluntario = true;
            }
            else
            {
                member.GostariaTrabalhoVoluntario = false;
            }

            if (chkDistriAlimen.Checked)
            {
                member.DistribuicaoAlimento = true;
            }
            else
            {
                member.DistribuicaoAlimento = false;
            }

            if (chkDistriAgasa.Checked)
            {
                member.DistribuicaoAgasalho = true;
            }
            else
            {
                member.DistribuicaoAgasalho = false;
            }

            if (chkOracao.Checked)
            {
                member.OracaoPasseDomicilio = true;
            }
            else
            {
                member.OracaoPasseDomicilio = false;
            }

            if (chkSecretaria.Checked)
            {
                member.Passes = true;
            }
            else
            {
                member.Passes = false;
            }

            if (chkPalestras.Checked)
            {
                member.Palestras = true;
            }
            else
            {
                member.Palestras = false;
            }

            if (chkBiblioteca.Checked)
            {
                member.Biblioteca = true;
            }
            else
            {
                member.Biblioteca = false;
            }

            if (chkAtendimentoFraterno.Checked)
            {
                member.AtendimentoFraterno = true;
            }
            else
            {
                member.AtendimentoFraterno = false;
            }

            if (chkVisitaMensal.Checked)
            {
                member.VisitaMensalAsilo = true;
            }
            else
            {
                member.VisitaMensalAsilo = false;
            }

            if (chkPasseAoDomingo.Checked)
            {
                member.PasseDomingo = true;
            }
            else
            {
                member.PasseDomingo = false;
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Utils.Habilitar(this);
            btnSalvar.Enabled = true;
            cboIsento_SelectedValueChanged(sender, e);
        }

        private void BtBusca_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(mskCep.Text))
            {
                frmConsultarCep f = new frmConsultarCep(this, mskCep.Text);
                f.ShowDialog();
            }
            else
            {

                frmConsultarCep f = new frmConsultarCep(this);
                f.ShowDialog();
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            frmConsultarMembro f = new frmConsultarMembro(this);
            f.ShowDialog();

            if (!txtCodigo.Text.Equals(""))
            {
                btnNextMembro.Visible = true;
                btnBackMembro.Visible = true;

                if (IndexAtual > 0)
                {
                    btnBackMembro.Enabled = true;
                }
                else
                {
                    btnBackMembro.Enabled = false;
                }

                if (IndexAtual < IndexFinal)
                {
                    btnNextMembro.Enabled = true;
                }
                else
                {
                    btnNextMembro.Enabled = false;
                }
            }
        }

        public void FocusInButton(object sender, EventArgs e)
        {
            KryptonButton b = sender as KryptonButton;
            b.Focus();
        }

        private void btnBackMembro_Click(object sender, EventArgs e)
        {

            IndexAtual = IndexAtual - 1;

            if (IndexAtual < IndexFinal)
            {
                btnNextMembro.Enabled = true;
                next = true;
            }

            if (IndexAtual == 0)
            {
                IndexAtual = 0;
                btnBackMembro.Enabled = false;
                back = false;
            }


            ObterDadosMembro(membros[IndexAtual], back, next);
        }

        private void btnNextMembro_Click(object sender, EventArgs e)
        {
            IndexAtual = IndexAtual + 1;

            if (IndexAtual > 0)
            {
                btnBackMembro.Enabled = true;
                back = true;
            }

            if (IndexAtual == IndexFinal)
            {
                IndexAtual = IndexFinal;
                btnNextMembro.Enabled = false;
                next = false;
            }


            ObterDadosMembro(membros[IndexAtual], back, next);
        }

        private void ObterDadosMembro(Membro memb, bool backM, bool next)
        {

            txtCodigo.Text = memb.Id.ToString();
            txtNum.Text = memb.Numero;
            dtpDataEntrada.Value = memb.DataEntrada;
            dtpDataSaida.Value = memb.DataSaida;
            dtpDataNascimento.Value = memb.DataNascimento;
            txtNome.Text = memb.Nome;
            mskCep.Text = memb.Cep;
            txtEndereco.Text = memb.Logradouro;
            txtNumEnd.Text = memb.NumEnd;
            txtComplemento.Text = memb.Complemento;
            txtBairro.Text = memb.Bairro;
            txtCidade.Text = memb.Cidade;

            if (memb.Isento.HasValue && memb.Isento.Value)
            {
                cboIsento.SelectedItem = "Sim";
                mskDataIsentoIni.Text = memb.DataIsentoIni;
                mskDataIsentoFin.Text = memb.DataIsentoFin;
            }
            else
            {
                cboIsento.SelectedItem = "Não";
                mskDataIsentoIni.Clear();
                mskDataIsentoFin.Clear();
            }

            if (memb.Estado != null && !memb.Estado.Equals(""))
                cboEstados.SelectedItem = memb.Estado;

            if (memb.GrupoDia != null && !memb.GrupoDia.Equals(""))
                cboGrupoDia.SelectedItem = memb.GrupoDia;

            if (memb.GrupoHorario != null && !memb.GrupoHorario.Equals(""))
                cboGrupoHorario.SelectedItem = memb.GrupoHorario;

            mskTelefone.Text = memb.Telefone1;
            mskTelefone2.Text = memb.Telefone2;
            mskTelefone3.Text = memb.Telefone3;
            mskTelefone4.Text = memb.Telefone4;

            txtEmail.Text = memb.Email;
            mskCPF.Text = memb.Cpf;
            txtRg.Text = memb.Rg;
            txtProfissao.Text = memb.Profissao;
            txtGrauInstrucao.Text = memb.GrauInstrucao;

            //Questionario
            if (memb.Espirita)
            {
                rdbEspiritaS.Checked = true;
            }
            else
            {
                rdbEspiritaN.Checked = true;
            }
            if (memb.ConheceEspiritismoKardecista)
            {
                rdbConheceKardecS.Checked = true;
            }
            else
            {
                rdbConheceKardecN.Checked = true;
            }
            if (memb.FezCurso)
            {
                rdbFezCursoS.Checked = true;
            }
            else
            {
                rdbFezCursoN.Checked = true;
            }
            if (memb.CursoPbde)
            {
                chkPbde.Checked = true;
            }
            if (memb.CursoEsde)
            {
                chkEsde.Checked = true;
            }
            if (memb.CursoCoem)
            {
                chkCoem.Checked = true;
            }
            if (memb.CursoOutros)
            {
                chkOutros.Checked = true;
            }

            txtAondeCursou.Text = memb.AondeCursou;

            if (memb.JaLeuLivrosEspiritas)
            {
                rdbLivrosEspiritasS.Checked = true;
            }
            else
            {
                rdbLivrosEspiritasN.Checked = true;
            }

            txtQuaisLivros.Text = memb.QuaisLivros;

            if (memb.GostariaTrabalhoVoluntario)
            {
                rdbTrabalhoVoluntarioS.Checked = true;
            }
            else
            {
                rdbTrabalhoVoluntarioN.Checked = true;
            }

            if (memb.DistribuicaoAlimento)
            {
                chkDistriAlimen.Checked = true;
            }
            if (memb.DistribuicaoAgasalho)
            {
                chkDistriAgasa.Checked = true;
            }
            if (memb.OracaoPasseDomicilio)
            {
                chkOracao.Checked = true;
            }
            if (memb.Passes)
            {
                chkSecretaria.Checked = true;
            }
            if (memb.Biblioteca)
            {
                chkBiblioteca.Checked = true;
            }
            if (memb.Palestras)
            {
                chkPalestras.Checked = true;
            }
            if (memb.AtendimentoFraterno)
            {
                chkAtendimentoFraterno.Checked = true;
            }
            if (memb.VisitaMensalAsilo)
            {
                chkVisitaMensal.Checked = true;
            }
            if (memb.PasseDomingo)
            {
                chkPasseAoDomingo.Checked = true;
            }
            //Fim Questionario

            Utils.Desabilitar(this);
            btnNovo.Enabled = true;
            btnEditar.Enabled = true;
            btnSalvar.Enabled = false;
            btnConsultar.Enabled = true;
            if (back)
            {
                btnBackMembro.Enabled = true;
            }
            if (next)
            {
                btnNextMembro.Enabled = true;
            }
            EsconderErros();
        }

        private void MarkVoluntiers(object sender, EventArgs e)
        {
            if (sender is CheckBox)
            {
                CheckBox check = sender as CheckBox;

                if (check.Checked)
                {
                    rdbTrabalhoVoluntarioS.Checked = true;
                }
                else
                {
                    if (!MarkSocialActions())
                    {
                        rdbTrabalhoVoluntarioN.Checked = true;
                    }
                }
            }
        }

        private void MarkCurso(object sender, EventArgs e)
        {
            if (sender is CheckBox)
            {
                CheckBox check = sender as CheckBox;

                if (check.Checked)
                {
                    rdbFezCursoS.Checked = true;
                }
                else
                {
                    if (!MarkCursos())
                    {
                        rdbFezCursoN.Checked = true;
                    }
                }
            }
        }

        private bool MarkSocialActions()
        {
            if (chkDistriAlimen.Checked)
            {
                return true;
            }
            if (chkOracao.Checked)
            {
                return true;
            }
            if (chkDistriAgasa.Checked)
            {
                return true;
            }
            if (chkSecretaria.Checked)
            {
                return true;
            }
            if (chkBiblioteca.Checked)
            {
                return true;
            }
            if (chkPalestras.Checked)
            {
                return true;
            }
            if (chkAtendimentoFraterno.Checked)
            {
                return true;
            }
            if (chkVisitaMensal.Checked)
            {
                return true;
            }
            if (chkPasseAoDomingo.Checked)
            {
                return true;
            }

            return false;
        }

        private bool MarkCursos()
        {
            if (chkPbde.Checked)
            {
                return true;
            }

            if (chkCoem.Checked)
            {
                return true;
            }

            if (chkEsde.Checked)
            {
                return true;
            }

            if (chkOutros.Checked)
            {
                return true;
            }

            return false;
        }

        private void cboIsento_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cboIsento.SelectedItem.ToString().Equals("Sim"))
            {
                mskDataIsentoIni.Enabled = true;
                mskDataIsentoFin.Enabled = true;
            }
            else
            {
                mskDataIsentoIni.Enabled = false;
                mskDataIsentoFin.Enabled = false;
                mskDataIsentoIni.Text = "";
                mskDataIsentoFin.Text = "";
            }
        }

        private void createRectangles(Control c)
        {
            ShapeContainer canvas = new ShapeContainer();
            canvas.Parent = this;

            if (c is TextBox)
            {
                switch (((TextBox)(c)).Name)
                {
                    case "txtNome":
                        erroNome.Parent = canvas;
                        erroNome.Size = getSize(c);
                        erroNome.Location = getLocation(c);
                        //theShape.CornerRadius = 12;
                        erroNome.BorderColor = Color.Red;
                        break;

                    case "txtEndereco":
                        erroEndereco.Parent = canvas;
                        erroEndereco.Size = getSize(c);
                        erroEndereco.Location = getLocation(c);
                        //theShape.CornerRadius = 12;
                        erroEndereco.BorderColor = Color.Red;
                        break;

                    case "txtBairro":
                        erroBairro.Parent = canvas;
                        erroBairro.Size = getSize(c);
                        erroBairro.Location = getLocation(c);
                        //theShape.CornerRadius = 12;
                        erroBairro.BorderColor = Color.Red;
                        break;

                    case "txtCidade":  
                        erroCidade.Parent = canvas;
                        erroCidade.Size = getSize(c);
                        erroCidade.Location = getLocation(c);
                        //theShape.CornerRadius = 12;
                        erroCidade.BorderColor = Color.Red;
                        break;

                    case "txtNumEnd":
                        erroNumEnd.Parent = canvas;
                        erroNumEnd.Size = getSize(c);
                        erroNumEnd.Location = getLocation(c);
                        //theShape.CornerRadius = 12;
                        erroNumEnd.BorderColor = Color.Red;
                        break;
                        
                }
            }
            else if (c is MaskedTextBox)
            {
                switch (((MaskedTextBox)(c)).Name)
                {
                    case "mskCPF":
                        erroCpf.Parent = canvas;
                        erroCpf.Size = getSize(c);
                        erroCpf.Location = getLocation(c);
                        //theShape.CornerRadius = 12;
                        erroCpf.BorderColor = Color.Red;
                        break;

                    case "mskCep":
                        erroNumCep.Parent = canvas;
                        erroNumCep.Size = getSize(c);
                        erroNumCep.Location = getLocation(c);
                        //theShape.CornerRadius = 12;
                        erroNumCep.BorderColor = Color.Red;
                        break;
                }
            }else if(c is ComboBox)
            {
                erroEstado.Parent = canvas;
                erroEstado.Size = getSize(c);
                erroEstado.Location = getLocation(c);
                //theShape.CornerRadius = 12;
                erroEstado.BorderColor = Color.Red;
            }
        }

        private Size getSize(Control c)
        {
            return new Size(c.Width + 4, c.Height + 10);
        }

        private Point getLocation(Control c)
        {
            return new Point(c.Location.X - 3, c.Location.Y - 5);
        }

        private async void MskCep_Leave(object sender, EventArgs e)
        {
            FocusOutTextMask(sender, e);
            if(!string.IsNullOrEmpty(mskCep.Text))
            {
                var endereco = await CepService.EnderecoPorCep(Utils.RemoveCaracteresEspeciais(mskCep.Text, false, false));
                if(endereco != null)
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
