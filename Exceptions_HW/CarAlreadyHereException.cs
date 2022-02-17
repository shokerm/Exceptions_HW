using System.Runtime.Serialization;

namespace Exceptions_HW
{
    [Serializable]
    public class CarAlreadyHereException : ApplicationException
    {
        public CarAlreadyHereException()
        {
        }

        public CarAlreadyHereException(string? message) : base(message)
        {
        }

        public CarAlreadyHereException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected CarAlreadyHereException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}