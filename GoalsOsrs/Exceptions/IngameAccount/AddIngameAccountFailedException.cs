using System;
using System.Collections.Generic;
using System.Text;

namespace Exceptions.Goal
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

