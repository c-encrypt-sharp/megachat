using System.Runtime.Serialization;

namespace PPPI_LR2_MODULES
{
    [Serializable]
    internal class AuthenticateException : Exception
    {
        public AuthenticateException()
        {
        }

        public AuthenticateException(string? message) : base(message)
        {
        }

        public AuthenticateException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected AuthenticateException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}