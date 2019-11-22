using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CashInBox
{
    public class Perfil
    {
        public int Id { set; get; }
        public String Descricao { set; get; }
        public List<ItemFuncionalidade> Items { set; get; }
    }
}
