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
            Application.EnableVisualStyles();
            try
            {

                //AlterarAppConfig();

                frmAbertura abertura = new frmAbertura();
                abertura.ShowDialog();                

                frmLogar login = new frmLogar();
                login.ShowDialog();

                string User = login.User;

                if (login.testLogin)
                {
                    frmPrincipal f = new frmPrincipal(User);
                    f.ShowDialog();

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
