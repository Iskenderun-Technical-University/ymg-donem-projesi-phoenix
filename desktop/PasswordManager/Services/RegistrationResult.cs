using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordManager.Services
{
    internal class RegistrationResult
    {
        bool isSuccess ;

        string message;

        public bool isResultSuccess()
        { return isSuccess; }

        public string Message()
        {
            return message;
        }

        private RegistrationResult SetMessage(string _message)
        {
            this.message = _message;
            return this;
        }

        private RegistrationResult SetResult(bool _result)
        {
            this.isSuccess = _result;
            return this;
        }

        public static RegistrationResult builder(bool _result, string _message)
        {
            return new RegistrationResult()
                .SetResult(_result) 
                .SetMessage(_message);
        }

        public static RegistrationResult builder(bool _result)
        {
            return builder(_result, "");
        }
    }
}
