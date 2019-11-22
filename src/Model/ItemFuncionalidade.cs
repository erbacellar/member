using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CashInBox
{
    public class ItemFuncionalidade
    {
        public int Id { set; get; }
        public Funcionalidade Funcionalidade { set; get; }
        public bool Incluir { set; get; }
        public bool Alterar { set; get; }
        public bool Consultar { set; get; }
        public bool Excluir { set; get; }
        public bool Imprimir { set; get; }
        public bool Visualizar { set; get; }
    }
}
