using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzer_Problem1
{
    public class Mood
    {
        string message;
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
                else
                {
                    return "SAD";
                }
            }
            catch
            {
                return "Happy";
            }
          
        }
    }
}
