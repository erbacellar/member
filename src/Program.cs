using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Diagnostics;
using System.Configuration;

namespace CashInBox
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Process aProcess = Process.GetCurrentProcess();
            string aProcName = aProcess.ProcessName;

            if (Process.GetProcessesByName(aProcName).Length > 1)
            {
                MessageBox.Show("A aplicação já está executando!!", "Execução", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                Application.ExitThread();
            }

            int renderizacao = 0;

            bool deslogar = false;
            //bool licencaValida = false;
            string tipoAcesso = "";

            //Habilita o Estilo Visual das janelas
            Application.EnableVisualStyles();
            if (renderizacao == 0)
            {
                //Renderiza corretamente os componentes na janela
                //OBS: So precisa ser chamado na primeira chamada de janela, após isso não
                //por isso o IF.
                Application.SetCompatibleTextRenderingDefault(false);
                renderizacao = 1;
            }
            try
            {
                //frmSelecionarTipoAcesso selecTipAcess = new frmSelecionarTipoAcesso();
                //Application.Run(selecTipAcess);


                //tipoAcesso = selecTipAcess.tipo;

                AlterarAppConfig();


                frmAbertura abertura = new frmAbertura();
                abertura.ShowDialog();

                VersaoAtual version = VersaoAtualService.ObterVersaoAtual();
                bool atualizado = true;
                Versao v = new Versao();
                if (version != null)
                {
                    if (!v.Obter().Equals(version.Descricao))
                    {
                        Mensagens.mensagemALERTA("A versão do seu sistema não corresponde com a versão atual. Atualize-o. Caso haja problemas, entre em contato com o administrador do sistema");
                        atualizado = false;
                    }
                }


                if (atualizado)
                {

                    //DoWhile para continuar a pedindo login caso o usuario 
                    //somente quiser entrar com outra conta ao inves de sair
                    do
                    {
                        ////Habilita o Estilo Visual das janelas
                        //Application.EnableVisualStyles();
                        //if (renderizacao == 0)
                        //{
                        //    //Renderiza corretamente os componentes na janela
                        //    //OBS: So precisa ser chamado na primeira chamada de janela, após isso não
                        //    //por isso o IF.
                        //    Application.SetCompatibleTextRenderingDefault(false);
                        //    renderizacao = 1;
                        //}

                        //Application.Run(new frmAbertura());

                        //================================Verifica a licença a partir do numero de serie do HD=====================================================//
                        //Licenca licenca = LicencaDAO.ProcurarPorNumHd(RecuperarNumSerieHDD.getSerialHD());

                        //if (licenca != null)
                        //{
                        //    if (licenca.DataValidade.AddDays(1) > DateTime.Parse(DateTime.Now.ToShortDateString()))
                        //    {
                        //        if (licenca.Ativa)
                        //        {
                        //            licencaValida = true;
                        //        }
                        //        else
                        //        {
                        //            Mensagens.mensagemINFO("A sua licença não está ativa. Entre em contato com um de nossos atendentes para ativá-la novamente");
                        //        }
                        //    }
                        //}
                        //else
                        //{
                        //    Mensagens.mensagemINFO("Este computador não está licenseado. Entre em contato com um de nosso atendentes e compre uma licença válida");
                        //}

                        //if (licencaValida)
                        //{

                        frmLogar login = new frmLogar();
                        login.ShowDialog();
                        deslogar = login.deslogar;

                        string User = login.User;

                        if (login.testLogin)
                        {
                            //Usuario usu = new Usuario();
                            //usu = UsuarioDAO.ProcurarUsuarioPorLogin(User);
                            //Log log = new Log();
                            //log.Funcionario = lg.Funcionario.NomeFuncionario;
                            //log.DataLog = DateTime.Now;
                            //log.DescLog = "Login do Funcionário " + lg.Funcionario.NomeFuncionario;
                            //LogDAO.Incluir(log);

                            frmPrincipal f = new frmPrincipal(User);
                            f.ShowDialog();
                            deslogar = f.deslogar;
                            //frmArquivosTeste f = new frmArquivosTeste();
                            //f.ShowDialog();
                        }
                        //}
                    } while (deslogar);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro: " + e.Message + "\n\rInnerException: " + e.InnerException, "Erro ao conectar a Base de Dados");
            }
        }

        public static void AlterarAppConfig(string tipoAcesso = "Interno")
        {
            string datasource = "";
            string caminhoBanco = "Member";
            string loginBanco = "member-user";
            string senhaBanco = "#Matheus190504";
            //string senhaBanco = "ernane92";
            string nomeConnectionString = "Entities";
            string nomeConnectionStringRelatorios = "CashInBox.Properties.Settings.MemberConnectionString";

            if (tipoAcesso.Equals("Interno"))
            {
                //datasource = "CPEE\\SQLEXPRESS";
                datasource = "DESKTOP-3QQEO96\\SQLEXPRESS";
            }
            else
            {
                datasource = "177.52.225.56";
            }

            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            string con = "Data Source=" + datasource + ";Initial Catalog=" + caminhoBanco + ";Persist Security Info=True;User ID=" + loginBanco + ";Password=" + senhaBanco;
            config.ConnectionStrings.ConnectionStrings[nomeConnectionString].ConnectionString = con;
            config.Save(ConfigurationSaveMode.Modified); // Salva o que foi modificado

            Configuration configRelatorio = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            string conRelatorio = "Data Source=" + datasource + ";Initial Catalog=" + caminhoBanco + ";Persist Security Info=True;User ID=" + loginBanco + ";Password=" + senhaBanco;
            configRelatorio.ConnectionStrings.ConnectionStrings[nomeConnectionStringRelatorios].ConnectionString = conRelatorio;
            configRelatorio.Save(ConfigurationSaveMode.Modified); // Salva o que foi modificado

            ConfigurationManager.RefreshSection("connectionStrings"); // Atualiza no app o bloco connectionStrings
            Properties.Settings.Default.Reload(); // Recarrega os dados de conexão
        }
    }
}
