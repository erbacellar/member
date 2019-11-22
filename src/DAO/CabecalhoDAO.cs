using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CashInBox
{
    class CabecalhoDAO
    {
        //Metodo que procura um Cabecalho por todos os atributos
        public static Cabecalho ObterPrimeiroCabecalho()
        {
            Entities db = new Entities();
            try
            {
                return db.Cabecalhos.First();
            }
            catch
            {
                return null;
            }
        }



        //Metodo que procura um Cabecalho por todos os atributos
        public static Cabecalho ProcurarPorId(int id)
        {
            Entities db = new Entities();
            try
            {
                return db.Cabecalhos.FirstOrDefault(x => x.Id == id);
            }
            catch
            {
                return null;
            }
        }

        //Metodo que inclui um Cabecalho no banco
        public static bool Incluir(Cabecalho Cabecalho)
        {
            Entities db = SingletonObjectContext.Instance.Context;
            try
            {
                db.Cabecalhos.Add(Cabecalho);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }

        }

        //Metodo que altera dados de um Cabecalho do banco
        public static bool Alterar(Cabecalho Cabecalho)
        {
            Entities db = SingletonObjectContext.Instance.Context;
            try
            {
                int codigo = Cabecalho.Id;
                Cabecalho c = db.Cabecalhos.First(x => x.Id == codigo);
                c.Imagem = Cabecalho.Imagem;

                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
