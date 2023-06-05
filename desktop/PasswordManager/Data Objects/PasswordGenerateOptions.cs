using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordManager.Data_Objects
{
    internal class PasswordGenerateOptions
    {

        public PasswordGenerateOptions() { 
            hasSpecialCharacters = false;
            hasNumericCharacters = false;
            hasLowerCaseCharacters = true;
            hasUpperCaseCharacters = false;
        }

        public int length;

        public bool hasSpecialCharacters;

        public bool hasNumericCharacters;

        public bool hasUpperCaseCharacters;

        public bool hasLowerCaseCharacters;
    }
}
