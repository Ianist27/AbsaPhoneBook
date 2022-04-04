using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace AbsaPhoneBook.SharedKernel.ApiHelper
{
    public class Helper
    {
        private static readonly JsonSerializerSettings SerializerSettings = new JsonSerializerSettings()
        {
            NullValueHandling = NullValueHandling.Ignore
        };

        public static async Task<RS> GetAsync<RS>(string urlWithQueryString, Dictionary<string, string> headers = null, string compressionAlgorithm = null, bool? expect100Continue = false)
        {
            var client = new HttpClient();

            try
            {
                var uri = new Uri(urlWithQueryString);

                PopulateHeaders(ref client, headers, compressionAlgorithm, expect100Continue);

                var response = await client.GetAsync(uri);
                string jsonResponse = await response.Content.ReadAsStringAsync();

                if ((int)response.StatusCode == (int)HttpStatusCode.Unauthorized)
                {
                    throw new UnauthorizedAccessException("You are not authorized to perform this operation!");
                }
                else if (response.StatusCode == HttpStatusCode.NotFound)
                {
                    return default;
                }
                else if (!response.IsSuccessStatusCode)
                {
                    throw new Exception(jsonResponse);
                }

                return JsonConvert.DeserializeObject<RS>(jsonResponse);
            }
            finally
            {
                if (client != null)
                {
                    client.Dispose();
                }
            }
        }

        public static async Task<RS> PostAsync<RQ, RS>(string urlWithQueryString, RQ request, Dictionary<string, string> headers = null, string compressionAlgorithm = null, bool? expect100Continue = false)
        {
            var client = new HttpClient();

            try
            {
                var uri = new Uri(urlWithQueryString);
                var jsonRequest = JsonConvert.SerializeObject(request, SerializerSettings);
                byte[] bytes = Encoding.UTF8.GetBytes(jsonRequest);
                ByteArrayContent byteArrayAsHttpContent = new ByteArrayContent(bytes);
                byteArrayAsHttpContent.Headers.ContentLength = bytes.LongLength;
                byteArrayAsHttpContent.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");

                Helper.PopulateHeaders(ref client, headers, compressionAlgorithm, expect100Continue);

                var response = await client.PostAsync(uri, byteArrayAsHttpContent);
                string jsonResponse = await response.Content.ReadAsStringAsync();

                if ((int)response.StatusCode == (int)HttpStatusCode.Unauthorized)
                {
                    throw new UnauthorizedAccessException("You are not authorized to perform this operation!");
                }
                else if (!response.IsSuccessStatusCode && response.StatusCode != HttpStatusCode.NotFound)
                {
                    throw new Exception(jsonResponse);
                }

                byteArrayAsHttpContent.Dispose();

                return JsonConvert.DeserializeObject<RS>(jsonResponse);
            }
            finally
            {
                if (client != null)
                {
                    client.Dispose();
                }
            }
        }

        public static async Task<RS> PutAsync<RQ, RS>(string urlWithQueryString, RQ request, Dictionary<string, string> headers = null, string compressionAlgorithm = null, bool? expect100Continue = false)
        {
            var client = new HttpClient();

            try
            {
                var uri = new Uri(urlWithQueryString);
                var jsonRequest = JsonConvert.SerializeObject(request, SerializerSettings);
                byte[] bytes = Encoding.UTF8.GetBytes(jsonRequest);
                ByteArrayContent byteArrayAsHttpContent = new ByteArrayContent(bytes);
                byteArrayAsHttpContent.Headers.ContentLength = bytes.LongLength;
                byteArrayAsHttpContent.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");

                PopulateHeaders(ref client, headers, compressionAlgorithm, expect100Continue);

                var response = await client.PutAsync(uri, byteArrayAsHttpContent);
                string jsonResponse = await response.Content.ReadAsStringAsync();

                if ((int)response.StatusCode == (int)HttpStatusCode.Unauthorized)
                {
                    throw new UnauthorizedAccessException("You are not authorized to perform this operation!");
                }
                else if (!response.IsSuccessStatusCode && response.StatusCode != HttpStatusCode.NotFound)
                {
                    throw new Exception(jsonResponse);
                }

                byteArrayAsHttpContent.Dispose();

                return JsonConvert.DeserializeObject<RS>(jsonResponse);
            }
            finally
            {
                if (client != null)
                {
                    client.Dispose();
                }
            }
        }

        public static async Task<RS> DeleteAsync<RQ, RS>(string urlWithQueryString, RQ request, Dictionary<string, string> headers = null, string compressionAlgorithm = null, bool? expect100Continue = false)
        {
            var client = new HttpClient();

            try
            {
                var uri = new Uri(urlWithQueryString);

                PopulateHeaders(ref client, headers, compressionAlgorithm, expect100Continue);

                var response = await client.GetAsync(uri);
                string jsonResponse = await response.Content.ReadAsStringAsync();

                if ((int)response.StatusCode == (int)HttpStatusCode.Unauthorized)
                {
                    throw new UnauthorizedAccessException("You are not authorized to perform this operation!");
                }
                else if (!response.IsSuccessStatusCode && response.StatusCode != HttpStatusCode.NotFound)
                {
                    throw new Exception(jsonResponse);
                }

                return JsonConvert.DeserializeObject<RS>(jsonResponse);
            }
            finally
            {
                if (client != null)
                {
                    client.Dispose();
                }
            }
        }

        public static void PopulateHeaders(ref HttpClient client, Dictionary<string, string> headers, string compressionAlgorithm, bool? expect100Continue)
        {
            if (headers != null && headers.Any())
            {
                client.DefaultRequestHeaders.Clear();

                if (!string.IsNullOrEmpty(compressionAlgorithm))
                    client.DefaultRequestHeaders.Add("Accept-Encoding", compressionAlgorithm);

                var expectContinue = (expect100Continue.HasValue && expect100Continue.Value) ? client.DefaultRequestHeaders.ExpectContinue = true : client.DefaultRequestHeaders.ExpectContinue = false;

                foreach (var item in headers)
                {
                    try
                    {
                        client.DefaultRequestHeaders.TryAddWithoutValidation(item.Key, item.Value);
                    }
                    catch (Exception ex)
                    {

                    }
                }
            }
        }
    }
}
