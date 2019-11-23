using CashInBox.Helpers;
using CashInBox.Model;
using Newtonsoft.Json;
using RestSharp;
using System.Threading.Tasks;

namespace CashInBox.Controller
{
    public static class CepService
    {
        public static async Task<CepViewModel> EnderecoPorCep(string cep)
        {
            var baseUrl = $"https://viacep.com.br/ws/{cep}/json/";
            var httpManager = new HttpManager(baseUrl);

            var request = await httpManager.GetAsync<CepViewModel>("");
            return request;
        }
    }
}
