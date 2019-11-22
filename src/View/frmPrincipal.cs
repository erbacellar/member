using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Deployment.Application;
using System.Threading;
using ComponentFactory.Krypton.Toolkit;

namespace CashInBox
{
    public partial class frmPrincipal : Form
    {
        private ProgressoAtualizacao _progresso;
        public bool deslogar = false;
        Usuario usu = new Usuario();

        public frmPrincipal()
        {
            InitializeComponent();
        }

        public frmPrincipal(String Login)
        {
            InitializeComponent();
            if (!Login.Equals("admin"))
            {
                usu = UsuarioDAO.ProcurarUsuarioPorLogin(Login);
            }
            else
            {
                usu.Login = "admin";
            }
        }

        public void FocusInBotao(object sender, EventArgs e)
        {
            Color cor = Color.Silver;
            Utils.TrocarCorFundoBotao(sender, cor);
        }

        public void FocusOutBotao(object sender, EventArgs e)
        {
            Color cor = Color.White;
            Utils.TrocarCorFundoBotao(sender, cor);
        }

        private void btnFuncionarios_Click(object sender, EventArgs e)
        {
            frmFuncionario f = new frmFuncionario(usu.Login);
            f.ShowDialog();
        }

        private void btnPerfis_Click(object sender, EventArgs e)
        {
            frmPerfil f = new frmPerfil(usu.Login);
            f.ShowDialog();

            frmPrincipalTeste_Load(sender, e);
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            frmUsuario f = new frmUsuario(usu.Login);
            f.ShowDialog();

            frmPrincipalTeste_Load(sender, e);
        }

        private void btnDeslogar_Click(object sender, EventArgs e)
        {
            deslogar = true;
            Close();
        }


        private void btnMembroes_Click(object sender, EventArgs e)
        {
            frmMembro f = new frmMembro(usu.Login);
            f.ShowDialog();
        }

        private void frmPrincipalTeste_Load(object sender, EventArgs e)
        {
            Versao v = new Versao();
            lblVersao.Text = "Versão: " + v.Obter();
            if (usu.Login.Equals("admin"))
            {
                lblUsuarioLogado.Text = "Logado como: Admin";
            }
            else
            {
                lblUsuarioLogado.Text = "Logado como: " + usu.Funcionario.Nome;
                Desabilitar();
                HabilitarDeAcordoComPerfil();
            }
        }

        private void HabilitarDeAcordoComPerfil()
        {
            VerificarAcesso.Verificar(this, usu.Id);
        }

        private void Desabilitar()
        {
            //Botões de acesso aos context menu
            btnAcesso.Enabled = false;
            btnCadastros.Enabled = false;
            btnMovimentos.Enabled = false;
            btnRelatorios.Enabled = false;


            //Botões de acesso as telas
            cmdMembro.Enabled = false;
            cmdFuncionario.Enabled = false;
            cmdPerfis.Enabled = false;
            cmdUsuarios.Enabled = false;
            cmdRelFichaCadMembro.Enabled = false;

        }


        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            BackgroundWorker backgroundWorker = new BackgroundWorker();
            backgroundWorker.DoWork += new DoWorkEventHandler(backgroundWorker_DoWork);
            backgroundWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(backgroundWorker_RunWorkerCompleted);
            backgroundWorker.RunWorkerAsync();
            _progresso = new ProgressoAtualizacao();
            _progresso.ShowDialog();
        }

        private void btnImagem_Click(object sender, EventArgs e)
        {
            frmConfigImagemCabecalho f = new frmConfigImagemCabecalho();
            f.ShowDialog();
        }

        #region Atualizacao do sistema

