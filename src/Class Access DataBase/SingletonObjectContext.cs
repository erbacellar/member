using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CashInBox
{
    class SingletonObjectContext
    {
        [ThreadStatic]
        private static SingletonObjectContext instance;
        private readonly Entities context;


        //Metodo que cria um contexto se nao existir
        private SingletonObjectContext()
        {
            context = new Entities();
        }

        //Metodo que retorna a instancia de um contexto
        public static SingletonObjectContext Instance
        {
            get
            {
                if (instance == null) instance = new SingletonObjectContext();
                
                return instance;
            }
        }

        //Metodo que retorna o Contexto
        public Entities Context
        {
            get
            {
                return context;
            }
        }
    }
}
