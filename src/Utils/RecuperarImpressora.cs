using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace CashInBox
{
    class RecuperarImpressora
    {
        private static string strPathFile = CaminhoArquivoConfig.Obter();
        static List<string> mensagemLinha;
        static string mensagem;

        public static string ImpressoraPadrao()
        {
            mensagem = "";
            mensagemLinha = new List<string>();
            //Verifico se o arquivo que desejo abrir existe e passo como parâmetro a respectiva variável
            if (File.Exists(strPathFile))
            {
                using (StreamReader texto = new StreamReader(strPathFile))
                {
                    while ((mensagem = texto.ReadLine()) != null)
                    {
                        mensagemLinha.Add(mensagem);
                    }
                }

                return mensagemLinha[0];
            }
            return "";
        }

        public static string ImpressoraAutorizacao()
        {
            mensagem = "";
            mensagemLinha = new List<string>();

            //Verifico se o arquivo que desejo abrir existe e passo como parâmetro a respectiva variável
            if (File.Exists(strPathFile))
            {
                using (StreamReader texto = new StreamReader(strPathFile))
                {
                    while ((mensagem = texto.ReadLine()) != null)
                    {
                        mensagemLinha.Add(mensagem);
                    }
                }

                return mensagemLinha[1];

            }
            return "";
        }
    }
}