        #region Eventos do BackgroundWorker
        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            InstallUpdateSyncWithInfo();
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            _progresso.Close();

        }
        #endregion Eventos do BackgroundWorker

        private void InstallUpdateSyncWithInfo()
        {
            UpdateCheckInfo info = null;

            if (ApplicationDeployment.IsNetworkDeployed)
            {
                ApplicationDeployment ad = ApplicationDeployment.CurrentDeployment;
                try
                {
                    info = ad.CheckForDetailedUpdate();
                }
                catch (DeploymentDownloadException dde)
                {
                    MessageBox.Show("A nova versão do programa não pôde ser baixada. \n\nPor favor, cheque sua conexão de internet ou tente novamente mais tarde. Erro: " + dde.Message, "Falha no download da atualização", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                catch (InvalidDeploymentException ide)
                {
                    MessageBox.Show("A nova versão do programa não pôde ser checada. O ClickOnce está corrompido. Por favor, compile a aplicação e tente novamente. Erro: " + ide.Message, "Falha na checagem de atualização", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                catch (InvalidOperationException ioe)
                {
                    MessageBox.Show("A aplicação não pôde ser atualizada. A atualização não é de um formato ClickOnce. Erro: " + ioe.Message, "Aplicação não atualizada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (info.UpdateAvailable)
                {
                    Boolean doUpdate = true;
                    if (!info.IsUpdateRequired)
                    {
                        DialogResult dr = MessageBox.Show("Uma atualização está disponível. Gostaria de atualizar a aplicação agora?", "Atualização Disponível", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        if (!(DialogResult.OK == dr))
                        {
                            doUpdate = false;
                        }
                    }
                    else
                    {
                        // Display a message that the app MUST reboot. Display the minimum required version.
                        MessageBox.Show("A aplicação detectou uma atualização obrigatória da sua atual versão " +
                            "para versão " + info.MinimumRequiredVersion.ToString() +
                            ". A aplicação irá instalar a atualização e reiniciar.",
                            "Atualização Disponível", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }

                    if (doUpdate)
                    {
                        try
                        {
                            ad.Update();
                            MessageBox.Show("A aplicação foi atualizada e irá reiniciar.", "Atualização completada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Application.Restart();
                        }
                        catch (DeploymentDownloadException dde)
                        {
                            MessageBox.Show("A nova versão da aplicação não pôde ser instalada. \n\nPor favor, cheque sua conexão de internet ou tente novamente mais tarde. Erro: " + dde, "Atualização não instalada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                }
                else
                {
                    Mensagens.mensagemINFO("Não há atualizações disponíveis no momento");
                }
            }
            else
            {
                Mensagens.mensagemINFO("A aplicação não é ClickOnce.");
            }

        }

        #endregion

        private void btnCadastros_Click(object sender, EventArgs e)
        {
            conCadastros.Show(btnCadastros);
        }

        private void btnCadastros_DropDown(object sender, ComponentFactory.Krypton.Toolkit.ContextPositionMenuArgs e)
        {
            conCadastros.Show(btnCadastros);
        }

        private void btnAcesso_Click_1(object sender, EventArgs e)
        {
            conAcessos.Show(btnAcesso);
        }

        private void btnAcesso_DropDown(object sender, ComponentFactory.Krypton.Toolkit.ContextPositionMenuArgs e)
        {
            conAcessos.Show(btnAcesso);
        }

        public void FocusBotao(object sender, EventArgs e)
        {
            KryptonDropButton b = sender as KryptonDropButton;
            b.Focus();
        }

        private void btnMovimentos_Click(object sender, EventArgs e)
        {
            conMovimentos.Show(btnMovimentos);
        }

        private void btnMovimentos_DropDown(object sender, ContextPositionMenuArgs e)
        {
            conMovimentos.Show(btnMovimentos);
        }

        private void btnRelatorios_Click_1(object sender, EventArgs e)
        {
            conRelatorios.Show(btnRelatorios);
        }

        private void btnRelatorios_DropDown(object sender, ContextPositionMenuArgs e)
        {
            conRelatorios.Show(btnRelatorios);
        }

        private void cmdRelFichaCadMembro_Execute(object sender, EventArgs e)
        {
            frmRelatorioFichaCadastroMembro f = new frmRelatorioFichaCadastroMembro();
            f.ShowDialog();

            frmPrincipalTeste_Load(sender, e);
        }

        private void cmdRelMembrosPorGrupo_Execute(object sender, EventArgs e)
        {
            frmRelatorioMembrosPorGrupo f = new frmRelatorioMembrosPorGrupo();
            f.ShowDialog();
            frmPrincipalTeste_Load(sender, e);
        }

        private void cmdRelVoluntarios_Execute(object sender, EventArgs e)
        {
            frmRelatorioVoluntarios f = new frmRelatorioVoluntarios();
            f.ShowDialog();
            frmPrincipalTeste_Load(sender, e);
        }

        private void cmdRelFinanceiro_Execute(object sender, EventArgs e)
        {
            frmRelFinanceiro f = new frmRelFinanceiro();
            f.ShowDialog();
            frmPrincipalTeste_Load(sender, e);
        }

        private void cmdRelDivulgacao_Execute(object sender, EventArgs e)
        {
            frmRelDivulgacao f = new frmRelDivulgacao();
            f.ShowDialog();
            frmPrincipalTeste_Load(sender, e);
        }

        private void cmdRelBiblioteca_Execute(object sender, EventArgs e)
        {
            frmRelBiblioteca f = new frmRelBiblioteca();
            f.ShowDialog();
            frmPrincipalTeste_Load(sender, e);
        }

        private void cmdRelDoutrinario_Execute(object sender, EventArgs e)
        {
            frmRelDoutrinario f = new frmRelDoutrinario();
            f.ShowDialog();
            frmPrincipalTeste_Load(sender, e);
        }

        private void cmdRelAniversariantes_Execute(object sender, EventArgs e)
        {
            frmRelatorioAniversariantes f = new frmRelatorioAniversariantes();
            f.ShowDialog();
            frmPrincipalTeste_Load(sender, e);
        }

        private void cmdRelFinanceiro2_Execute(object sender, EventArgs e)
        {
            frmRelatorioFinanceiro2Isentos f = new frmRelatorioFinanceiro2Isentos();
            f.ShowDialog();
            frmPrincipalTeste_Load(sender, e);
        }
    }
}
