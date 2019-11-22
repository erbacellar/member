using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace CashInBox
{
    class FuncionarioDAO
    {
        //Metodo que inclui um Funcionario no banco
        public static bool Incluir(Funcionario Funcionario)
        {
            Entities db = SingletonObjectContext.Instance.Context;
            try
            {
                db.Funcionarios.Add(Funcionario);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }

        }

        //Metodo que altera dados de um Funcionario do banco
        public static bool Alterar(Funcionario Funcionario)
        {
            Entities db = SingletonObjectContext.Instance.Context;
            try
            {
                int codigo = Funcionario.Id;
                Funcionario f = db.Funcionarios.Include("Telefones").First(x => x.Id == codigo);
                f.Cpf = Funcionario.Cpf;
                f.DataCadastro = Funcionario.DataCadastro;
                f.Email = Funcionario.Email;

                f.Logradouro = Funcionario.Logradouro;
                f.NumeroEnd = Funcionario.NumeroEnd;
                f.Bairro = Funcionario.Bairro;
                f.Complemento = Funcionario.Complemento;
                f.Cidade = Funcionario.Cidade;
                f.Estado = Funcionario.Estado;
                

                f.Nome = Funcionario.Nome;
                f.Observacao = Funcionario.Observacao;
                f.Rg = Funcionario.Rg;
                f.Status = Funcionario.Status;
                f.Telefones = Funcionario.Telefones;

                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        //Metodo que exclui um Funcionario do banco
        public static bool Excluir(Funcionario Funcionario)
        {
            Entities db = SingletonObjectContext.Instance.Context;
            try
            {
                db.Funcionarios.Remove(Funcionario);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        //Metodo que retorna todos os Funcionarios cadastrados do banco
        public static IOrderedEnumerable<Funcionario> ObterFuncionarios()
        {
            Entities db = new Entities();
            return db.Funcionarios.Include("Telefones").ToList().OrderBy(x => x.Nome);
        }

        //Metodo que procura um Funcionario pelo ID
        public static Funcionario ProcurarFuncionarioPorId(Funcionario Funcionario)
        {
            Entities db = new Entities();
            try
            {
                return db.Funcionarios.Include("Telefones").FirstOrDefault(x => x.Id == Funcionario.Id);
            }
            catch
            {
                return null;
            }
        }

        //Metodo que procura um Funcionario por nome
        public static Funcionario ProcurarFuncionarioPorNome(string nome)
        {
            Entities db = new Entities();
            try
            {
                return db.Funcionarios.Include("Telefones").FirstOrDefault(x => x.Nome.Equals(nome));
            }
            catch
            {
                return null;
            }
        }

        //Metodo que procura um Funcionario por CPF
        public static Funcionario ProcurarFuncionarioPorCpf(string cpf)
        {
            Entities db = new Entities();
            try
            {
                return db.Funcionarios.Include("Telefones").FirstOrDefault(x => x.Cpf.Equals(cpf));
            }
            catch
            {
                return null;
            }
        }
        
        //Metodo que retorna lista de Funcionarios em ordem alfabética, por letra parcialmente inserida.Ex.:Insere "a", retorna:"Maria, Joana..."
        public static IOrderedEnumerable<Funcionario> ObterFuncionariosPorLetraParcial(Funcionario Funcionario)
        {
            Entities db = new Entities();
            try
            {
                return db.Funcionarios.Include("Telefones")
                    .Where(x => x.Nome.Contains(Funcionario.Nome) || x.Cpf.Contains(Funcionario.Cpf)).ToList().OrderBy(x => x.Nome);
            }
            catch
            {
                return null;
            }
        }
    }
}
