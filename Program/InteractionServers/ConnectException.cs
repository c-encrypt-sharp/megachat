using System.Runtime.Serialization;

namespace PPPI_LR2_MODULES
{
    [Serializable]
    internal class ConnectException : Exception
    {
        public ConnectException()
        {
        }

        public ConnectException(string? message) : base(message)
        {
        }

        public ConnectException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected ConnectException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}