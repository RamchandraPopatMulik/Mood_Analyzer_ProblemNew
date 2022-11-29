using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzer_Problem1
{
    public class MoodAnalysisExceptions :Exception
    {
        public MoodAnalysisExceptions()
        {

        }
        public MoodAnalysisExceptions(string message):base(message)
        {

        }
    }
}
