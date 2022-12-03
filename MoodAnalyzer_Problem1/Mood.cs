using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using MoodAnalyzer_Problem1;
using System.Security.Cryptography.X509Certificates;

namespace MoodAnalyzer_Problem1
{
    public class Mood
    {
        public string message { get; set; }
        public Mood()
        {

        }
        public Mood (string message)
        {
            this.message = message;
        }
        public string AnalyzeString()
        {
            try
            {
                if(message==null)
                {
                    throw new MoodAnalysisExceptions(MoodError.Null.ToString());
                }
                if (message == " ")
                {
                    throw new MoodAnalysisExceptions(MoodError.Empty.ToString());
                }

                bool result1 = message.Contains("Happy", StringComparison.OrdinalIgnoreCase);
                if (result1)
                {
                    return "Happy";
                }
                bool result2 = message.Contains("Sad", StringComparison.OrdinalIgnoreCase);
                if (result2)
                {
                    return "SAD";
                }
                else
                {
                    return "Happy";
                }
            }
            catch(MoodAnalysisExceptions ex)
            {
                return ex.Message;
            }
            catch (Exception ex)
            {
                return "Happy";
            }
        }
    }
    public enum MoodError
    { 
        Null,
        Empty,
        No_Such_Class,
        No_Such_Method,

    }
    public class MoodFactory
    {
        public MoodFactory()
        {


        }
        public static object CreateInstance(string className, [Optional] string constructorName)
        {

            try
            {
                Type type = Type.GetType(className);
                if (type == null)
                {
                    throw new MoodAnalysisExceptions(MoodError.No_Such_Class.ToString());
                }
                else if (constructorName != null)
                {
                    bool exists = false;
                    var constructors = type.GetConstructors();
                    foreach (var constructor in constructors)
                    {
                        if (constructor.ToString() == constructorName)
                        {
                            exists = true;
                            continue;
                        }
                    }
                    if (!exists)
                    {
                        throw new MoodAnalysisExceptions(MoodError.No_Such_Method.ToString());
                    }
                }
                return type;
            }
            catch (MoodAnalysisExceptions ex)
            {
                return ex.Message;
            }
        }
    }
}
