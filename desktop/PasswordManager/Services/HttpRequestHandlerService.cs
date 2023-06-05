using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
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
            try
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
            }catch(Exception ex)
            {
                return "Server is not responding!";
            }
        }

        public static String PUT(object data,string url,string path)
        {
            try
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
            }catch(Exception ex)
            {
                return "Server is not responding!";
            }
        
        }

        public static string POST(object data, string url, string path,string token)
        {
            try
            {
                var myContent = JsonConvert.SerializeObject(data);
                var buffer = System.Text.Encoding.UTF8.GetBytes(myContent);
                var byteContent = new ByteArrayContent(buffer);
                byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(url);
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                    var result = client.PostAsync(path, byteContent).Result;
                    return result.Content.ReadAsStringAsync().Result;
                }
            }
            catch (Exception ex)
            {
                return "Server is not responding!";
            }
        }

        public static string GET(string url, string path, string token)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(url);
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                    var result = client.GetAsync(path).Result;
                    return result.Content.ReadAsStringAsync().Result;
                }
            }
            catch (Exception ex)
            {
                return "Server is not responding!";
            }
        }

        internal static string DELETE(string url, string path, string bearerToken)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(url);
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", bearerToken);
                    var result = client.DeleteAsync(path).Result;
                    return result.Content.ReadAsStringAsync().Result;
                }
            }
            catch (Exception ex)
            {
                return "Server is not responding!";
            }
        }
    }
}
