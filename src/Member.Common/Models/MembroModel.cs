using System;

namespace Member.Common.Models
{
    public class Membro
    {
        public string Key { get; set; }
        public int Id { set; get; }
        public String Numero { set; get;}
        public String GrupoDia { set; get;}
        public String GrupoHorario { set; get; }
        public DateTime DataEntrada { set; get; }
        public DateTime DataSaida { set; get; }
        public DateTime DataNascimento { set; get; }
        public String Nome { set; get; }
        public String Cep { set; get; }
        public String Logradouro { set; get; }
        public String NumEnd { set; get; }
        public String Bairro { set; get; }
        public String Complemento { set; get; }
        public String Cidade { set; get; }
        public String Estado { set; get; }
        public String Telefone1 { set; get; }
        public String Telefone2 { set; get; }
        public String Telefone3 { set; get; }
        public String Telefone4 { set; get; }
        public String Email { set; get; }
        public String Cpf { set; get; }
        public String Rg { set; get; }
        public String GrauInstrucao { set; get; }
        public String Profissao { set; get; }
        public Boolean Espirita { set; get; }
        public Boolean ConheceEspiritismoKardecista { set; get; }
        public Boolean FezCurso { set; get; }
        public Boolean CursoPbde { set; get; }
        public Boolean CursoEsde { set; get; }
        public Boolean CursoCoem { set; get; }
        public Boolean CursoOutros { set; get; }
        public String AondeCursou { set; get; }
        public Boolean JaLeuLivrosEspiritas { set; get; }
        public String QuaisLivros { set; get; }
        public Boolean GostariaTrabalhoVoluntario { set; get; }
        public Boolean DistribuicaoAlimento { set; get; }
        public Boolean OracaoPasseDomicilio { set; get; }
        public Boolean DistribuicaoAgasalho { set; get; }
        public Boolean Passes { set; get; }
        public Boolean Biblioteca { set; get; }
        public Boolean Palestras { set; get; }
        public Boolean AtendimentoFraterno { set; get; }
        public Boolean VisitaMensalAsilo { set; get; }
        public Boolean PasseDomingo { set; get; }
        public string Status { get; set; }
        public bool? Isento { get; set; }
        public string DataIsentoIni { get; set; }
        public string DataIsentoFin { get; set; }

    }
}
