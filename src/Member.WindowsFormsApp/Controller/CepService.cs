using Member.Common.Helpers;
using Member.Common.Models;
using System.Threading.Tasks;

namespace CashInBox.Controller
{
    public static class CepService
    {
        public static async Task<CepModel> EnderecoPorCep(string cep)
        {
            var baseUrl = $"https://viacep.com.br/ws/{cep}/json/";
            var httpManager = new HttpManager(baseUrl);

            var request = await httpManager.GetAsync<CepModel>("");
            return request;
        }
    }
}
