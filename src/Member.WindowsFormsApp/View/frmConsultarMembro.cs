using Member.Common.Models;
using Member.Dao.Repositories;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CashInBox
{
    public partial class frmConsultarMembro : Form
    {
        frmMembro frmMembro = null;
        List<Membro> membrosConsult;
        frmRelatorioFichaCadastroMembro frmRelFichaCadMembro = null;
        List<GridConsultarMembro> grids;
        ProgressoPesquisa _progresso;
        string grupoDia = "";
        string grupoHorario = "";
        string status = "";

        public frmConsultarMembro(Form f)
        {
            InitializeComponent();

            if (f.Name.Equals("frmMembro"))
            {
                frmMembro = (frmMembro)f;
            }
            if (f.Name.Equals("frmRelatorioFichaCadastroMembro"))
            {
                frmRelFichaCadMembro = (frmRelatorioFichaCadastroMembro)f;
            }

        }

        private async void btnPesquisar_Click(object sender, EventArgs e)
        {
            grdConsulta.Rows.Clear();

            if (cboGrupoDia.SelectedIndex != -1 && cboGrupoHorario.SelectedIndex != -1)
            {
                grupoDia = cboGrupoDia.SelectedItem.ToString();
                grupoHorario = cboGrupoHorario.SelectedItem.ToString();
            }

            status = cboStatus.SelectedItem.ToString();

            
            await Pesquisar();

            try
            {
                grdConsulta.Columns[0].Visible = false;
            }
            catch
            {

            }

        }

        private async void grdConsulta_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (frmMembro != null)
            {
                try
                {
                    Utils.LimparCampos(frmMembro);

                    Membro memb = new Membro();
                    memb = await MembroDAO.Obter(grdConsulta.CurrentRow.Cells[0].Value.ToString());

                    frmMembro.IndexAtual = membrosConsult.FindIndex(x => x.Id == memb.Id);
                    frmMembro.IndexFinal = membrosConsult.Count() - 1;
                    frmMembro.membros = membrosConsult;

                    //habilita ou nao os botoes Back e Next
                    HabilitarConsultaRapida(frmMembro);

                    frmMembro.txtCodigo.Text = memb.Id.ToString();
                    frmMembro.txtKey.Text = memb.Key;
                    frmMembro.txtNum.Text = memb.Numero;
                    frmMembro.dtpDataEntrada.Value = memb.DataEntrada == DateTime.MinValue ? DateTime.Now : memb.DataEntrada;
                    frmMembro.dtpDataSaida.Value = memb.DataSaida == DateTime.MinValue ? DateTime.Now : memb.DataSaida;
                    frmMembro.dtpDataNascimento.Value = memb.DataNascimento;
                    frmMembro.txtNome.Text = memb.Nome;
                    frmMembro.mskCep.Text = memb.Cep;
                    frmMembro.txtEndereco.Text = memb.Logradouro;
                    frmMembro.txtNumEnd.Text = memb.NumEnd;
                    frmMembro.txtComplemento.Text = memb.Complemento;
                    frmMembro.txtBairro.Text = memb.Bairro;
                    frmMembro.txtCidade.Text = memb.Cidade;

                    if (memb.Isento.HasValue && memb.Isento.Value)
                    {
                        frmMembro.cboIsento.SelectedItem = "Sim";
                        frmMembro.mskDataIsentoIni.Text = memb.DataIsentoIni;
                        frmMembro.mskDataIsentoFin.Text = memb.DataIsentoFin;
                    }
                    else
                    {
                        frmMembro.cboIsento.SelectedItem = "Não";
                    }

                    frmMembro.cboStatus.SelectedItem = memb.Status;

                    if (memb.Estado != null && !memb.Estado.Equals(""))
                        frmMembro.cboEstados.SelectedItem = memb.Estado;

                    if (memb.GrupoDia != null && !memb.GrupoDia.Equals(""))
                        frmMembro.cboGrupoDia.SelectedItem = memb.GrupoDia;

                    if (memb.GrupoHorario != null && !memb.GrupoHorario.Equals(""))
                        frmMembro.cboGrupoHorario.SelectedItem = memb.GrupoHorario;

                    frmMembro.mskTelefone.Text = memb.Telefone1;
                    frmMembro.mskTelefone2.Text = memb.Telefone2;
                    frmMembro.mskTelefone3.Text = memb.Telefone3;
                    frmMembro.mskTelefone4.Text = memb.Telefone4;

                    frmMembro.txtEmail.Text = memb.Email;
                    frmMembro.mskCPF.Text = memb.Cpf;
                    frmMembro.txtRg.Text = memb.Rg;
                    frmMembro.txtProfissao.Text = memb.Profissao;
                    frmMembro.txtGrauInstrucao.Text = memb.GrauInstrucao;

                    //Questionario
                    if (memb.Espirita)
                    {
                        frmMembro.rdbEspiritaS.Checked = true;
                    }
                    else
                    {
                        frmMembro.rdbEspiritaN.Checked = true;
                    }
                    if (memb.ConheceEspiritismoKardecista)
                    {
                        frmMembro.rdbConheceKardecS.Checked = true;
                    }
                    else
                    {
                        frmMembro.rdbConheceKardecN.Checked = true;
                    }
                    if (memb.FezCurso)
                    {
                        frmMembro.rdbFezCursoS.Checked = true;
                    }
                    else
                    {
                        frmMembro.rdbFezCursoN.Checked = true;
                    }
                    if (memb.CursoPbde)
                    {
                        frmMembro.chkPbde.Checked = true;
                    }
                    if (memb.CursoEsde)
                    {
                        frmMembro.chkEsde.Checked = true;
                    }
                    if (memb.CursoCoem)
                    {
                        frmMembro.chkCoem.Checked = true;
                    }
                    if (memb.CursoOutros)
                    {
                        frmMembro.chkOutros.Checked = true;
                    }

                    frmMembro.txtAondeCursou.Text = memb.AondeCursou;

                    if (memb.JaLeuLivrosEspiritas)
                    {
                        frmMembro.rdbLivrosEspiritasS.Checked = true;
                    }
                    else
                    {
                        frmMembro.rdbLivrosEspiritasN.Checked = true;
                    }

                    frmMembro.txtQuaisLivros.Text = memb.QuaisLivros;

                    if (memb.GostariaTrabalhoVoluntario)
                    {
                        frmMembro.rdbTrabalhoVoluntarioS.Checked = true;
                    }
                    else
                    {
                        frmMembro.rdbTrabalhoVoluntarioN.Checked = true;
                    }

                    if (memb.DistribuicaoAlimento)
                    {
                        frmMembro.chkDistriAlimen.Checked = true;
                    }
                    if (memb.DistribuicaoAgasalho)
                    {
                        frmMembro.chkDistriAgasa.Checked = true;
                    }
                    if (memb.OracaoPasseDomicilio)
                    {
                        frmMembro.chkOracao.Checked = true;
                    }
                    if (memb.Passes)
                    {
                        frmMembro.chkSecretaria.Checked = true;
                    }
                    if (memb.Biblioteca)
                    {
                        frmMembro.chkBiblioteca.Checked = true;
                    }
                    if (memb.Palestras)
                    {
                        frmMembro.chkPalestras.Checked = true;
                    }
                    if (memb.AtendimentoFraterno)
                    {
                        frmMembro.chkAtendimentoFraterno.Checked = true;
                    }
                    if (memb.VisitaMensalAsilo)
                    {
                        frmMembro.chkVisitaMensal.Checked = true;
                    }
                    if (memb.PasseDomingo)
                    {
                        frmMembro.chkPasseAoDomingo.Checked = true;
                    }
                    //Fim Questionario

                    Utils.Desabilitar(frmMembro);
                    frmMembro.btnNovo.Enabled = true;
                    frmMembro.btnEditar.Enabled = true;
                    frmMembro.btnSalvar.Enabled = false;
                    frmMembro.btnConsultar.Enabled = true;
                    frmMembro.EsconderErros();

                    Close();
                }
                catch
                {
                    Mensagens.mensagemALERTA("Selecione uma linha com dados");
                }
            }
            else
            {
                if (frmRelFichaCadMembro != null)
                {
                    try
                    {
                        Utils.LimparCampos(frmRelFichaCadMembro);

                        Membro memb = new Membro();
                        memb = await MembroDAO.Obter(grdConsulta.CurrentRow.Cells[0].Value.ToString());

                        frmRelFichaCadMembro.txtId.Text = memb.Id.ToString();
                        frmRelFichaCadMembro.txtNome.Text = memb.Nome;
                        frmRelFichaCadMembro.mskCPF.Text = memb.Cpf;

                        frmRelFichaCadMembro.membroRel = memb;

                        Close();
                    }
                    catch
                    {
                        Mensagens.mensagemALERTA("Selecione uma linha com dados");
                    }
                }
            }
        }

        private void txtConsultar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Utils.PressionarEnterCampoTexto(sender, e))
            {
                btnPesquisar_Click(sender, e);
            }
        }

        private async Task Pesquisar()
        {
            _progresso = new ProgressoPesquisa();
            _progresso.Show();

            grids = new List<GridConsultarMembro>();
            List<Membro> membros;
            List<Membro> membrosAux;

            if (txtConsultar.Text.Equals(""))
            {
                membros = await MembroDAO.ObterMembros();
            }
            else
            {
                Membro membConsulta = new Membro();
                membConsulta.Nome = txtConsultar.Text;
                membConsulta.Cpf = txtConsultar.Text;

                membros = await MembroDAO.ObterMembrosPorLetraParcial(membConsulta);
            }

            membrosAux = membros.Where(x => x.Status != null && x.Status.Equals(status)).OrderBy(x => x.Nome).ToList();
            membros = membrosAux;

            if (grupoDia != "Todos" && grupoHorario != "Todos")
            {
                membrosAux = membros.Where(x => x.GrupoDia.Equals(grupoDia)
                    && x.GrupoHorario.Equals(grupoHorario)).OrderBy(x => x.Nome).ToList();

                membros = membrosAux;
            }

            if (!txtNum.Text.Equals(""))
            {
                membrosAux = membros.Where(x => x.Numero.Contains(txtNum.Text)).OrderBy(x => x.Nome).ToList();
                membros = membrosAux;
            }

            if (!txtEmail.Text.Equals(""))
            {
                membrosAux = membros.Where(x => x.Email.Contains(txtEmail.Text)).OrderBy(x => x.Nome).ToList();
                membros = membrosAux;
            }

            if (!txtBairro.Text.Equals(""))
            {
                membrosAux = membros.Where(x => x.Bairro.Contains(txtBairro.Text)).OrderBy(x => x.Nome).ToList();
                membros = membrosAux;
            }

            if (!txtCidade.Text.Equals(""))
            {
                membrosAux = membros.Where(x => x.Cidade.Contains(txtCidade.Text)).OrderBy(x => x.Nome).ToList();
                membros = membrosAux;
            }

            if (rdbTrabalhoVoluntarioS.Checked)
            {
                membrosAux = membros.Where(x => x.GostariaTrabalhoVoluntario == true).OrderBy(x => x.Nome).ToList();
                membros = membrosAux;
            }
            if (rdbTrabalhoVoluntarioN.Checked)
            {
                membrosAux = membros.Where(x => x.GostariaTrabalhoVoluntario == false).OrderBy(x => x.Nome).ToList();
                membros = membrosAux;
            }

            if (rdbSimB.Checked)
            {
                membrosAux = membros.Where(x => x.Biblioteca == true).OrderBy(x => x.Nome).ToList();
                membros = membrosAux;
            }
            if (rdbSimB.Checked)
            {
                membrosAux = membros.Where(x => x.Biblioteca == false).OrderBy(x => x.Nome).ToList();
                membros = membrosAux;
            }

            foreach (Membro x in membros)
            {
                grids.Add(preencherVariavel(x));
            }

            membrosConsult = membros.ToList();

            _progresso.Close();

            BindingSource source = new BindingSource();
            source.DataSource = grids;
            SetControlPropertyValue(grdConsulta, "DataSource", source);

            Utils.InformarConsultaVazia(grdConsulta);

        }

        delegate void SetControlValueCallback(Control oControl, string propName, object propValue);
        private void SetControlPropertyValue(Control oControl, string propName, object propValue)
        {
            if (oControl.InvokeRequired)
            {
                SetControlValueCallback d = new SetControlValueCallback(SetControlPropertyValue);
                oControl.Invoke(d, new object[] { oControl, propName, propValue });
            }
            else
            {
                Type t = oControl.GetType();
                PropertyInfo[] props = t.GetProperties();
                foreach (PropertyInfo p in props)
                {
                    if (p.Name.ToUpper() == propName.ToUpper())
                    {
                        p.SetValue(oControl, propValue, null);
                    }
                }
            }
        }

        private GridConsultarMembro preencherVariavel(Membro x)
        {
            GridConsultarMembro grid = new GridConsultarMembro();
            grid.Id = x.Key;
            grid.Numero = x.Numero;
            grid.Nome = x.Nome;
            grid.Cpf = x.Cpf;
            grid.Grupo = x.GrupoDia + " " + x.GrupoHorario;
            grid.Email = x.Email;
            grid.Bairro = x.Bairro;
            grid.Cidade = x.Cidade;

            if (x.GostariaTrabalhoVoluntario)
            {
                grid.Voluntario = "Sim";
            }
            else
            {
                grid.Voluntario = "Não";
            }

            if (x.Biblioteca)
            {
                grid.Biblioteca = "Sim";
            }
            else
            {
                grid.Biblioteca = "Não";
            }

            return grid;
        }

        private void frmConsultarMembro_Load(object sender, EventArgs e)
        {
            cboGrupoDia.Items.Add("Todos");
            foreach (String x in Utils.recuperarDiasSemana())
            {
                cboGrupoDia.Items.Add(x);
            }

            cboGrupoHorario.Items.Add("Todos");
            foreach (String x in Utils.recuperarHorarios())
            {
                cboGrupoHorario.Items.Add(x);
            }

            foreach (String x in Utils.recuperarListaStatus()) {
                cboStatus.Items.Add(x);
            }

            cboGrupoDia.SelectedIndex = 0;
            cboGrupoHorario.SelectedIndex = 0;
            cboStatus.SelectedIndex = 0;
        }

        private void HabilitarConsultaRapida(frmMembro frmMembro)
        {
            if (frmMembro.IndexAtual > 0 && frmMembro.IndexAtual < frmMembro.IndexFinal)
            {
                frmMembro.back = true;
                frmMembro.next = true;
            }
            else if (frmMembro.IndexAtual == 0 && frmMembro.IndexAtual < frmMembro.IndexFinal)
            {
                frmMembro.back = false;
                frmMembro.next = true;
            }
            else if (frmMembro.IndexAtual > 0 && frmMembro.IndexAtual == frmMembro.IndexFinal)
            {
                frmMembro.back = true;
                frmMembro.next = false;
            }
            else
            {
                frmMembro.back = false;
                frmMembro.next = false;
            }

            if (frmMembro.back)
            {
                frmMembro.btnBackMembro.Enabled = true;
            }
            else
            {
                frmMembro.btnBackMembro.Enabled = false;
            }

            if (frmMembro.next)
            {
                frmMembro.btnNextMembro.Enabled = true;
            }
            else
            {
                frmMembro.btnNextMembro.Enabled = false;
            }
        }

    }
}
