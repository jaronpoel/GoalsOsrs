using System;
using System.Collections.Generic;
using System.Text;

namespace Exceptions.Stat
{
    public class GetStatFailedException : Exception
    {
        public GetStatFailedException()
        {

        }

        public GetStatFailedException(string message) : base(message)
        {

        }
    }
}

