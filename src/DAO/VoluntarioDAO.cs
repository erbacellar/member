using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using CashInBox.Class_Access_DataBase;
using Newtonsoft.Json;
using Firebase.Database.Query;

namespace CashInBox
{
    class VoluntarioDAO
    {
        const string database = "Voluntarios";

        //Metodo que inclui um Membro no banco
        public static async Task<bool> Incluir(Voluntario voluntario)
        {
            var client = FirebaseContext.Instance;
            try
            {
                var result = await client.Child(database).PostAsync(JsonConvert.SerializeObject(voluntario));
                voluntario.Key = result.Key;
                Alterar(voluntario);
                return true;
            }
            catch
            {
                return false;
            }

        }

        public static async Task<int> UltimoId()
        {
            try
            {
                var voluntarios = await Listar();
                var ultimodId = voluntarios.LastOrDefault()?.Id;

                if (!ultimodId.HasValue)
                    return 0;

                return ultimodId.Value + 1;
            }
            catch
            {
                return 0;
            }
        }

        public static async Task<List<Voluntario>> Listar()
        {
            var client = FirebaseContext.Instance;
            var results = await client.Child(database).OnceAsync<Voluntario>();

            var voluntarios = new List<Voluntario>();
            foreach (var item in results)
            {
                voluntarios.Add(item.Object);
            }

            return voluntarios;
        }

        public static async Task<Voluntario> ObterPorKey(string key)
        {
            var client = FirebaseContext.Instance;

            try
            {
                var result = await client.Child(database).Child(key).OnceSingleAsync<Voluntario>();
                return result;
            }
            catch
            {
                return null;
            }
        }

        public static async Task<bool> Alterar(Voluntario voluntario)
        {
            var client = FirebaseContext.Instance;
            try
            {
                await client.Child(database).Child(voluntario.Key).PutAsync(voluntario);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static async Task<bool> Excluir(Voluntario voluntario)
        {
            try
            {
                var client = FirebaseContext.Instance;
                await client.Child(database).Child(voluntario.Key).DeleteAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static async Task<Voluntario> ObterPorNome(string nome)
        {
            try
            {
                var client = FirebaseContext.Instance;
                var voluntarios = await Listar();
                var voluntario = voluntarios.FirstOrDefault(x => x.Nome.Equals(nome));
                return voluntario;
            }
            catch
            {
                return null;
            }
        }

        public static async Task<Voluntario> ObterPorCpf(string cpf)
        {
            try
            {
                var client = FirebaseContext.Instance;
                var voluntarios = await Listar();
                return voluntarios.FirstOrDefault(x => x.Cpf.Equals(cpf));
            }
            catch
            {
                return null;
            }
        }

        public static async Task<List<Voluntario>> ObterPorNomeOuCpf(Voluntario filtro)
        {
            try
            {
                var client = FirebaseContext.Instance;
                var voluntarios = await Listar();
                return voluntarios
                    .Where(x => x.Nome.ToLower().Contains(filtro.Nome.ToLower()) 
                            || x.Cpf.Contains(filtro.Cpf))
                    .OrderBy(x => x.Nome)
                    .ToList();
            }
            catch
            {
                return null;
            }
        }
    }
}
