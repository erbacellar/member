using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace CashInBox
{
    class VersaoAtualService
    {
        static string path = @"C:\VersaoAtualDAO.txt";

        public static VersaoAtual ObterVersaoAtual()
        {
            try
            {
                return VersaoAtualDAO.ObterVersaoAtual();
            }
            catch (Exception exc)
            {
                try
                {
                    Email.EnviaMensagemEmail("ernane@x5.inf.br", "errox5@gmail.com", "evandro@x5.inf.br", "Erro - STS(Obter Versao Atual - VersaoAtual)", Email.MontarMensagemErro(exc.Message, exc.InnerException.ToString()));
                }
                catch (Exception excMail)
                {
                    if (File.Exists(path))
                    {
                        using (StreamWriter sw = File.AppendText(path))
                        {
                            //Uso o método Write para escrever o arquivo que será adicionado no arquivo texto
                            sw.WriteLine("\n\rErros - " + DateTime.Now.ToString());
                            sw.WriteLine("Erro de envio de email");
                            sw.WriteLine("=======================");
                            sw.WriteLine("\n");
                            sw.WriteLine("Mensagem: " + excMail.Message);
                            sw.WriteLine("InnerException: " + excMail.InnerException);
                            sw.WriteLine("\n");
                            sw.WriteLine("=======================");
                            sw.WriteLine("Erro do programa");
                            sw.WriteLine("=======================");
                            sw.WriteLine("\n");
                            sw.WriteLine("Mensagem: " + exc.Message);
                            sw.WriteLine("InnerException: " + exc.InnerException);
                            sw.WriteLine("\n");
                            sw.WriteLine("=======================");

                        }
                    }
                    else
                    {
                        using (FileStream fs = File.Create(path))
                        {
                            using (StreamWriter sw = new StreamWriter(fs))
                            {
                                sw.WriteLine("Erro - " + DateTime.Now.ToString());
                                sw.WriteLine("Erro do programa");
                                sw.WriteLine("=======================");
                                sw.WriteLine("\n");
                                sw.WriteLine("Mensagem: " + exc.Message);
                                sw.WriteLine("InnerException: " + exc.InnerException);
                                sw.WriteLine("\n");
                                sw.WriteLine("=======================");
                            }
                        }
                    }
                }

                throw new ErrorException("Houve um erro ao tentar conectar a base de dados. Contate o administrador do sistema caso o erro persista");
            }
        }
    }
}
