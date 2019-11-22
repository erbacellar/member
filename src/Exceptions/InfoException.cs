using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CashInBox
{
    class InfoException : Exception
    {
        public InfoException() : base() { }
        public InfoException(string message) : base(message) { }
        public InfoException(string message, System.Exception inner) : base(message, inner) { }

        protected InfoException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    }
}
