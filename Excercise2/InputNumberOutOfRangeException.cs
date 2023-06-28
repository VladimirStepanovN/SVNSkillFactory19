using System.Runtime.Serialization;

namespace Excercise2
{
    [Serializable]
    internal class InputNumberOutOfRangeException : Exception
    {
        public InputNumberOutOfRangeException()
        {
        }

        public InputNumberOutOfRangeException(string? message) : base(message)
        {
        }

        public InputNumberOutOfRangeException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected InputNumberOutOfRangeException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}