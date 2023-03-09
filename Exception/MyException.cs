using System;

namespace exception
{
    class MyException : Exception
    {
        public MyException() : base("This is My exception")
        {
        }

        public MyException(string message) : base(message)
        {

        }
    }
}
