using System.Runtime.Serialization;

namespace Excercise1
{
    [Serializable]
    internal class MyException : Exception
    {
        private string v1;
        private int v2;

        public MyException()
        {
        }

        public MyException(string? message) : base(message)
        {
        }

        public MyException(string v1, int v2)
        {
            this.v1 = v1;
            this.v2 = v2;
        }

        public MyException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected MyException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}