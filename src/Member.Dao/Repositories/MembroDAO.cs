using Firebase.Database.Query;
using Member.Common.Models;
using Member.Dao.Context;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Member.Dao.Repositories
{
    public class MembroDAO
    {
        const string database = "Membros";

        //Metodo que inclui um Membro no banco
        public static async Task<bool> Incluir(Membro membro)
        {
            var client = FirebaseContext.Instance;
            try
            {
                membro.Id = Convert.ToInt32(membro.Numero);
                var result = await client.Child(database).PostAsync(JsonConvert.SerializeObject(membro));
                membro.Key = result.Key;
                Alterar(membro);
                return true;
            }
            catch
            {
                return false;
            }

        }

        //Metodo que altera dados de um Membro do banco
        public static async Task<bool> Alterar(Membro membro)
        {
            var client = FirebaseContext.Instance;
            try
            {
                await client.Child(database).Child(membro.Key).PutAsync(membro);
                return true;
            }
            catch
            {
                return false;
            }
        }

        //Metodo que exclui um Membro do banco
        public static async Task<bool> Excluir(Membro membro)
        {
            var client = FirebaseContext.Instance;
            try
            {
                await client.Child(database).Child(membro.Key).DeleteAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static async Task<bool> ExcluirTodos()
        {
            var client = FirebaseContext.Instance;
            try
            {
                await client.Child(database).DeleteAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }

        //Metodo que retorna todos os Membros cadastrados do banco
        public static async Task<List<Membro>> ObterMembros()
        {
            var membros = await Listar();
            return membros.OrderBy(x => x.Nome).ToList();
        }

        //Metodo que procura um Membro pelo ID
        public static async Task<Membro> Obter(string key)
        {
            var client = FirebaseContext.Instance;

            try
            {
                var result = await client.Child(database).Child(key).OnceSingleAsync<Membro>();
                return result;
            }
            catch
            {
                return null;
            }
        }

        public static async Task<int?> ObterUltimoMembroId()
        {            
            try
            {
                var membros = await Listar();
                return membros.LastOrDefault()?.Id;
            }
            catch
            {
                return 0;
            }
        }

        //Metodo que procura um Membro por CPF
        public static async Task<Membro> ProcurarMembroPorCpf(Membro Membro)
        {
            try
            {
                var membros = await Listar();
                return membros.FirstOrDefault(x => x.Cpf.Equals(Membro.Cpf));
            }
            catch
            {
                return null;
            }
        }

        //Metodo que retorna lista de Membros em ordem alfabética, por letra parcialmente inserida.Ex.:Insere "a", retorna:"Maria, Joana..."
        public static async Task<List<Membro>> ObterMembrosPorLetraParcial(Membro Membro)
        {            
            try
            {
                var membros = await Listar();
                return membros
                    .Where(x => x.Nome.ToLower().Contains(Membro.Nome.ToLower()) || x.Cpf.Contains(Membro.Cpf)).ToList().OrderBy(x => x.Nome).ToList();
            }
            catch
            {
                return null;
            }
        }

        public static async Task<IOrderedEnumerable<Membro>> ObterMembrosPorVoluntarios()
        {            
            try
            {
                var membros = await Listar();
                return membros
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

        public static async Task<IQueryable<MembroPeso>> GetMembrosPesoGrupo()
        {
            var client = FirebaseContext.Instance;
            var membros = await Listar();
            var pesos = await PesoGruposDAO.Listar();

            var result = from m in membros.AsQueryable()
                         join p in pesos.AsQueryable() on m.GrupoDia + m.GrupoHorario equals p.DiaHorario
                         orderby p.Peso
                         select new MembroPeso()
                         {
                             Membro = m,
                             Peso = p.Peso
                         };
            return result;
        }

        public static async Task<List<Membro>> MembrosPorDiaHorario(string dia, string horario)
        {
            var client = FirebaseContext.Instance;
            var membros = await Listar();

            var result = membros.Where(x => x.GrupoDia == dia && x.GrupoHorario == horario).OrderBy(x => x.Nome).ToList();

            return result;
        }

        public static async Task<List<Membro>> Listar()
        {
            var client = FirebaseContext.Instance;
            var results = await client.Child(database).OnceAsync<Membro>();

            var membros = new List<Membro>();
            foreach (var item in results)
            {
                membros.Add(item.Object);
            }

            return membros;
        }
    }
}
