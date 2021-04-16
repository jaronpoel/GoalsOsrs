using System;
using System.Collections.Generic;
using System.Text;

namespace Exceptions.IngameAccount
{
    public class AddIngameAccountFailedException : Exception
    {
        public AddIngameAccountFailedException()
        {

        }

        public AddIngameAccountFailedException(string message) : base(message)
        {

        }
    }
}

