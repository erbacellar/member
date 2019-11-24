using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security;
using System.Runtime.InteropServices;

namespace CashInBox
{
    class Mensagens
    {
        public static void mensagemINFO_INCLUIR()
        {
            MessageBox.Show("Dados inseridos com sucesso", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static Boolean mensagemPERGUNTA_INCLUIR()
        {
            if (MessageBox.Show("Deseja incluir outro?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static Boolean mensagemPERGUNTA(string x)
        {
            if (MessageBox.Show(x, "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void mensagemERRO_INCLUIR()
        {
            MessageBox.Show("Dados não pôdem ser inseridos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void mensagemALERTA(String x)
        {
            MessageBox.Show(x, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static void mensagemALERTA(string mensagem, string titulo)
        {
            MessageBox.Show(mensagem, titulo, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static void mensagemSelecionarLinhaVazia()
        {
            MessageBox.Show("Por favor, selecione uma linha com dados", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static void mensagemINFO_ALTERAR()
        {
            MessageBox.Show("Dados atualizados com sucesso", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void mensagemINFO(String x)
        {
            MessageBox.Show(x, "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void mensagemERRO_ALTERAR()
        {
            MessageBox.Show("Dados não pôdem ser atualizados", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void mensagemINFO_EXCLUIR()
        {
            MessageBox.Show("Dados excluídos com sucesso", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void mensagemERRO_EXCLUIR()
        {
            MessageBox.Show("Dados não pôdem ser excluídos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static Boolean mensagemPERGUNTA_EXCLUIR()
        {
            if (MessageBox.Show("Tem certeza que deseja excluir este registro?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void mensagemERRO(String x)
        {
            MessageBox.Show(x, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void mensagemCamposObrigatorios()
        {
            MessageBox.Show("Alguns campos obrigatórios não foram preenchidos, verifique e tente novamente", "Campos obrigatórios não preenchidos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static void Mensagem_Erro_Conexao_Base_Dados()
        {
            MessageBox.Show("Não foi possível se conectar a base de dados. Verifique sua conexão com a internet e tente novamente.",
                    "Erro na conexão com a base de dados",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
        }
    }
}
