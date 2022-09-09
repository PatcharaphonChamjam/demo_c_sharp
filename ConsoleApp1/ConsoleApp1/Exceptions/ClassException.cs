using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Exceptions
{
    public class ClassException : Exception
    {
        public ClassException()
        {
        }

        public ClassException(string message) : base(message)
        {
        }

        public ClassException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ClassException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}