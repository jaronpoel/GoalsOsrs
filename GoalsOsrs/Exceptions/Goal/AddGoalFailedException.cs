using System;
using System.Collections.Generic;
using System.Text;

namespace Exceptions.Goal
{
    public class AddGoalFailedException : Exception
    {
        public AddGoalFailedException()
        {

        }

        public AddGoalFailedException(string message) : base(message)
        {

        }
    }
}

