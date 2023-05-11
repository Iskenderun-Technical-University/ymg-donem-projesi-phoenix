using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordManager.Services
{
    internal class AuthResult
    {
        bool isSuccess;

        string message;

        public bool isResultSuccess()
        { return isSuccess; }

        public string Message()
        {
            return message;
        }

        private AuthResult SetMessage(string message)
        {
            this.message = message;
            return this;
        }

        private AuthResult SetResult(bool result)
        {
            this.isSuccess = result;
            return this;
        }

        public static AuthResult builder(bool result, string message)
        {
            return new AuthResult()
                .SetResult(result) 
                .SetMessage(message);
        }

        public static AuthResult builder(bool result)
        {
            return new AuthResult()
                .SetResult(result)
                .SetMessage("");
        }
    }
}
