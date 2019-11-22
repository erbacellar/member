using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CashInBox
{
    public class Funcionario
    {
        public int Id { set; get; }
        public DateTime DataCadastro { set; get; }
        public String Nome { set; get; }
        public String Cep { set; get; }
        public String Logradouro { set; get; }
        public String Bairro { set; get; }
        public String Cidade { set; get; }
        public String Estado { set; get; }
        public String NumeroEnd { set; get; }
        public String Complemento { set; get; }
        public List<TelefoneFuncionario> Telefones { set; get; }
        public String Email { set; get; }
        public String Cpf { set; get; }
        public String Rg { set; get; }
        public String Status { set; get; }
        public String Observacao { set; get; }
    }
}
