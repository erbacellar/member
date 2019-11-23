using System;
using System.Collections.Generic;

namespace CashInBox
{
    public class Voluntario
    {
        public string Key { get; set; }
        public int Id { set; get; }
        public DateTime DataCadastro { set; get; }
        public string Nome { set; get; }
        public string Cep { set; get; }
        public string Logradouro { set; get; }
        public string Bairro { set; get; }
        public string Cidade { set; get; }
        public string Estado { set; get; }
        public string NumeroEnd { set; get; }
        public string Complemento { set; get; }
        public List<Telefone> Telefones { set; get; }
        public string Email { set; get; }
        public string Cpf { set; get; }
        public string Rg { set; get; }
        public string Status { set; get; }
        public string Observacao { set; get; }
    }
}
