using CashInBox.Class_Access_DataBase;
using Firebase.Database.Query;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashInBox.DAO
{
    public class PesoGruposDAO
    {
        const string database = "PesoGrupos";

        public static async Task Incluir(PesoGrupo peso)
        {
            var client = FirebaseContext.Instance;

            if (peso.Id == 0)
            {
                var ultimoId = await ObterUltimoId();
                peso.Id = ultimoId + 1;
            }

            var result = await client.Child(database).PostAsync(JsonConvert.SerializeObject(peso));

            peso.Key = result.Key;
            Alterar(peso);
        }

        public static async Task Alterar(PesoGrupo peso)
        {
            var client = FirebaseContext.Instance;
            await client.Child(database).Child(peso.Key).PutAsync(peso);
        }

        public static async Task<int> ObterUltimoId()
        {
            var pesos = await Listar();
            var id = pesos.LastOrDefault()?.Id;
            if (!id.HasValue)
                return 0;

            return id.Value;
        }

        public static async Task<List<PesoGrupo>> Listar()
        {
            var client = FirebaseContext.Instance;
            var results = await client.Child(database).OnceAsync<PesoGrupo>();

            var pesos = new List<PesoGrupo>();
            foreach (var item in results)
            {
                pesos.Add(item.Object);
            }

            return pesos;
        }

        public static async Task IncluirListaInicial()
        {
            var pesos = new List<PesoGrupo>()
            {
                new PesoGrupo() { Id = 1, DiaHorario = "SegundaManhã", Peso = 11 },
                new PesoGrupo() { Id = 2,DiaHorario = "SegundaTarde", Peso = 12 },
                new PesoGrupo() { Id = 3,DiaHorario = "SegundaNoite", Peso = 13 },
                new PesoGrupo() { Id = 4,DiaHorario = "TerçaManhã", Peso = 21 },
                new PesoGrupo() { Id = 5,DiaHorario = "TerçaTarde", Peso = 22 },
                new PesoGrupo() { Id = 6,DiaHorario = "TerçaNoite", Peso = 23 },
                new PesoGrupo() { Id = 7,DiaHorario = "QuartaManhã", Peso = 31 },
                new PesoGrupo() { Id = 8,DiaHorario = "QuartaTarde", Peso = 32 },
                new PesoGrupo() { Id = 9,DiaHorario = "QuartaNoite", Peso = 33 },
                new PesoGrupo() { Id = 10,DiaHorario = "QuintaManhã", Peso = 41 },
                new PesoGrupo() { Id = 11,DiaHorario = "QuintaTarde", Peso = 42 },
                new PesoGrupo() { Id = 12,DiaHorario = "QuintaNoite", Peso = 43 },
                new PesoGrupo() { Id = 13,DiaHorario = "SextaManhã", Peso = 51 },
                new PesoGrupo() { Id = 14,DiaHorario = "SextaTarde", Peso = 52 },
                new PesoGrupo() { Id = 15,DiaHorario = "SextaNoite", Peso = 53 },
                new PesoGrupo() { Id = 16,DiaHorario = "SábadoManhã", Peso = 61 },
                new PesoGrupo() { Id = 17,DiaHorario = "SábadoTarde", Peso = 62 },
                new PesoGrupo() { Id = 18,DiaHorario = "SábadoNoite", Peso = 63 },
                new PesoGrupo() { Id = 19,DiaHorario = "DomingoManhã", Peso = 71 },
                new PesoGrupo() { Id = 20,DiaHorario = "DomingoTarde", Peso = 72 },
                new PesoGrupo() { Id = 21,DiaHorario = "DomingoNoite", Peso = 73 }
            };

            foreach (var peso in pesos)
            {
                await Incluir(peso);
            }
        }
    }
}
