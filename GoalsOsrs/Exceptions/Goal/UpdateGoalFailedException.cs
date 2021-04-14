using System;
using System.Collections.Generic;
using System.Text;

namespace Exceptions.Goal
{
    public class UpdateGoalFailedException : Exception
    {
        public UpdateGoalFailedException()
        {

        }

        public UpdateGoalFailedException(string message) : base(message)
        {

        }
    }
}

