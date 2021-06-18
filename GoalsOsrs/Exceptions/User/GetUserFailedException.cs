using System;
using System.Collections.Generic;
using System.Text;

namespace Exceptions.User
{
    public class GetUserFailedException : Exception
    {
        public GetUserFailedException()
        {

        }

        public GetUserFailedException(string message) : base(message)
        {

        }
    }
}

