using System;

namespace Member.Common.Models
{
    public class Usuario
    {
        public int Id { set; get; }
        public Voluntario Funcionario { set; get; }
        public String Login { set; get; }
        public String Senha { set; get; }
    }
}
