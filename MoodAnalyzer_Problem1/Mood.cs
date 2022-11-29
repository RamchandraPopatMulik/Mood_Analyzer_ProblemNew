using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoodAnalyzer_Problem1;
namespace MoodAnalyzer_Problem1
{
    public class Mood
    {
        string message=string.Empty;
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
            catch (Exception ex)
            {
                return "Happy";
            }
        }
    }
    public enum MoodError
    {
        Invalid,
        Null,
        Empty
    }
}
