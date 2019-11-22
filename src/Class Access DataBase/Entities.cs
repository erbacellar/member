using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;

namespace CashInBox
{
    public class Entities : DbContext
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Molda as tabelas para que as tabelas da aplicacao
            // e as tabelas do banco conversem
            modelBuilder.Entity<Cabecalho>().ToTable("Cabecalhos");
            modelBuilder.Entity<Membro>().ToTable("Membros");
            modelBuilder.Entity<Funcionalidade>().ToTable("Funcionalidades");
            modelBuilder.Entity<Funcionario>().ToTable("Funcionarios");
            modelBuilder.Entity<ItemFuncionalidade>().ToTable("ItensFuncionalidade");
            modelBuilder.Entity<Perfil>().ToTable("Perfis");
            modelBuilder.Entity<PesoGrupo>().ToTable("PesoGrupos");
            modelBuilder.Entity<TelefoneFuncionario>().ToTable("TelefonesFuncionario");
            modelBuilder.Entity<Usuario>().ToTable("Usuarios");
            modelBuilder.Entity<VersaoAtual>().ToTable("VersaoAtual");
            


            base.OnModelCreating(modelBuilder);
        }


        //Seta as tabelas do banco com as tabelas da aplicacao
        public DbSet<Cabecalho> Cabecalhos { set; get; }
        public DbSet<Membro> Membros { set; get; }
        public DbSet<Funcionalidade> Funcionalidades { set; get; }
        public DbSet<Funcionario> Funcionarios { set; get; }
        public DbSet<ItemFuncionalidade> ItemsFuncionalidade { set; get; }
        public DbSet<Perfil> Perfis { set; get; }
        public DbSet<PesoGrupo> PesoGrupos { set; get; }
        public DbSet<TelefoneFuncionario> TelefonesFuncionario { set; get; }
        public DbSet<Usuario> Usuarios { set; get; }
        public DbSet<VersaoAtual> VersaoAtual { set; get; }

        
    }
}
