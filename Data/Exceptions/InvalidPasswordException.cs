using System;

namespace Bookshelf.Exceptions
{
    public class InvalidPasswordException : Exception
    {
        public InvalidPasswordException() : base() { }

        public InvalidPasswordException(string message) : base(message) { }
    }
}
