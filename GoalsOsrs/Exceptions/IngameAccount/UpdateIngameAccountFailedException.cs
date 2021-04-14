using System;
using System.Collections.Generic;
using System.Text;

namespace Exceptions.Goal
{
    public class UpdateIngameAccountFailedException : Exception
    {
        public UpdateIngameAccountFailedException()
        {

        }

        public UpdateIngameAccountFailedException(string message) : base(message)
        {

        }
    }
}

