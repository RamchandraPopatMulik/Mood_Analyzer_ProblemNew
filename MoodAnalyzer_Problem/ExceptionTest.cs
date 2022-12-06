using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzer_Problem
{
    public class ExceptionTest : Exception
    {
        private readonly ExceptionType type;
        public enum ExceptionType
        {
            NULL_MESSAGE, EMPTY_MESSAGE, NO_SUCH_CLASS, NO_SUCH_METHOD, NO_SUCH_CONSTRUCTOR, NO_SUCH_FIELD
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="ExceptionTest"/> class.
        /// </summary>
        /// <param name="Type">The type.</param>
        /// <param name="message">The message.</param>
        public ExceptionTest(ExceptionType Type, string message) : base(message)
        {
            this.type = Type;
        }
    }
}
