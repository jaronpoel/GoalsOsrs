using System;
using System.Collections.Generic;
using System.Text;

namespace Exceptions.Goal
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

