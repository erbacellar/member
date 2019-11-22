using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CashInBox
{
    class ErrorException : Exception
    {
        public ErrorException() : base() { }
        public ErrorException(string message) : base(message) { }
        public ErrorException(string message, System.Exception inner) : base(message, inner) { }

        protected ErrorException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    }
}
