using System;
using System.Collections.Generic;
using System.Text;

namespace Exceptions.User
{
    public class SignUpFailedException : Exception
    {
        public SignUpFailedException()
        {

        }

        public SignUpFailedException(string message) : base(message)
        {

        }
    }
}

