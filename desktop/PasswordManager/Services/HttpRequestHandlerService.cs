using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace PasswordManager.Services
{
    internal class HttpRequestHandlerService
    {
        public static string POST(object data,string url,string path)
        {
            var myContent = JsonConvert.SerializeObject(data);
            var buffer = System.Text.Encoding.UTF8.GetBytes(myContent);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(url);
                var result = client.PostAsync(path, byteContent).Result;
                return result.Content.ReadAsStringAsync().Result;
            }
        }

        public static String PUT(object data,string url,string path)
        {
            var myContent = JsonConvert.SerializeObject(data);
            var buffer = System.Text.Encoding.UTF8.GetBytes(myContent);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(url);
                var result = client.PutAsync(path, byteContent).Result;
                return result.Content.ReadAsStringAsync().Result;
            }
        }

    }
}
