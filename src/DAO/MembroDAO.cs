using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace CashInBox
{
    class MembroDAO
    {
        //Metodo que inclui um Membro no banco
        public static bool Incluir(Membro Membro)
        {
            Entities db = SingletonObjectContext.Instance.Context;
            try
            {
                db.Membros.Add(Membro);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }

        }

        //Metodo que altera dados de um Membro do banco
        public static bool Alterar(Membro Membro)
        {
            Entities db = SingletonObjectContext.Instance.Context;
            try
            {
                int codigo = Membro.Id;
                Membro m = db.Membros.First(x => x.Id == codigo);
                m.Cpf = Membro.Cpf;
                m.DataEntrada = Membro.DataEntrada;
                m.DataNascimento = Membro.DataNascimento;
                m.DataSaida = Membro.DataSaida;

                m.Cep = Membro.Cep;
                m.Logradouro = Membro.Logradouro;
                m.NumEnd = Membro.NumEnd;
                m.Bairro = Membro.Bairro;
                m.Complemento = Membro.Complemento;
                m.Cidade = Membro.Cidade;
                m.Estado = Membro.Estado;

                m.Status = Membro.Status;
                m.Isento = Membro.Isento;

                if (Membro.DataIsentoIni != null)
                {
                    m.DataIsentoIni = Membro.DataIsentoIni;
                }

                if (Membro.DataIsentoFin != null)
                {
                    m.DataIsentoFin = Membro.DataIsentoFin;
                }

                m.Numero = Membro.Numero;
                m.Nome = Membro.Nome;
                m.Rg = Membro.Rg;
                m.GrupoDia = Membro.GrupoDia;
                m.GrupoHorario = Membro.GrupoHorario;

                m.Telefone1 = Membro.Telefone1;
                m.Telefone2 = Membro.Telefone2;
                m.Telefone3 = Membro.Telefone3;
                m.Telefone4 = Membro.Telefone4;
                m.Email = Membro.Email;

                m.Espirita = Membro.Espirita;
                m.ConheceEspiritismoKardecista = Membro.ConheceEspiritismoKardecista;
                m.FezCurso = Membro.FezCurso;
                m.CursoPbde = Membro.CursoPbde;
                m.CursoEsde = Membro.CursoEsde;
                m.CursoCoem = Membro.CursoCoem;
                m.CursoOutros = Membro.CursoOutros;
                m.AondeCursou = Membro.AondeCursou;
                m.JaLeuLivrosEspiritas = Membro.JaLeuLivrosEspiritas;
                m.QuaisLivros = Membro.QuaisLivros;
                m.GostariaTrabalhoVoluntario = Membro.GostariaTrabalhoVoluntario;
                m.DistribuicaoAlimento = Membro.DistribuicaoAlimento;
                m.DistribuicaoAgasalho = Membro.DistribuicaoAgasalho;
                m.OracaoPasseDomicilio = Membro.OracaoPasseDomicilio;
                m.Passes = Membro.Passes;
                m.Palestras = Membro.Palestras;
                m.Biblioteca = Membro.Biblioteca;
                m.AtendimentoFraterno = Membro.AtendimentoFraterno;
                m.VisitaMensalAsilo = Membro.VisitaMensalAsilo;
                m.PasseDomingo = Membro.PasseDomingo;

                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        //Metodo que exclui um Membro do banco
        public static bool Excluir(Membro Membro)
        {
            Entities db = SingletonObjectContext.Instance.Context;
            try
            {
                db.Membros.Remove(Membro);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        //Metodo que retorna todos os Membros cadastrados do banco
        public static IOrderedEnumerable<Membro> ObterMembros()
        {
            Entities db = new Entities();
            return db.Membros.ToList().OrderBy(x => x.Nome);
        }

        //Metodo que procura um Membro pelo ID
        public static Membro Obter(int id)
        {
            Entities db = new Entities();
            try
            {
                return db.Membros.FirstOrDefault(x => x.Id == id);
            }
            catch
            {
                return null;
            }
        }

        public static int ObterUltimoMembroId()
        {
            Entities db = new Entities();
            try
            {
                return db.Membros.AsEnumerable().LastOrDefault().Id;
            }
            catch
            {
                return 0;
            }
        }

        //Metodo que procura um Membro por nome
        public static Membro Obter(string nome)
        {
            Entities db = new Entities();
            try
            {
                return db.Membros.FirstOrDefault(x => x.Nome.Equals(nome));
            }
            catch
            {
                return null;
            }
        }

        //Metodo que procura um Membro por CPF
        public static Membro ProcurarMembroPorCpf(Membro Membro)
        {
            Entities db = new Entities();
            try
            {
                return db.Membros.FirstOrDefault(x => x.Cpf.Equals(Membro.Cpf));
            }
            catch
            {
                return null;
            }
        }

        //Metodo que retorna lista de Membros em ordem alfabética, por letra parcialmente inserida.Ex.:Insere "a", retorna:"Maria, Joana..."
        public static IOrderedEnumerable<Membro> ObterMembrosPorLetraParcial(Membro Membro)
        {
            Entities db = new Entities();
            try
            {
                return db.Membros
                    .Where(x => x.Nome.Contains(Membro.Nome) || x.Cpf.Contains(Membro.Cpf)).ToList().OrderBy(x => x.Nome);
            }
            catch
            {
                return null;
            }
        }

        public static IOrderedEnumerable<Membro> ObterMembrosPorVoluntarios()
        {
            Entities db = new Entities();
            try
            {
                return db.Membros
                    .Where(x => x.GostariaTrabalhoVoluntario == true && 
                    (x.DistribuicaoAlimento || 
                    x.DistribuicaoAgasalho || 
                    x.Biblioteca || 
                    x.OracaoPasseDomicilio || 
                    x.Passes || 
                    x.Biblioteca || 
                    x.Palestras || 
                    x.AtendimentoFraterno || 
                    x.VisitaMensalAsilo || 
                    x.PasseDomingo)).ToList().OrderBy(x => x.Nome);
            }
            catch (Exception e)
            {
                return new List<Membro>().OrderBy(x => x.Id);
            }
        }

        public static IQueryable<MembroPeso> GetMembrosPesoGrupo()
        {
            var db = new Entities();
            var result = from m in db.Membros
                         join p in db.PesoGrupos on m.GrupoDia + m.GrupoHorario equals p.DiaHorario
                         orderby p.Peso
                         select new MembroPeso()
                         {
                             Membro = m,
                             Peso = p.Peso
                         };
            return result;
        }
    }
}
