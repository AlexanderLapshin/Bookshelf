using System;

namespace Data.Exceptions
{
    public class InvalidUsernameException : Exception
    {
        public InvalidUsernameException() : base() { }

        public InvalidUsernameException(string message) : base(message) { }
    }
}
