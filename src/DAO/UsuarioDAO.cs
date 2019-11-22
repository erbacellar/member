using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace CashInBox
{
    class UsuarioDAO
    {
        //Metodo que inclui um Usuario no banco
        public static bool Incluir(Usuario Usuario)
        {
            Entities db = SingletonObjectContext.Instance.Context;
            try
            {
                Usuario.Perfil = db.Perfis.First(x => x.Id == Usuario.Perfil.Id);
                Usuario.Funcionario = db.Funcionarios.First(x => x.Id == Usuario.Funcionario.Id);
                db.Usuarios.Add(Usuario);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }

        }

        //Metodo que Altera dados de um Usuario no banco
        public static bool Alterar(Usuario Usuario)
        {
            Entities db = SingletonObjectContext.Instance.Context;
            try
            {
                int codigo = Usuario.Id;
                Usuario u = db.Usuarios.Include("Funcionario").Include("Perfil").Include("Perfil.Items").Include("Perfil.Items.Funcionalidade").FirstOrDefault(x => x.Id == codigo);
                u.Funcionario = db.Funcionarios.First(x=> x.Id ==  Usuario.Funcionario.Id);
                u.Login = Usuario.Login;
                u.Perfil = db.Perfis.First(x=> x.Id ==  Usuario.Perfil.Id);
                u.Senha = Usuario.Senha;

                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        //Metodo que exclui um Usuario do banco
        public static bool Excluir(Usuario Usuario)
        {
            Entities db = SingletonObjectContext.Instance.Context;
            try
            {
                db.Usuarios.Remove(Usuario);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        //Metodo que procura um Usuario por Id
        public static Usuario ProcurarUsuarioPorId(int id)
        {
            Entities db = new Entities();
            try
            {
                return db.Usuarios.Include("Funcionario").Include("Perfil").Include("Perfil.Items").Include("Perfil.Items.Funcionalidade").FirstOrDefault(x => x.Id == id);
            }
            catch(Exception exc)
            {
                throw new Exception(exc.Message, exc.InnerException);
            }
        }

        //Metodo que procura um Usuario por usuario informado
        public static Usuario ProcurarUsuarioPorLogin(string login)
        {
            Entities db = new Entities();
            try
            {
                return db.Usuarios.Include("Funcionario").Include("Perfil").Include("Perfil.Items").Include("Perfil.Items.Funcionalidade").FirstOrDefault(x => x.Login.Equals(login));
            }
            catch
            {
                return null;
            }
        }

        //Metodo que procura um Usuario por funcionario informado
        public static Usuario ProcurarUsuarioPorFuncionario(string nomeFuncionario)
        {
            Entities db = new Entities();
            try
            {
                return db.Usuarios.Include("Funcionario").Include("Perfil").Include("Perfil.Items").Include("Perfil.Items.Funcionalidade").FirstOrDefault(x => x.Funcionario.Nome.Equals(nomeFuncionario));
            }
            catch
            {
                return null;
            }
        }

        //Metodo que retorna todos os Usuarios cadastrados no banco
        public static IOrderedEnumerable<Usuario> ObterUsuarios()
        {
            Entities db = new Entities();

            return db.Usuarios.Include("Funcionario").Include("Perfil").Include("Perfil.Items").Include("Perfil.Items.Funcionalidade").ToList().OrderBy(x => x.Funcionario.Nome);

        }

        //Metodo que retorna uma lista de Usuarios por letra parcialmente inserida
        public static IOrderedEnumerable<Usuario> ObterUsuariosPorParcial(Usuario Usuario)
        {
            Entities db = new Entities();
            try
            {
                return db.Usuarios.Include("Funcionario").Include("Perfil").Include("Perfil.Items").Include("Perfil.Items.Funcionalidade").Where(x => x.Funcionario.Nome.Contains(Usuario.Funcionario.Nome)
                || x.Login.Contains(Usuario.Login) || x.Perfil.Descricao.Contains(Usuario.Perfil.Descricao)).ToList().OrderBy(x => x.Funcionario.Nome);
            }
            catch
            {
                return null;
            }


        }
    }
}
