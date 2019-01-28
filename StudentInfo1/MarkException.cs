using System;

namespace StudentInfo1
{
    [Serializable]
    class InvalidMarksException : SystemException
    {
        public InvalidMarksException(string message) : base(String.Format(message))
        {
            
        }
    }
}
