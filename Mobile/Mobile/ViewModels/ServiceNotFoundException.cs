using System;
using System.Runtime.Serialization;

namespace Mobile.ViewModels
{
    [Serializable]
    internal class ServiceNotFoundException : Exception
    {
        public ServiceNotFoundException()
        {
        }

        public ServiceNotFoundException(string message) : base(message)
        {
        }

        public ServiceNotFoundException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ServiceNotFoundException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}