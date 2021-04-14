using System;
using System.Collections.Generic;
using System.Text;

namespace Exceptions.Goal
{
    public class GetGoalFailedException : Exception
    {
        public GetGoalFailedException()
        {

        }

        public GetGoalFailedException(string message) : base(message)
        {

        }
    }
}

