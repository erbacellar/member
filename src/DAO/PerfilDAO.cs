using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace CashInBox
{
    public class PerfilDAO
    {
        //Metodo que inclui um perfil no banco
        public static bool Incluir(Perfil Perfil)
        {
            Entities db = SingletonObjectContext.Instance.Context;
            try
            {
                if (Perfil.Items != null)
                {
                    List<ItemFuncionalidade> items = new List<ItemFuncionalidade>();
                    foreach (ItemFuncionalidade x in Perfil.Items)
                    {
                        ItemFuncionalidade i = new ItemFuncionalidade();
                        i.Funcionalidade = FuncionalidadeDAO.ObterFuncionalidadePorId(x.Funcionalidade.Id);
                        i.Alterar = x.Alterar;
                        i.Consultar = x.Consultar;
                        i.Excluir = x.Excluir;
                        i.Imprimir = x.Imprimir;
                        i.Incluir = x.Incluir;
                        items.Add(i);
                    }
                    Perfil.Items = items;
                }
                db.Perfis.Add(Perfil);
                db.SaveChanges();
                return true;
            }
            catch(Exception e)
            {
                return false;
            }

        }

        //Metodo que altera dados de um Perfil do banco
        public static bool Alterar(Perfil Perfil)
        {
            Entities db = SingletonObjectContext.Instance.Context;
            try
            {
                int codigo = Perfil.Id;
                Perfil p = db.Perfis.Include("Items").Include("Items.Funcionalidade").FirstOrDefault(x => x.Id == codigo);
                p.Descricao = Perfil.Descricao;

                if (Perfil.Items != null)
                {
                    List<ItemFuncionalidade> items = new List<ItemFuncionalidade>();
                    foreach (ItemFuncionalidade x in Perfil.Items)
                    {
                        ItemFuncionalidade i = new ItemFuncionalidade();
                        i.Funcionalidade = db.Funcionalidades.First(y => y.Id == x.Funcionalidade.Id);
                        i.Alterar = x.Alterar;
                        i.Consultar = x.Consultar;
                        i.Excluir = x.Excluir;
                        i.Imprimir = x.Imprimir;
                        i.Incluir = x.Incluir;
                        i.Visualizar = x.Visualizar;
                        items.Add(i);
                    }
                    p.Items = items;
                }

                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        //Metodo que exclui um Perfil do banco
        public static bool Excluir(Perfil Perfil)
        {
            Entities db = SingletonObjectContext.Instance.Context;
            try
            {
                Perfil = db.Perfis.First(x => x.Id == Perfil.Id);
                db.Perfis.Remove(Perfil);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        //Metodo que retorna todos os perfis cadastrados do banco
        public static IOrderedEnumerable<Perfil> Listar()
        {
            Entities db = new Entities();
            return db.Perfis.Include("Items").Include("Items.Funcionalidade").ToList().OrderBy(x => x.Descricao);
        }

        //Metodo que retorna um perfil cadastrados do banco
        public static Perfil obterPerfil(int Id)
        {
            Entities db = new Entities();
            try
            {
                return db.Perfis.Include("Items").Include("Items.Funcionalidade").FirstOrDefault(x => x.Id == Id);
            }
            catch
            {
                return null;
            }
        }

        //Metodo que retorna um perfil cadastrados do banco
        public static Perfil obterPerfil(String Descricao)
        {
            Entities db = new Entities();
            try
            {
                return db.Perfis.Include("Items").Include("Items.Funcionalidade").FirstOrDefault(x => x.Descricao.Contains(Descricao));
            }
            catch(Exception exc)
            {
                throw new Exception(exc.Message, exc.InnerException);
            }
        }

        //Metodo que retorna lista de perfis por letra parcialmente inserida
        public static IOrderedEnumerable<Perfil> Listar(Perfil Perfil)
        {
            Entities db = new Entities();
            try
            {
                return db.Perfis.Include("Items").Include("Items.Funcionalidade")
                    .Where(x => x.Descricao.Contains(Perfil.Descricao)).ToList().OrderBy(x => x.Descricao);
            }
            catch
            {
                return null;
            }
        }
    }
}
