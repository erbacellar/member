using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CashInBox
{
    public class FuncionalidadeDAO
    {
        //Metodo que procura um Veiculo pelo ID
        public static Funcionalidade obterFuncionalidade(Funcionalidade Funcionalidade)
        {
            Entities db = new Entities();
            try
            {
                return db.Funcionalidades.FirstOrDefault(x => x.Descricao.Equals(Funcionalidade.Descricao));
            }
            catch
            {
                return null;
            }
        }

        //Metodo que retorna todas as funcionalidades cadastradas do banco
        public static IOrderedEnumerable<Funcionalidade> Listar()
        {
            Entities db = new Entities();
            return db.Funcionalidades.ToList().OrderBy(x => x.Descricao);
        }

        public static Funcionalidade ObterFuncionalidadePorId(int id)
        {
            Entities db = new Entities();
            return db.Funcionalidades.FirstOrDefault(x => x.Id == id);
        }
    }
}
