using System.Runtime.Serialization;

namespace PPPI_LR2_MODULES
{
    [Serializable]
    internal class DisconnectException : Exception
    {
        public DisconnectException()
        {
        }

        public DisconnectException(string? message) : base(message)
        {
        }

        public DisconnectException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected DisconnectException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}