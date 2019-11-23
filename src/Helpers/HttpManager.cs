using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CashInBox.Helpers
{
    public class HttpManager
    {
        private HttpClient _httpClient => new HttpClient() { Timeout = TimeSpan.FromMinutes(20d) };

        public string BaseUrl { get; set; }

        private readonly JsonSerializerSettings _jsonSettings = new JsonSerializerSettings()
        {
            ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
            NullValueHandling = NullValueHandling.Ignore
        };

        private readonly List<string> _globalHeaders = new List<string>() { "Authorization", "CorrelationId" };

        public HttpManager()
        {
        }
        public HttpManager(string baseUrl)
        {
            BaseUrl = baseUrl;
        }
        private async Task<HttpResponseMessage> PerformAction(
            HttpMethod httpMethod, string resource, dynamic obj,
            IDictionary<string, string> headers, string baseUrl,
            IDictionary<string, string> queryParams, bool throwOnError, string mediaType)
        {
            using (var client = _httpClient)
            {
                SetHeaders(client, headers);

                resource = BuildResource(resource, queryParams);
                client.BaseAddress = new Uri(baseUrl ?? BaseUrl);
                var msg = new HttpRequestMessage(httpMethod, resource);

                if (!httpMethod.Equals(HttpMethod.Get))
                {
                    var jsonParam = JsonConvert.SerializeObject(obj, _jsonSettings);
                    var requestContent = new StringContent(jsonParam, Encoding.UTF8, mediaType ?? "application/json");
                    msg.Content = requestContent;
                }

                var result = await client.SendAsync(msg);
                await HandleNonSuccess(throwOnError, result);

                return result;
            }
        }

        private async Task HandleNonSuccess(bool throwOnError, HttpResponseMessage result)
        {
            if (!result.IsSuccessStatusCode && throwOnError)
            {
                var content = await result.Content.ReadAsStringAsync();
                var obj = JsonConvert.DeserializeObject<Exception>(content, _jsonSettings);
                throw new HttpRequestException(obj?.Message ?? result.ReasonPhrase, obj);
            }
        }

        private void SetHeaders(HttpClient client, IDictionary<string, string> headers = null)
        {
            if (headers != null)
                foreach (var header in headers)
                    client.DefaultRequestHeaders.Add(header.Key, header.Value);            
        }

        private static string BuildResource(string resource, IDictionary<string, string> queryParams)
        {
            var query = string.Empty;
            if (queryParams != null)
                query += "?" +
                         string.Join("&", queryParams.Where(x => x.Value != null)
                             .Select(x => $"{WebUtility.UrlEncode(x.Key)}={WebUtility.UrlEncode(x.Value)}"));
            resource += query;
            return resource;
        }

        #region GET
        private Task<HttpResponseMessage> InternalGet(string resource,
            IDictionary<string, string> headers, string baseUrl,
            IDictionary<string, string> queryParams, bool throwOnError, string mediaType)
        {
            return PerformAction(HttpMethod.Get, resource, null, headers, baseUrl, queryParams, throwOnError, mediaType);
        }

        [Obsolete("Utilizar método async. Será removido em versão futura")]
        public HttpResponseMessage GetResponseMessage(string resource, IDictionary<string, string> headers = null,
            string baseUrl = null, IDictionary<string, string> queryParams = null, string mediaType = null)
        {
            return Task.Run(() => InternalGet(resource, headers, baseUrl, queryParams, false, mediaType)).Result;
        }
        public Task<HttpResponseMessage> GetResponseMessageAsync(string resource, IDictionary<string, string> headers = null,
            string baseUrl = null, IDictionary<string, string> queryParams = null, string mediaType = null)
        {
            return InternalGet(resource, headers, baseUrl, queryParams, false, mediaType);
        }
        [Obsolete("Utilizar método async. Será removido em versão futura")]
        public dynamic GetString(string resource, IDictionary<string, string> headers = null,
            string baseUrl = null, IDictionary<string, string> queryParams = null, string mediaType = null)
        {
            return Task.Run(() => GetStringAsync(resource, headers, baseUrl, queryParams, mediaType)).Result;
        }
        public Task<dynamic> GetStringAsync(string resource, IDictionary<string, string> headers = null,
            string baseUrl = null, IDictionary<string, string> queryParams = null, string mediaType = null)
        {
            return GetAsync<dynamic>(resource, headers, baseUrl, queryParams, mediaType);
        }
        public async Task<T> GetAsync<T>(string resource, IDictionary<string, string> headers = null,
            string baseUrl = null, IDictionary<string, string> queryParams = null, string mediaType = null) where T : class
        {
            var result = await InternalGet(resource, headers, baseUrl, queryParams, true, mediaType);
            var returnResult = await result.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<T>(returnResult, _jsonSettings);
        }
        [Obsolete("Utilizar método async. Será removido em versão futura")]
        public Stream GetStream(string resource, IDictionary<string, string> headers = null,
            string baseUrl = null, IDictionary<string, string> queryParams = null, string mediaType = null)
        {
            return Task.Run(() => GetStreamAsync(resource, headers, baseUrl, queryParams, mediaType)).Result;
        }
        public async Task<Stream> GetStreamAsync(string resource, IDictionary<string, string> headers = null,
            string baseUrl = null, IDictionary<string, string> queryParams = null, string mediaType = null)
        {
            var result = await InternalGet(resource, headers, baseUrl, queryParams, true, mediaType);
            return await result.Content.ReadAsStreamAsync();
        }
        #endregion
        #region POST

        private Task<HttpResponseMessage> InternalPost(string resource, dynamic obj,
            IDictionary<string, string> headers, string baseUrl,
            IDictionary<string, string> queryParams, bool throwOnError, string mediaType)
        {
            return PerformAction(HttpMethod.Post, resource, obj, headers, baseUrl, queryParams, throwOnError, mediaType);
        }

        [Obsolete("Utilizar método async. Será removido em versão futura")]
        public dynamic PostString(string resource, dynamic obj,
            IDictionary<string, string> headers = null, string baseUrl = null,
            IDictionary<string, string> queryParams = null, string mediaType = null)
        {
            return Task.Run(() => PostStringAsync(resource, obj, headers, baseUrl, queryParams, mediaType)).Result;
        }
        public Task<dynamic> PostStringAsync(string resource, dynamic obj,
            IDictionary<string, string> headers = null, string baseUrl = null,
            IDictionary<string, string> queryParams = null, string mediaType = null)
        {
            return PostAsync<dynamic>(resource, obj, headers, baseUrl, queryParams, mediaType);
        }
        public async Task<T> PostAsync<T>(string resource, dynamic obj,
            IDictionary<string, string> headers = null, string baseUrl = null,
            IDictionary<string, string> queryParams = null, string mediaType = null) where T : class
        {
            var result = await InternalPost(resource, obj, headers, baseUrl, queryParams, true, mediaType);
            var stringResult = await result.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<T>(stringResult, _jsonSettings);
        }

        [Obsolete("Utilizar método async. Será removido em versão futura")]
        public Stream PostStream(string resource, dynamic obj,
            IDictionary<string, string> headers = null, string baseUrl = null,
            IDictionary<string, string> queryParams = null, string mediaType = null)
        {
            return Task.Run(() => PostStreamAsync(resource, obj, headers, baseUrl, queryParams, mediaType)).Result;
        }
        public async Task<Stream> PostStreamAsync(string resource, dynamic obj,
            IDictionary<string, string> headers = null, string baseUrl = null,
            IDictionary<string, string> queryParams = null, string mediaType = null)
        {
            var result = await InternalPost(resource, obj, headers, baseUrl, queryParams, true, mediaType);
            return await result.Content.ReadAsStreamAsync();
        }
        public Task<HttpResponseMessage> PostResponseMessageAsync(
            string resource, dynamic obj, IDictionary<string, string> headers = null,
            string baseUrl = null, IDictionary<string, string> queryParams = null, string mediaType = null)
        {
            return InternalPost(resource, obj, headers, baseUrl, queryParams, false, mediaType);
        }

        #endregion
        #region PUT
        private Task<HttpResponseMessage> InternalPut(string resource, dynamic obj,
            IDictionary<string, string> headers, string baseUrl,
            IDictionary<string, string> queryParams, bool throwOnError, string mediaType)
        {
            return PerformAction(HttpMethod.Put, resource, obj, headers, baseUrl, queryParams, throwOnError, mediaType);
        }

        public Task<dynamic> PutStringAsync(string resource, dynamic obj,
            IDictionary<string, string> headers = null, string baseUrl = null,
            IDictionary<string, string> queryParams = null, string mediaType = null)
        {
            return PutAsync<dynamic>(resource, obj, headers, baseUrl, queryParams, mediaType);
        }
        public async Task<T> PutAsync<T>(string resource, dynamic obj,
            IDictionary<string, string> headers = null, string baseUrl = null,
            IDictionary<string, string> queryParams = null, string mediaType = null) where T : class
        {
            var result = await InternalPut(resource, obj, headers, baseUrl, queryParams, true, mediaType);
            var stringResult = await result.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<T>(stringResult, _jsonSettings);
        }
        public async Task<Stream> PutStreamAsync(string resource, dynamic obj,
            IDictionary<string, string> headers = null, string baseUrl = null,
            IDictionary<string, string> queryParams = null, string mediaType = null)
        {
            var result = await InternalPut(resource, obj, headers, baseUrl, queryParams, true, mediaType);
            return await result.Content.ReadAsStreamAsync();
        }
        public Task<HttpResponseMessage> PutResponseMessageAsync(
            string resource, dynamic obj, IDictionary<string, string> headers = null,
            string baseUrl = null, IDictionary<string, string> queryParams = null, string mediaType = null)
        {
            return InternalPut(resource, obj, headers, baseUrl, queryParams, false, mediaType);
        }

        #endregion
        #region PATCH
        private Task<HttpResponseMessage> InternalPatch(string resource, dynamic obj,
            IDictionary<string, string> headers, string baseUrl,
            IDictionary<string, string> queryParams, bool throwOnError, string mediaType)
        {
            return PerformAction(new HttpMethod("PATCH"), resource, obj, headers, baseUrl, queryParams, throwOnError, mediaType);
        }
        public Task<dynamic> PatchStringAsync(string resource, dynamic obj,
            IDictionary<string, string> headers = null, string baseUrl = null,
            IDictionary<string, string> queryParams = null, string mediaType = null)
        {
            return PatchAsync<dynamic>(resource, obj, headers, baseUrl, queryParams, mediaType);
        }
        public async Task<T> PatchAsync<T>(string resource, dynamic obj,
            IDictionary<string, string> headers = null, string baseUrl = null,
            IDictionary<string, string> queryParams = null, string mediaType = null) where T : class
        {
            var result = await InternalPatch(resource, obj, headers, baseUrl, queryParams, true, mediaType);
            var stringResult = await result.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<T>(stringResult, _jsonSettings);
        }
        public async Task<Stream> PatchStreamAsync(string resource, dynamic obj,
            IDictionary<string, string> headers = null, string baseUrl = null,
            IDictionary<string, string> queryParams = null, string mediaType = null)
        {
            var result = await InternalPatch(resource, obj, headers, baseUrl, queryParams, true, mediaType);
            return await result.Content.ReadAsStreamAsync();
        }
        public Task<HttpResponseMessage> PatchResponseMessageAsync(
            string resource, dynamic obj, IDictionary<string, string> headers = null,
            string baseUrl = null, IDictionary<string, string> queryParams = null, string mediaType = null)
        {
            return InternalPatch(resource, obj, headers, baseUrl, queryParams, false, mediaType);
        }

        #endregion
        #region DELETE

        public async Task<HttpResponseMessage> DeleteAsync(string resource, string baseUrl = null)
        {
            using (var client = _httpClient)
            {
                client.Timeout = TimeSpan.FromMinutes(20d);
                client.BaseAddress = new Uri(baseUrl ?? BaseUrl);

                SetHeaders(client);

                return await client.DeleteAsync(resource);
            }
        }
        #endregion
    }
}
