using Microsoft.VisualBasic.ApplicationServices;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using PasswordManager.Data_Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PasswordManager.Services
{
    internal class UserService
    {
        private static string bearerToken;

        private static string UPPER_CASE = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private static string LOWER_CASE = "abcdefghijklmnopqrstuvwxyz";
        private static string NUMS = "1234567890";
        private static string SPECIAL = "!@#$%&*()./\\<>?_+{}";

        internal static RegistrationResult Register(RegistrationRequest request)
        {
            object data = new 
            {
                email = request.getEmail(),
                password = request.getPassword(),
                name = request.getName(),
            };

            string response = HttpRequestHandlerService.POST(data, "http://localhost:8080","api/auth/register");
            JObject jsonObject = JsonConvert.DeserializeObject<JObject>(response);

            if (response.Contains("message"))
            {
                return RegistrationResult.builder(true, jsonObject["message"].ToString());
            }
            else
            {
               return RegistrationResult.builder(false, response);
            }

        }

        public static string getToken()
        {
            return bearerToken;
        }


        private static string getTokenFromResponse(string response)
        {
            JObject jsonObject = JObject.Parse(response);
            string token = jsonObject["token"].ToString();
            return token;
        }

        internal static string VerifyAccount(string text)
        {
            object data = new
            {
                key = text
            };

            var response = HttpRequestHandlerService.PUT(data, "http://localhost:8080", "api/auth/verify");
            JObject jsonObject = JsonConvert.DeserializeObject<JObject>(response);
            return jsonObject["message"].ToString();
        }

        internal static AuthResult Login(string _email, string _password)
        {
            object data = new
            {
                email = _email,
                password = _password
            };

            var response = HttpRequestHandlerService.POST(data, "http://localhost:8080", "api/auth/login");

            if (response.Contains("token"))
            {
                bearerToken = getTokenFromResponse(response);
                return AuthResult.builder(true,bearerToken);
            }
            else
            {
                return AuthResult.builder(false, response);
            }
        }

        internal static string RequestPasswordReset(string text)
        {
            object data = new
            {
                email = text
            };

            string response = HttpRequestHandlerService.POST(data, "http://localhost:8080", "api/auth/reset-password");
            JObject jsonObject = JsonConvert.DeserializeObject<JObject>(response);
            return jsonObject["message"].ToString();
        }

        internal static string ResetPassword(string code, string password)
        {
            object data = new
            {
                code = code,
                password = password
            };

            string response = HttpRequestHandlerService.PUT(data, "http://localhost:8080", "api/auth/reset-password");
            JObject jsonObject = JsonConvert.DeserializeObject<JObject>(response);
            return jsonObject["message"].ToString();
        }

        internal static List<PasswordObject> GetPasswords()
        {
            string response = HttpRequestHandlerService.GET("http://localhost:8080", "api/me/password",bearerToken);
            List<PasswordObject> jsonObject = JsonConvert.DeserializeObject<List<PasswordObject>>(response);
            return jsonObject;
        }

        internal static string SavePassword(PasswordObject password)
        {
            object data = new
            {
                title = password.Title,
                username = password.Username,
                password = password.Password,
                url = password.Url,
                notes = password.Notes
            };
            string response = HttpRequestHandlerService.POST(data,"http://localhost:8080", "api/me/password", bearerToken);
            JObject jsonObject = JsonConvert.DeserializeObject<JObject>(response);
            return jsonObject["message"].ToString();
        }

        internal static string UpdatePassword(string id, PasswordObject password)
        {
            object data = new
            {
                title = password.Title,
                username = password.Username,
                password = password.Password,
                url = password.Url,
                notes = password.Notes
            };
            string response = HttpRequestHandlerService.POST(data, "http://localhost:8080", "api/me/password/" + id, bearerToken);
            JObject jsonObject = JsonConvert.DeserializeObject<JObject>(response);
            return jsonObject["message"].ToString();
        }

        internal static void DeletePassword(string id)
        {
            string response = HttpRequestHandlerService.DELETE("http://localhost:8080", "api/me/password/" + id, bearerToken);
            
        }

        internal static string GeneratePassword(PasswordGenerateOptions options)
        {
            string generatedPassword = "";
            List<string> passwordChars = new List<string>();
            if(options.hasUpperCaseCharacters)
            {
                passwordChars.Add(UPPER_CASE);
            }
            if (options.hasLowerCaseCharacters)
            {
                passwordChars.Add(LOWER_CASE);
            }
            if(options.hasSpecialCharacters) {
                passwordChars.Add(SPECIAL);
            }
            if (options.hasNumericCharacters)
            {
                passwordChars.Add(NUMS);
            }

            StringBuilder stringBuilder = new StringBuilder();
            Random random = new Random();

            for (int i = 0; i < options.length; i++)
            {
                string chars = passwordChars[(i % passwordChars.Count())];
                int index = random.Next(chars.Length);
                stringBuilder.Append(chars[index]);
            }
            generatedPassword = stringBuilder.ToString();

            return generatedPassword;
        }
    }
}
