using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CashInBox
{
    class VersaoAtualDAO
    {
        //Metodo que procura a Versao Atual do Programa
        public static VersaoAtual ObterVersaoAtual()
        {
            Entities db = new Entities();
            try
            {
                return new VersaoAtual() { Id = 1, Descricao = "1.0.0.0" };
                return db.VersaoAtual.FirstOrDefault();
            }
            catch (Exception exc)
            {
                throw new Exception(exc.Message, exc.InnerException);
            }
        }
    }
}
