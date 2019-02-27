using System;

namespace e4subsea.Logging
{
    public class WrappedException : Exception
    {
        public WrappedException() : this((Exception) null)
        {
        }

        public WrappedException(string message) : base(message)
        {
        }

        public WrappedException(string message, Exception innerException) : base(message, innerException)
        {
        }

		public WrappedException(Exception innerException)
			: base(innerException != null ? innerException.Message : "Missing exception information", 
			innerException)
        {
        }

		
    }
}