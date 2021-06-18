using System;
using System.Collections.Generic;
using System.Text;

namespace Exceptions.User
{
    public class DeleteUserFailedException : Exception
    {
        public DeleteUserFailedException()
        {

        }

        public DeleteUserFailedException(string message) : base(message)
        {

        }
    }
}
