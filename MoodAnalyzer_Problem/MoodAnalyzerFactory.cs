using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzer_Problem
{
    public class MoodAnalyserFactory
    {
        /// <summary>
        /// Creates the mood analyser object.
        /// </summary>
        /// <param name="className">Name of the class.</param>
        /// <param name="constructorName">Name of the constructor.</param>
        /// <returns></returns>
        /// <exception cref="Mood__Analyzer_Problem.ExceptionTest">
        /// Class Not Found
        /// or
        /// Constructor Not Found
        /// </exception>
        public static object CreateMoodAnalyserObject(string className, [Optional] string constructorName, [Optional] string message)
        {
            Type moodAnalyserType = Type.GetType(className);
            try
            {
                if (moodAnalyserType == null)
                {
                    throw new ExceptionTest(ExceptionTest.ExceptionType.NO_SUCH_CLASS, "Class Not Found");
                }
                if (constructorName != null)
                {
                    if (moodAnalyserType.Name != constructorName)
                    {
                        throw new ExceptionTest(ExceptionTest.ExceptionType.NO_SUCH_CONSTRUCTOR, "Constructor Not Found");
                    }
                }
                if (message != null)
                {
                    ConstructorInfo ctor = moodAnalyserType.GetConstructor(new[] { typeof(string) });
                    object[] parameters = { message };
                    return ctor.Invoke(new object[] { message });
                }
                return Activator.CreateInstance(moodAnalyserType);
            }
            catch (ExceptionTest ex)
            {
                return ex.Message;
            }
        }
        public static object InvokeAnalyseMood(string message, string methodName)
        {
            Type moodAnalyserType = Type.GetType("Mood_Analyzer_Problem.Mood_Analyzer");
            try
            {
                object moodAnalyserObject = MoodAnalyserFactory.CreateMoodAnalyserObject("Mood_Analyzer_Problem.Mood_Analyzer", "Mood_Analyzer", message);
                MethodInfo analyseMoodMethod = moodAnalyserType.GetMethod(methodName);
                if (analyseMoodMethod == null)
                {
                    throw new ExceptionTest(ExceptionTest.ExceptionType.NO_SUCH_METHOD, "Method Not Found");
                }
                object mood = analyseMoodMethod.Invoke(moodAnalyserObject, null);
                return mood;
            }
            catch (ExceptionTest ex)
            {
                return ex.Message;
            }
        }
        public static string SetField(string message, string propertyName)
        {
            Type moodAnalyserType = Type.GetType("Mood_Analyzer_Problem.Mood_Analyzer");
            object moodAnalyserObject = MoodAnalyserFactory.CreateMoodAnalyserObject("Mood_Analyzer_Problem.Mood_Analyzer");
            try
            {
                PropertyInfo property = moodAnalyserType.GetProperty(propertyName);
                if (message == null)
                {
                    throw new ExceptionTest(ExceptionTest.ExceptionType.NULL_MESSAGE, "Message Should not be Null");

                }
                if (property == null)
                {
                    throw new ExceptionTest(ExceptionTest.ExceptionType.NO_SUCH_FIELD, "Field Not Found");

                }
                property.SetValue(moodAnalyserObject, message);
                object analyseMood = InvokeAnalyseMood(message, "AnalyzeMood");
                return analyseMood.ToString();
            }
            catch (ExceptionTest ex)
            {
                return ex.Message;
            }
        }
    }
}
