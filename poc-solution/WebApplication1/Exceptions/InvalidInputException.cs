using System;

namespace WebApplication1.Exceptions
{
    public class InvalidInputException : Exception
    {
        public InvalidInputException(string message)
            :base(message)
        {
        }
    }
}
