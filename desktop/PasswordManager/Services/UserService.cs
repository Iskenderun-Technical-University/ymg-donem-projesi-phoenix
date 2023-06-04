﻿using Microsoft.VisualBasic.ApplicationServices;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
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
    }
}
