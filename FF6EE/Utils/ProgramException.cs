using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace FF6EE.Utils
{
    public class ProgramException : Exception
    {
        private List<string> _errorMessages { get; set; }

        private Exception _innerException { get; set; }

        public ProgramException(string message) : base(message)
        {
            _errorMessages = new List<string> { message };
        }

        public ProgramException(string message, Exception innerException) : base(message, innerException)
        {
            _innerException = innerException;
            _errorMessages = new List<string> { GetExceptionOrigin() };

            if (innerException is ProgramException programInnerException)
            {
                _errorMessages.Add(message);
                _errorMessages.AddRange(programInnerException._errorMessages);
            }
            else
            {
                _errorMessages.Add(message);
                _errorMessages.Add(innerException.ToString());
            }
        }

        public ProgramException(Exception innerException) : base(string.Empty, innerException)
        {
            _innerException = innerException;
            _errorMessages = new List<string> { GetExceptionOrigin() };

            if (innerException is ProgramException programInnerException)
            {
                _errorMessages.AddRange(programInnerException._errorMessages);
            }
            else
            {
                _errorMessages.Add(innerException.ToString());
            }
        }

        private string GetExceptionOrigin()
        {
            StackTrace stackTrace = new StackTrace(_innerException, true);
            StackFrame frame = stackTrace.GetFrame(stackTrace.FrameCount - 1);
            string methodName = frame.GetMethod().Name;
            string className = frame.GetMethod().DeclaringType.Name;

            return $"In {className}, method: {methodName}";
        }
        public override string ToString()
        {
            return string.Join(Environment.NewLine, _errorMessages);
        }

        public void Log()
        {
            using (FileStream fs = new FileStream(Path.Combine(AppContext.BaseDirectory, "error.log"), FileMode.Create, FileAccess.Write))
            {
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    sw.WriteLine($"[{DateTime.Now}] {ToString()}");
                }
            }
        }
    }
}
