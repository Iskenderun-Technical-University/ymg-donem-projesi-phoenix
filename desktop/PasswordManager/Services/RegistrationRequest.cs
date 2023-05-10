using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace PasswordManager.Services
{
    internal class RegistrationRequest
    {

        private string Email { get; set; }

        private string Password { get; set; }

        private string Name { get; set; }

        public RegistrationRequest(string name, string email, string password)
        {
            Name = name;
            Email = email;
            Password = password;
        }

        public Dictionary<string, string> ConvertToJsonString()
        {
            return new Dictionary<string, string>
            {
                { "email", Email },
                { "password", Password },
                { "name", Name }
            };
        }

        public string getEmail()
        {
            return Email;
        }

        public string getPassword()
        {
            return Password;
        }

        public string getName()
        {
            return Name;
        }
    }
}
