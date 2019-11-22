using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CashInBox
{
    public class Usuario
    {
        public int Id { set; get; }
        public Perfil Perfil { set; get; }
        public Funcionario Funcionario { set; get; }
        public String Login { set; get; }
        public String Senha { set; get; }
    }
}
