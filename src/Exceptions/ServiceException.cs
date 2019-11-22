﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CashInBox
{
    class ServiceException : Exception
    {
        public ServiceException() : base() { }
        public ServiceException(string message) : base(message) { }
        public ServiceException(string message, System.Exception inner) : base(message, inner) { }

        protected ServiceException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    }
}
