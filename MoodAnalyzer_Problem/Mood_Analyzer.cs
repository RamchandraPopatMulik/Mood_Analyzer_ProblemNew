using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzer_Problem
{
    public class Mood_Analyzer
    {
        public string message { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Mood_Analyzer"/> class.
        /// </summary>
        public Mood_Analyzer() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Mood_Analyzer"/> class.
        /// </summary>
        /// <param name="message">The message.</param>
        public Mood_Analyzer(string message)
        {
            this.message = message;
        }
        /// <summary>
        /// Analyzes the mood.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Mood__Analyzer_Problem.ExceptionTest">Mood Should not be Empty</exception>
        public string AnalyzeMood()
        {
            try
            {

                if (this.message == null)
                {
                    throw new ExceptionTest(ExceptionTest.ExceptionType.NULL_MESSAGE, "Mood Should not be Null");
                }
                if (this.message.Equals(string.Empty))
                {
                    throw new ExceptionTest(ExceptionTest.ExceptionType.EMPTY_MESSAGE, "Mood Should not be Empty");
                }
                if (this.message.Contains("Sad", StringComparison.OrdinalIgnoreCase))
                {
                    return "SAD";
                }
                else if (this.message.Contains("Happy", StringComparison.OrdinalIgnoreCase))
                {
                    return "HAPPY";
                }
                else if (this.message.Contains("Any", StringComparison.OrdinalIgnoreCase))
                {
                    return "HAPPY";
                }
                else
                {
                    return "HAPPY";
                }
            }
            catch (ExceptionTest ex)
            {
                return ex.Message;
            }
        }
    }
}
