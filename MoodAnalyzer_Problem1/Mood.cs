using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzer_Problem1
{
    public class Mood
    {
        public string AnalyzeString(string message)
        {
            bool result1 = message.Contains("Happy",StringComparison.OrdinalIgnoreCase);
            if(result1)
            {
                return "Happy";
            }
            bool result2 = message.Contains("Sad",StringComparison.OrdinalIgnoreCase);
            if(result2)
            {
                return "SAD";
            }
            return null;
        }
    }
}
