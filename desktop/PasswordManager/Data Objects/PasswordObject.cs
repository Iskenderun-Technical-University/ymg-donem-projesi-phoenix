using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordManager.Data_Objects
{
    internal class PasswordObject
    {
        public PasswordObject() { }

        public string Id { get; set; }

        public string UserId { get; set; }

        public string Title { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public string Url { get; set; }

        public string Notes { get; set; }

    }
}
