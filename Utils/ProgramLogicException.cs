using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utils
{
    public class ProgramLogicException : Exception
    {
        public ProgramLogicException() : base()
        {

        }

        public ProgramLogicException(string message) : base(message)
        {

        }
        public ProgramLogicException(string message, Exception innerException) : base(message, innerException)
        {

        }
    }
}
