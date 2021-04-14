using System;
using System.Collections.Generic;
using System.Text;

namespace Exceptions.Goal
{
    public class DeleteGoalFailedException : Exception
    {
        public DeleteGoalFailedException()
        {

        }

        public DeleteGoalFailedException(string message) : base(message)
        {

        }
    }
}

