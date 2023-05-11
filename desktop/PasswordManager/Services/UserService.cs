using Microsoft.VisualBasic.ApplicationServices;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PasswordManager.Services
{
    internal class UserService
    {
        internal string Register(RegistrationRequest request)
        {
            object data = new 
            {
                email = request.getEmail(),
                password = request.getPassword(),
                name = request.getName(),
            };

            var response = HttpRequestHandlerService.POST(data, "http://localhost:8080","api/auth/register");
            return response;

        }
    }
}
