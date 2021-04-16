using System;
using System.Collections.Generic;
using System.Text;

namespace Exceptions.IngameAccount
{
    public class GetIngameAccountFailedException : Exception
    {
        public GetIngameAccountFailedException()
        {

        }

        public GetIngameAccountFailedException(string message) : base(message)
        {

        }
    }
}

